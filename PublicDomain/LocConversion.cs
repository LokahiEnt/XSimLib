#region Copyright Notice
/**
 * Original C++ code written by Chuck Gantz and released to the public domain
 * Adapted to C# by Eric Wagner
 */
#endregion


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gov.nnss.rsl.xsim
{
    /*
        Reference ellipsoids derived from Peter H. Dana's website- 
        http://www.utexas.edu/depts/grg/gcraft/notes/datum/elist.html
        Department of Geography, University of Texas at Austin
        Internet: pdana@mail.utexas.edu
        3/22/95

        Source
        Defense Mapping Agency. 1987b. DMA Technical Report: Supplement to Department of Defense World Geodetic System
        1984 Technical Report. Part I and II. Washington, DC: Defense Mapping Agency
    */

  

    public class Ellipsoid
    {
        public int id;
        public string name;
        public double EquatorialRadius, eccentricitySquared;

        public Ellipsoid(int id, string name, double r, double ecc)
        {
            this.id = id;
            this.name = name;
            EquatorialRadius = r;
            eccentricitySquared = ecc;
        }


    }
    public class LocConversion
    {
        public const double FOURTHPI = Math.PI / 4;
        public const double deg2rad = Math.PI / 180;
        public const double rad2deg = 180.0 / Math.PI;

        public static Ellipsoid[]   standards = new Ellipsoid[] {
                new Ellipsoid( -1, "Placeholder", 0, 0),//placeholder only, To allow array indices to match id numbers
	            new Ellipsoid( 1, "Airy", 6377563, 0.00667054),
	            new Ellipsoid( 2, "Australian National", 6378160, 0.006694542),
	            new Ellipsoid( 3, "Bessel 1841", 6377397, 0.006674372),
	            new Ellipsoid( 4, "Bessel 1841 (Nambia) ", 6377484, 0.006674372),
	            new Ellipsoid( 5, "Clarke 1866", 6378206, 0.006768658),
	            new Ellipsoid( 6, "Clarke 1880", 6378249, 0.006803511),
	            new Ellipsoid( 7, "Everest", 6377276, 0.006637847),
	            new Ellipsoid( 8, "Fischer 1960 (Mercury) ", 6378166, 0.006693422),
	            new Ellipsoid( 9, "Fischer 1968", 6378150, 0.006693422),
	            new Ellipsoid( 10, "GRS 1967", 6378160, 0.006694605),
	            new Ellipsoid( 11, "GRS 1980", 6378137, 0.00669438),
	            new Ellipsoid( 12, "Helmert 1906", 6378200, 0.006693422),
	            new Ellipsoid( 13, "Hough", 6378270, 0.00672267),
	            new Ellipsoid( 14, "International", 6378388, 0.00672267),
	            new Ellipsoid( 15, "Krassovsky", 6378245, 0.006693422),
	            new Ellipsoid( 16, "Modified Airy", 6377340, 0.00667054),
	            new Ellipsoid( 17, "Modified Everest", 6377304, 0.006637847),
	            new Ellipsoid( 18, "Modified Fischer 1960", 6378155, 0.006693422),
	            new Ellipsoid( 19, "South American 1969", 6378160, 0.006694542),
	            new Ellipsoid( 20, "WGS 60", 6378165, 0.006693422),
	            new Ellipsoid( 21, "WGS 66", 6378145, 0.006694542),
	            new Ellipsoid( 22, "WGS-72", 6378135, 0.006694318),
	            new Ellipsoid( 23, "WGS-84", 6378137, 0.00669438)
        };


        public static int	GetZoneNumber(double Lat, double Lon){
        	int	ZoneNumber = (int)((Lon + 180)/6) + 1;
  
        	if( Lat >= 56.0 && Lat < 64.0 && Lon >= 3.0 && Lon < 12.0 )
		        ZoneNumber = 32;

            // Special zones for Svalbard
    	    if( Lat >= 72.0 && Lat < 84.0 ) 
	        {
	            if(      Lon >= 0.0  && Lon <  9.0 ) ZoneNumber = 31;
	            else if( Lon >= 9.0  && Lon < 21.0 ) ZoneNumber = 33;
	            else if( Lon >= 21.0 && Lon < 33.0 ) ZoneNumber = 35;
	            else if( Lon >= 33.0 && Lon < 42.0 ) ZoneNumber = 37;
	        }

        	return ZoneNumber;
        }

        public static void LLtoUTM(int ReferenceEllipsoid, double Lat, double Long, int UTMZone, 
			 out double UTMNorthing, out double UTMEasting)
        {
        //converts lat/long to UTM coords.  Equations from USGS Bulletin 1532 
        //East Longitudes are positive, West longitudes are negative. 
        //North latitudes are positive, South latitudes are negative
        //Lat and Long are in decimal degrees
	        //Written by Chuck Gantz- chuck.gantz@globalstar.com

	        double a = standards[ReferenceEllipsoid].EquatorialRadius;
	        double eccSquared = standards[ReferenceEllipsoid].eccentricitySquared;
	        double k0 = 0.9996;

	        double LongOrigin;
	        double eccPrimeSquared;
	        double N, T, C, A, M;
	
        //Make sure the longitude is between -180.00 .. 179.9
	        double LongTemp = (Long+180)-(int)((Long+180)/360)*360-180; // -180.00 .. 179.9;

	        double LatRad = Lat*deg2rad;
	        double LongRad = LongTemp*deg2rad;
	        double LongOriginRad;
	        int    ZoneNumber;

            ZoneNumber = UTMZone; // GetZoneNumber(Lat, LongTemp);
		

	        LongOrigin = (ZoneNumber - 1)*6 - 180 + 3;  //+3 puts origin in middle of zone
	        LongOriginRad = LongOrigin * deg2rad;

	        //compute the UTM Zone from the latitude and longitude
        //	sprintf(UTMZone, "%d%c", ZoneNumber, UTMLetterDesignator(Lat));

	        eccPrimeSquared = (eccSquared)/(1-eccSquared);

	        N = a/Math.Sqrt(1-eccSquared*Math.Sin(LatRad)*Math.Sin(LatRad));
	        T = Math.Tan(LatRad)*Math.Tan(LatRad);
	        C = eccPrimeSquared*Math.Cos(LatRad)*Math.Cos(LatRad);
	        A = Math.Cos(LatRad)*(LongRad-LongOriginRad);

	        M = a*((1	- eccSquared/4		- 3*eccSquared*eccSquared/64	- 5*eccSquared*eccSquared*eccSquared/256)*LatRad 
				        - (3*eccSquared/8	+ 3*eccSquared*eccSquared/32	+ 45*eccSquared*eccSquared*eccSquared/1024)*Math.Sin(2*LatRad)
									        + (15*eccSquared*eccSquared/256 + 45*eccSquared*eccSquared*eccSquared/1024)*Math.Sin(4*LatRad) 
									        - (35*eccSquared*eccSquared*eccSquared/3072)*Math.Sin(6*LatRad));
	
	        UTMEasting = (double)(k0*N*(A+(1-T+C)*A*A*A/6
					        + (5-18*T+T*T+72*C-58*eccPrimeSquared)*A*A*A*A*A/120)
					        + 500000.0);

	        UTMNorthing = (double)(k0*(M+N*Math.Tan(LatRad)*(A*A/2+(5-T+9*C+4*C*C)*A*A*A*A/24
				         + (61-58*T+T*T+600*C-330*eccPrimeSquared)*A*A*A*A*A*A/720)));
	        if(Lat < 0)
		        UTMNorthing += 10000000.0; //10000000 meter offset for southern hemisphere
        }

    

        public static void UTMtoLL(int ReferenceEllipsoid,  double UTMNorthing,  double UTMEasting, bool NorthHem,
			      int ZoneNumber, out double Lat,  out double Long )
        {
            //converts UTM coords to lat/long.  Equations from USGS Bulletin 1532 
            //East Longitudes are positive, West longitudes are negative. 
            //North latitudes are positive, South latitudes are negative
            //Lat and Long are in decimal degrees. 
	        //Written by Chuck Gantz- chuck.gantz@globalstar.com

	        double k0 = 0.9996;
	        double a = standards[ReferenceEllipsoid].EquatorialRadius;
	        double eccSquared = standards[ReferenceEllipsoid].eccentricitySquared;
	        double eccPrimeSquared;
	        double e1 = (1-Math.Sqrt(1-eccSquared))/(1+Math.Sqrt(1-eccSquared));
	        double N1, T1, C1, R1, D, M;
	        double LongOrigin;
	        double mu, phi1, phi1Rad;
	        double x, y;

	        x = UTMEasting - 500000.0; //remove 500,000 meter offset for longitude
	        y = UTMNorthing;


	        if(!NorthHem)
	        {
		        y -= 10000000.0;//remove 10,000,000 meter offset used for southern hemisphere
	        }

	        LongOrigin = (ZoneNumber - 1)*6 - 180 + 3;  //+3 puts origin in middle of zone

	        eccPrimeSquared = (eccSquared)/(1-eccSquared);

	        M = y / k0;
	        mu = M/(a*(1-eccSquared/4-3*eccSquared*eccSquared/64-5*eccSquared*eccSquared*eccSquared/256));

	        phi1Rad = mu	+ (3*e1/2-27*e1*e1*e1/32)*Math.Sin(2*mu) 
				        + (21*e1*e1/16-55*e1*e1*e1*e1/32)*Math.Sin(4*mu)
				        +(151*e1*e1*e1/96)*Math.Sin(6*mu);
	        phi1 = phi1Rad*rad2deg;

	        N1 = a/Math.Sqrt(1-eccSquared*Math.Sin(phi1Rad)*Math.Sin(phi1Rad));
	        T1 = Math.Tan(phi1Rad)*Math.Tan(phi1Rad);
	        C1 = eccPrimeSquared*Math.Cos(phi1Rad)*Math.Cos(phi1Rad);
	        R1 = a*(1-eccSquared)/Math.Pow(1-eccSquared*Math.Sin(phi1Rad)*Math.Sin(phi1Rad), 1.5);
	        D = x/(N1*k0);

	        Lat = phi1Rad - (N1*Math.Tan(phi1Rad)/R1)*(D*D/2-(5+3*T1+10*C1-4*C1*C1-9*eccPrimeSquared)*D*D*D*D/24
					        +(61+90*T1+298*C1+45*T1*T1-252*eccPrimeSquared-3*C1*C1)*D*D*D*D*D*D/720);
	        Lat = Lat * rad2deg;

	        Long = (D-(1+2*T1+C1)*D*D*D/6+(5-2*C1+28*T1-3*C1*C1+8*eccPrimeSquared+24*T1*T1)
					        *D*D*D*D*D/120)/Math.Cos(phi1Rad);
	        Long = LongOrigin + Long * rad2deg;
    }

}

}
