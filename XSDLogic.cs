#region Copyright Notice
/**
 * Copyright 2016 National Security Technologies, LLC
 * 
 * This manuscript has been authored by National Security Technologies, LLC,
 * under Contract No. DE-AC52-06NA25946 with the U.S. Department of Energy
 * 
 * DISCLAIMER
 * This document was prepared as an account of work sponsored by an agency 
 * of the United States Government. Neither the United States Government nor
 * any agency thereof, nor any of their employees, nor any of their contractors,
 * subcontractors or their employees, makes any warranty, express or implied,
 * or assumes any legal liability or responsibility for the accuracy, completeness,
 * or any third party's use or the results of such use of any information, 
 * apparatus, product, or process disclosed, or represents that its use would not
 * infringe privately owned rights. Reference herein to any specific commercial
 * product, process, or service by trade name, trademark, manufacturer, or 
 * otherwise, does not necessarily constitute or imply its endorsement, 
 * recommendation, or favoring by the United States Government or any agency 
 * thereof or its contractors or subcontractors. The views and opinions of authors
 * expressed herein do not necessarily state or reflect those of the United States
 * Government or any agency thereof.

Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
 */

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gov.nnss.rsl.xsim.impl;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace gov.nnss.rsl.xsim.xsd
{





    public partial class PolynomialEquation
    {
        public double EvaluatePoly(double x)
        {
            double y = 0.0;
            foreach (PolynomialPair aPair in termField)
            {
                y += aPair.Coefficient * Math.Pow(x, aPair.Exponent);
            }
            return y;
        }
    }

    public partial class TemporalAnalyticalFloat : TimeDependentFloat
    {
        public double getValueAt(DateTime aTime)
        {
            TimeSpan aSpan = aTime - this.Time;
            return Value.EvaluatePoly(aSpan.TotalSeconds);
        }
    }
    public partial class InstrumentEfficiency
    {
                            
        DateTime[] timeArray = null;
        /**
         * Instrument efficiencies may vary over time and distance from the ground.
         * 
         * */
        public double[] getEffAsOf(DateTime aTime, double distance)
        {
            if (timeArray == null) timeArray = EffCurves.Select(e => e.AsOfTime).ToArray<DateTime>();
            
            double fraction;
            int  index;
            double[]  baseEff;
            bool success = Utilities.interpolateTimes(timeArray, aTime, out fraction, out index);
           // if (!success) return null;

            if (EffCurves[index].Item is AnalyticalDistanceEfficiency)
            {
                AnalyticalDistanceEfficiency anaEff = (AnalyticalDistanceEfficiency)EffCurves[index].Item;
                baseEff = anaEff.getEfficiency(distance);
            } else {
                InterpolatedDistanceEfficiency interpEff = (InterpolatedDistanceEfficiency)EffCurves[index].Item;
                baseEff = interpEff.getEfficiency(distance);
            }

            // no fractional time so the base is true
            if (fraction == 0) return baseEff;

            // otherwise grab the next eff value for interpolation over time steps
            double[] fullRangeEff;

            if (EffCurves[index + 1].Item is AnalyticalDistanceEfficiency)
            {
                AnalyticalDistanceEfficiency anaEff = (AnalyticalDistanceEfficiency)EffCurves[index+1].Item;
                fullRangeEff = anaEff.getEfficiency(distance);
            }
            else
            {
                InterpolatedDistanceEfficiency interpEff = (InterpolatedDistanceEfficiency)EffCurves[index+1].Item;
                fullRangeEff = interpEff.getEfficiency(distance);
            }

            // interpolate each channel over the temporal dimension
            double[] effValues = new double[fullRangeEff.Length];
            for (int i = 0; i < fullRangeEff.Length; i++)
            {
                effValues[i] = baseEff[i] + fraction * (fullRangeEff[i] - baseEff[i]);
            }

            return effValues;
        }

    }
    public abstract partial class SourceDistribution
    {

        /**
         * Return the ground truth value before it is blurred by the measurment 
         * */
        public abstract double getIntensity(Dictionary<String, Object> results, double lat, double lon, double alt, double height,  DateTime asOf);
        private Dictionary<string, InstrumentEfficiency> instResponse = null;
        protected Dictionary<InstrumentType, double[][]> cachedEff = null; 
        protected double srcDistance = 0.0;

        private InstrumentEfficiency getInstrumentResponse(string instrumentID)
        {
            if (instResponse == null)
            {
                instResponse = new Dictionary<string, InstrumentEfficiency>(this.InstrumentResponse.Length);
                foreach (InstrumentEfficiency anEff in InstrumentResponse)
                {
                    instResponse.Add(anEff.InstrumentRef, anEff);
                }

            }

            return instResponse[instrumentID];
        }
    }
    public partial class AnalyticalDistanceEfficiency
    {
        public double[] getEfficiency(double distance)
        {
            double[] output = new double[this.EffCurve.GetLength(0)];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = EffCurve[i].EvaluatePoly(distance); 
            }
            return output;
        }
    }
    public partial class InterpolatedDistanceEfficiency
    {
        private double[] dist;
        private double[][] effs = null;

        public string Distances
        {
            get
            {
                return Utilities.FPList(dist);
            }
            set
            {
                dist = Utilities.listParser(value);
            }

        }
        private void ParseEffs()
        {
           
            effs = new double[dist.Length][];
            int i=0;
            foreach (ItemsChoiceType aType in ItemsElementName)
            {
                switch (aType)
                {
                    case ItemsChoiceType.Efficiencies:
                        // string of floating point values 
                        double[] values = Utilities.listParser((string)itemsField[i]);
                        for (int j = 0; j < values.Length; j++)
                        {
                            effs[j] = new double[1];
                            effs[j][0] = values[j];
                        }
                        return;
                    case ItemsChoiceType.Spectra:
                        effs[i] = ((ModelSpectra)itemsField[i]).getFPChannels();
                        break;
                    case ItemsChoiceType.SpectraRef:
                        effs[i] = ModelSpectra.GetSpectraByID((string)itemsField[i]).getFPChannels();
                        break;
                }
                i++;
            }
        }
        public double[] getEfficiency(double distance)
        {
            if (effs == null) ParseEffs();
            // search for the index of the distance
            int i = Array.BinarySearch<double>(dist, distance);

            if (i >= 0) //exact distance found
            {
                return effs[i];
            }
            // one's complement
            i = ~i;

            // check for case of distance less than the interpolated range
            if (i == 0) return effs[0];

            // check for case of distance greater than the interpolated range
            if (i == dist.Length) return effs[i - 1];

            // need to interpolate
            double[] eff1, eff2;

            eff1 = effs[i - 1];
            eff2 = effs[i];


            double[] finalDist = new double[eff1.Length];

            // loop over spectra length
            for (int channel = 0; channel < eff1.Length; channel++)
            {
                finalDist[channel] = eff1[channel] + (distance - dist[i - 1]) / (dist[i] - dist[i - 1]) * (eff2[channel] - eff1[channel]);
            }
            return finalDist;
        }

    }
   
   public  abstract  partial class DistanceEfficiency {
       public abstract double getEfficiency(double distance);
   }
    

    public partial class BackgroundSource : SourceDistribution
    {
        public override double getIntensity(Dictionary<String, Object> results, double lat, double lon, double alt, double height, DateTime asOf)
        {
            double value = Utilities.getTemporalFloat(asOf, this.ArealActivity);
            double error = 0.0;
            switch (this.Type)
            {
                case BackgroundSourceType.Constant:
                    error = RandomizationMagnitude * value;
                    break;
                case BackgroundSourceType.RandomizedGaussian:
                    {
                        double sigma = RandomizationMagnitude / 100 * value;
                        double sigs = Utilities.sigs();
                        error = sigs * sigma;
                    }
                    break;
                case BackgroundSourceType.RandomizedLinear:
                    error = (0.5 - Utilities.randomFloat()) * RandomizationMagnitude / 0.5 * value / 100;
                    break;
            }
            value += error;
            foreach(InstrumentEfficiency anEff in InstrumentResponse) {
                if(results.Keys.Contains(anEff.InstrumentRef)) {
                    // we care about this instrument
                    double[]    effValues = anEff.getEffAsOf(asOf, height);
                    Instrument anInst = XSimFieldLibraryImpl.GetInstrumentByID(anEff.InstrumentRef);
                    if (anInst is ScalarInst)
                    {
                        double eff = effValues[0];
                        double srcValue = value * eff;
                        double currValue = (Double)results[anEff.InstrumentRef];
                        currValue += srcValue;
                        results[anEff.InstrumentRef]= currValue;
                    }
                    else
                    {
                        // spectral instrument
                        long[] spectra = (long[])results[anEff.InstrumentRef];
                        for (int i = 0; i < spectra.Length; i++)
                        {
                            long srcValue = (long) Math.Round(value * effValues[i]);
                            spectra[i] += srcValue;
                        }
                        results[anEff.InstrumentRef]= spectra;
                    }
                }
            }
            return value;
        }

    }

    public partial class GridSource : SourceDistribution {
        int utmZone;
        bool zoneSet = false;
        DateTime[] valueTimes=null;
        private Boolean insideGrid(double lat, double lon, double alt)
        {
            return Bounds.pointIsInside(lat, lon, alt);
        }
        private void calcInstEffs(Dictionary<String, Object> results, double value, DateTime asOf, double height)
        {
            if (results == null) return;
            foreach (InstrumentEfficiency anEff in InstrumentResponse)
            {
                if (results.Keys.Contains(anEff.InstrumentRef))
                {
                    // we care about this instrument
                    double[] effValues = anEff.getEffAsOf(asOf, height);
                    Instrument anInst = XSimFieldLibraryImpl.GetInstrumentByID(anEff.InstrumentRef);
                    if (anInst is ScalarInst)
                    {
                        double eff = effValues[0];
                        double srcValue = value * eff;
                        double currValue = (Double)results[anEff.InstrumentRef];
                        currValue += srcValue;
                        results[anEff.InstrumentRef] = currValue;

                    }
                    else
                    {
                        // spectral instrument
                        long[] spectra = (long[])results[anEff.InstrumentRef];
                        for (int i = 0; i < spectra.Length; i++)
                        {
                            long srcValue = (long)Math.Round(value * effValues[i]);
                            spectra[i] += srcValue;
                        }
                        results[anEff.InstrumentRef] = spectra;
                    }
                }

            }

        }
        /**
         * Calculates the contribution to the base instruments of this source and adds it to results if not null.
         * Returns the source intensity 
         */
        public override double getIntensity(Dictionary<String, Object> results, double lat, double lon, double alt, double height, DateTime asOf)
        {
            srcDistance = alt;
            cachedEff = null;

            // check if we are in the cube
            if (!Bounds.pointIsInside(lat, lon, alt))
            {
                return 0;
            }

            // check if we are on a UTM grid
            int zone = Int32.Parse(this.uTMZoneField);
            if (zone != 0)
            {
                double north, east;
                if (!zoneSet)
                {
                    utmZone = Int32.Parse(this.UTMZone);
                    zoneSet = true;
                }
                
                // in a UTM grid, change our lat lon to north eastings
                LocConversion.LLtoUTM(23, lat, lon, utmZone, out north, out east);
                lat = north;
                lon = east;
            }
           
            int x, y;
            double dx, dy;
            
            if(lat < this.yValues[0]) return 0;
            if(lat > yValues.Last()) return 0;
            if(lon < xValues[0]) return 0;
            if(lon > xValues.Last()) return 0;
 
            x = Array.BinarySearch(xValues, lon);
            if (x >= 0)
            {
                dx = 0;
            }
            else
            {
                x = ~x;
                x--;
                dx = (lon - xValues[x]) / (xValues[x + 1] - xValues[x]);
            }
 
            y = Array.BinarySearch(yValues, lat);
            if (y >= 0)
            {
                dy = 0;
            }
            else
            {
                y = ~y;
                y--;
                dy = (lat - yValues[y]) / (yValues[y + 1] - yValues[y]);
            }

            GridSource betterOption;
        
            if (Distribution.GetLength(0) == 1)
            {
                // only a single timepoint so no temporal interpolation
                betterOption  = Distribution[0].getSubgrid(lat, lon, alt);
                double aValue;
                if (betterOption != null)
                {
                    aValue = betterOption.getIntensity(null, lat, lon, alt, height, asOf);
                }
                else
                {
                    aValue = Distribution[0].getScalarValue(x, y, dx, dy);
                }
                calcInstEffs(results, aValue, asOf, height);

                return aValue;
            }

            // discover the best GridValues
            
      
            
            GridValues      previous = Distribution[0];
            if (previous.TimePoint.CompareTo(asOf) > 0)
            {
                // point occurs before the first mesh timestamp. Assume the values are zero at ZeroTime.
                double fullInterval = (previous.Time - this.ZeroTime).TotalSeconds;
                double offsetInterval = (asOf - ZeroTime).TotalSeconds;

                double y2, aFloat;

                y2 = previous.getValueAt(lat, lon, alt, height, x, y, dx, dy, asOf);

                aFloat = y2 / fullInterval * offsetInterval;
                calcInstEffs(results, aFloat, asOf, height);
                return aFloat;

            }
            if (Distribution[Distribution.Length - 1].TimePoint.CompareTo(asOf) < 0)
            {
                double aValue; 
                // time point occurs after the last mesh timestamp.
                previous = Distribution[Distribution.Length - 1];
                aValue = previous.getValueAt(lat, lon, alt, height, x, y, dx, dy, asOf);
                calcInstEffs(results, aValue, asOf, height);
                return aValue;
            }

            double fraction;
            int index;
            if (valueTimes == null) valueTimes = Distribution.Select(e => e.Time).ToArray<DateTime>();

            Utilities.interpolateTimes(valueTimes, asOf, out fraction, out  index);
            previous = Distribution[index];
            GridValues next = Distribution[index + 1];
            double z1, z2, result;
            z1 = previous.getValueAt(lat, lon, alt, height, x, y, dx, dy, asOf);
            z2 = next.getValueAt(lat, lon, alt, height, x, y, dx, dy, asOf);
            result = z1 + (z2 - z1) * fraction;
            calcInstEffs(results, result, asOf, height);
            return result;

        }
    }
            
    public partial class GridValues
    {
        private double[][] fValues;

        internal GridSource getSubgrid(double lat, double lon, double alt)
        {
            if (this.SubGrid == null) return null;
            foreach (GridSource sub in SubGrid)
            {
                if (sub.Bounds.pointIsInside(lat, lon, alt)) return sub;
            }
            return null;

        }
        public double getValueAt(double lat, double lon, double alt, double height, int x, int y, double dx, double dy, DateTime asOf)
        {
            GridSource subGrid = getSubgrid(lat, lon, alt);
            if (subGrid != null) return subGrid.getIntensity(null, lat, lon, alt, height, asOf);
            return getScalarValue(x, y, dx, dy);

        }
        internal double getScalarValue(int x, int y, double dx, double dy) {



            double dVal;
            double dP1, dP2, dP3, dP4;

            if(dx ==0 && dy==0) {
                return fValues[y][x];
            }
            if (dy == 0)
            {
                // on one of the x value lines
                dP1 = fValues[y][x];
                dP2 = fValues[y][x+1];
                dVal = (1.0 - dx) * dP1 + dx * dP2;
            }
            else if (dx == 0)
            {
                dP1 = fValues[y][x];
                dP4 = fValues[y+1][x];
                dVal = (1.0 - dy) * dP1 + dy * dP4;
            }
            else
            {
                dP1 = fValues[y][x];
                dP2 = fValues[y][x+1];
                dP3 = fValues[y+1][x+1];
                dP4 = fValues[y+1][x];
                dVal = (1.0 - dx) * (1.0 - dy) * dP1 + dx * (1.0 - dy) * dP2 + (dx * dy) * dP3 + (1.0 - dx) * dy * dP4;
            }

            return dVal;
        }
    }

    public abstract partial class Location
    {
        public abstract LocationTriplet getLocationAsOf(double timeStepFraction);
    }
    public partial class FixedLocation : Location
    {
        public override LocationTriplet getLocationAsOf(double timeStepFraction)
        {
            return this.LocationPoint;
        }
    }

    public partial class HardwareRef : Location
    {
        public override LocationTriplet getLocationAsOf(double timeStepFraction)
        {
            throw new NotImplementedException("This library does not support live locations!");
        }
    }
    public partial class TimeDependentAnalyticalLocation : Location
    {
        public override LocationTriplet getLocationAsOf(double timeStepFraction)
        {
                            
            LocationTriplet aTrip = new LocationTriplet();
            // inside the array

            aTrip.Altitude = Altitude.EvaluatePoly(timeStepFraction);
            aTrip.Latitude = Latitude.EvaluatePoly(timeStepFraction); 
            aTrip.Longitude = Longitude.EvaluatePoly(timeStepFraction);

            return aTrip;
        }

    }

    public partial class PointSource : SourceDistribution
    {
        DateTime[] timeArray = null;

        public override double getIntensity(Dictionary<String, Object> results, double lat, double lon, double alt, double height, DateTime asOf)
        {
            cachedEff = null;

            if (timeArray == null) timeArray = Location.Select(e => e.Time).ToArray<DateTime>();

            int index;
            double fraction;
            LocationTriplet srcLocation;

            if(Utilities.interpolateTimes(timeArray, asOf, out fraction, out index)) {
                LocationTriplet l1, l2;
                double secOffset = (asOf - Location[index].Time).TotalSeconds;
                double secSpacing = (Location[index + 1].Time - Location[index].Time).TotalSeconds;
                double timeStepFraction = secOffset / secSpacing;
                if (Location[index].GetType() == typeof(TimeDependentAnalyticalLocation))
                {
                    // special case
                    srcLocation = Location[index].getLocationAsOf(timeStepFraction);
                }
                else
                {
                    // need to interpolate

                    l1 = Location[index].getLocationAsOf(0);
                    l2 = Location[index + 1].getLocationAsOf(0);

                    srcLocation = new LocationTriplet();
                    srcLocation.Altitude = l1.Altitude + (l2.Altitude - l1.Altitude) * timeStepFraction;
                    srcLocation.Latitude = l1.Latitude + (l2.Latitude - l1.Latitude) * timeStepFraction;
                    srcLocation.Longitude = l1.Longitude + (l2.Longitude - l2.Longitude) * timeStepFraction;
                }
            }
            else
            {
                srcLocation = Location[index].getLocationAsOf(0);
            }

            

            // calculate distance
            double distance = Utilities.distanceInMeters(lat, srcLocation.Latitude, lon, srcLocation.Longitude, alt, srcLocation.Altitude);
            srcDistance = distance;

            // calculate activity
            double activity = Utilities.getTemporalFloat(asOf, this.Activity);
            double detPhotons = activity / 4/ Math.PI/ distance / distance;

            // calculate efficency
            foreach (InstrumentEfficiency anEff in InstrumentResponse)
            {
                if (results.Keys.Contains(anEff.InstrumentRef))
                {
                    // we care about this instrument
                    double[] effValues = anEff.getEffAsOf(asOf, height);
                    Instrument anInst = XSimFieldLibraryImpl.GetInstrumentByID(anEff.InstrumentRef);
                    if (anInst is ScalarInst)
                    {
                        double eff = effValues[0];
                        double srcValue = detPhotons * eff;
                        double currValue = (Double)results[anEff.InstrumentRef];
                        currValue += srcValue;
                        results[anEff.InstrumentRef] = currValue;
                    }
                    else
                    {
                        // spectral instrument
                        long[] spectra = (long[])results[anEff.InstrumentRef];
                        for (int i = 0; i < spectra.Length; i++)
                        {
                            long srcValue = (long)Math.Round(detPhotons * effValues[i]);
                            spectra[i] += srcValue;
                        }
                        results[anEff.InstrumentRef] = spectra;
                    }
                }
            }
            return detPhotons;
        }


    }

    public partial class ScalarInst : InstrumentType
    {/*
        public double getScalarValue(RadSrcType[] sources, DateTime aTime)
        {
            double aValue = 0.0;
            
            foreach (ScalarSourceEfficiency srcEff in this.SourceFieldEfficiency)
            {
                double srcValue;
                if (sources.TryGetValue(srcEff.SourceRef, out srcValue))
                {
                    aValue += srcValue * Utilities.getTemporalFloat(aTime, srcEff.EffValue);

                }

            }
            return aValue;
        }*/
    }
    public partial class InstrumentType : Instrument
    {
        internal bool observing;
        public System.IO.Stream GetSkin()
        {
            EmbeddedFile ef = XSimFieldLibraryImpl.sCurrentLib.GetFileByID(this.GUIDisplay);
            System.IO.MemoryStream ms = null;

            ms = new System.IO.MemoryStream(ef.Data);

            return ms;
        }

        public string GetName()
        {
            String[] tags = VisibleName.Select(e => e.ietfTag).ToArray<String>();

            int index = Utilities.indexOfBestMatch(XSimFieldLibraryImpl.sCurrentLib.myIetf, tags);
            return VisibleName[index].Value;
        }

        public string GetSerialNumber()
        {
            return "";
        }

        public Guid GetGUID()
        {
            return new Guid("e30694a5-3c56-4b8b-a0e5-fb0db8824916");
        }

        public bool IsGeneric()
        {
            return true;
        }

        public void initialize()
        {
            observing = false;

        }
    }
    public interface ISourceValue
    {
        double getGroundActivity(double lat, double lon, double alt = 0.0);
    }
    public partial class ConicRegion : GeoRegion
    {

        public override bool pointIsInside(double lat, double lon, double alt = 0.0)
        {
            if (alt > AltitudeMaximum) return false;
            if (alt < AltitudeMinimum) return false;

            double dLat, dLon;
            dLat = lat - Axis.Latitude;
            dLon = lon - Axis.Longitude;

            double angularDist = Math.Sqrt(dLat * dLat + dLon * dLon);

            double maxAngle = Math.Acos(ApexAngleCos) * 180 / Math.PI;

            return (angularDist < maxAngle);

        }
    }
    public abstract partial class GeoRegion 
    {
        public abstract bool pointIsInside(double lat, double lon, double alt = 0.0);

    }
    public partial class CuboidRegion : GeoRegion
    {

        public override bool pointIsInside(double lat, double lon, double alt = 0.0)
        {
            if (lat < BottomSouthWestCorner.Latitude) return false;
            if (lat > TopNorthEastCorner.Latitude) return false;
            if (lon < BottomSouthWestCorner.Longitude) return false;
            if (lon > TopNorthEastCorner.Longitude) return false;
            if (alt < BottomSouthWestCorner.Altitude) return false;
            if (alt > TopNorthEastCorner.Altitude) return false;
            return true;
        }
    }
    public partial class PolyRegion : GeoRegion
    {

        public override bool pointIsInside(double lat, double lon, double alt = 0.0)
        {
            int i;
            double det;
            for (i = 1; i < this.Point.Length; i++)
            {
                det = ((Point[i].Longitude - Point[i - 1].Longitude) * (lat - Point[i - 1].Latitude) -
                        (Point[i].Latitude - Point[i - 1].Latitude) * (lon - Point[i - 1].Longitude));
                if (det < 0) return false;
            }
            // last segment
            det = ((Point[0].Longitude - Point[i - 1].Longitude) * (lat - Point[i - 1].Latitude) -
                    (Point[0].Latitude - Point[i - 1].Latitude) * (lon - Point[i - 1].Longitude));
            if (det < 0) return false;
            return true;
        }
    }
    public class Everywhere : GeoRegion
    {
        public override bool pointIsInside(double lat, double lon, double alt = 0.0)
        {
            return true;
        }

    }
    public partial class SphereRegion : GeoRegion
    {

        public override bool pointIsInside(double lat, double lon, double alt = 0.0)
        {
            double d = Utilities.distanceInMeters(lat, Center.Latitude, lon, Center.Longitude, alt, Center.Altitude);
            return (d < Radius);
        }
    }
    public partial class InstrumentLink : Instrument
    {
        private InstrumentType template;
        internal bool observing;

        public void initialize(InstrumentType[]  supportedTypes)
        {
            observing = false;
            // find our template
            foreach (InstrumentType inst in supportedTypes)
            {
                if (inst.id == this.InstrumentRef)
                {
                    template = inst;
                    return;
                }
            }
            template = null;
        }

        public System.IO.Stream GetSkin()
        {
            return template.GetSkin();
        }

        public string GetName()
        {
            return template.GetName();
        }

        public string GetSerialNumber()
        {
            return SerialNumber;
        }

        public Guid GetGUID()
        {
            return new Guid(GUIDLink);
        }

        public bool IsGeneric()
        {
            return false;
        }
    }
    public partial class PBKDF2ParameterType
    {
        public XmlElement serialize()
        {
            XmlElement retValue;

            XmlSerializer serializer = new XmlSerializer(this.GetType());
            MemoryStream ms = new MemoryStream();
            XmlTextWriter tw = new XmlTextWriter(ms, UTF8Encoding.UTF8);
            XmlDocument doc = new XmlDocument();

            serializer.Serialize(tw, this);
            ms.Seek(0, SeekOrigin.Begin);
            doc.Load(ms);
            retValue = doc.DocumentElement;

            return retValue;

        }
    }
}
