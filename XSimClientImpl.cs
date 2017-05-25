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
#if !NO_CRYPTO
using System.Security.Cryptography;
#endif
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using XSim = gov.nnss.rsl.xsim;
using gov.nnss.rsl.xsim.xsd;
using System.Collections;


namespace gov.nnss.rsl.xsim.impl
{

    class InjectProcessor
    {
        
        SortedList<Int32, List<InjectType>> timeIndexedInjects;
        DateTime startTime;
        Int32 lastTime;

        public InjectProcessor(DateTime scenarioStartTime)
        {
            startTime = scenarioStartTime;
            timeIndexedInjects = new SortedList<Int32, List<InjectType>>();
            lastTime = 0;
        }
        public void AddInjects(InjectType[] anInjectArray)
        {
            if (anInjectArray == null) return;
            foreach (InjectType anInject in anInjectArray)
            {
                AddInject(anInject);
            }
        }
        public void AddInject(InjectType anInject)
        {
            if (anInject == null) return;
            Int32 timeSpan;

            timeSpan = (Int32)(anInject.Time - startTime).TotalSeconds;

            if (timeSpan < lastTime)
            {
                // Inject added before the current time
                // ignore it unless it has the late injection flag set
                if (!anInject.LateInjection) return;
            }

            List<InjectType> aList;
            if (timeIndexedInjects.TryGetValue(timeSpan, out aList))
            {
                aList.Add(anInject);
            }
            else
            {
                aList = new List<InjectType>();
                aList.Add(anInject);
                timeIndexedInjects.Add(timeSpan, aList);
            }
        }
        public void RetrieveInjects(double lat, double lon, double alt, DateTime aTime)
        {
            Int32 timeSpan = (Int32)(aTime - startTime).TotalSeconds;
            lastTime = timeSpan;
            List<InjectType> validList = new List<InjectType>();
            int numToRemove = 0;
            foreach (KeyValuePair<Int32, List<InjectType>> aPair in timeIndexedInjects)
            {
                if (aPair.Key < timeSpan)
                {
                    // process the list of injects before
                    foreach (InjectType anInject in aPair.Value)
                    {
                        if (anInject.Location.pointIsInside(lat, lon, alt))
                        {
                            validList.Add(anInject);
                        }
                        

                    }
                    numToRemove++;
                }
            }
            while (numToRemove != 0)
            {
                timeIndexedInjects.RemoveAt(0);
                numToRemove--;
            }

            // check if we have overlapping priorities
            Int64 maxPriority = -1;
            foreach (InjectType anInject in validList)
            {
                Int64   aPri = Int64.Parse(anInject.OverrideLevel);
                if (maxPriority < aPri)
                {
                    maxPriority = aPri;
                }
            }
            // now send all the injects at the maxPriority
            foreach(InjectType anInject in validList) {
                Int64 aPri = Int64.Parse(anInject.OverrideLevel);
                if(aPri == maxPriority) {
                    String[]      availableLang = anInject.Title.Select(e => e.ietfTag).ToArray<String>();

                    int i = Utilities.indexOfBestMatch(XSimFieldLibraryImpl.sCurrentLib.myIetf, availableLang);
                    String title = anInject.Title[i].Value;
                    availableLang = anInject.File.Select(e => e.ietfTag).ToArray<String>();

                    i = Utilities.indexOfBestMatch(XSimFieldLibraryImpl.sCurrentLib.myIetf, availableLang);
                    String  aFileTag = anInject.File[i].Value;
                    EmbeddedFile aFile = XSimFieldLibraryImpl.sCurrentLib.GetFileByID(aFileTag);
                    MemoryStream        aStream = new MemoryStream(aFile.Data);
                    XSimFieldLibraryImpl.sCurrentLib.myClient.InjectNotification(title, anInject.AutoplayMultimedia, 
                        aFile.FileName, aFile.MimeType, aStream);
                }
            }


        }
    }
    class WeatherProcessor
    {
        SortedList<Int32, List<WeatherEvents>> weatherStarts;
        SortedList<Int32, List<WeatherEvents>> weatherEnds;
        WeatherEvents currentWeather=null;
        DateTime startTime;
        Int32 currentTime;

        public WeatherProcessor(DateTime scenarioStartTime, DateTime scenarioStopTime)
        {
            startTime = scenarioStartTime;
            weatherStarts = new SortedList<int, List<WeatherEvents>>();
            weatherEnds = new SortedList<int, List<WeatherEvents>>();
            WeatherEvents clearSky = new WeatherEvents();
            clearSky.Region = new Everywhere();
            clearSky.PrecipitationRate = 0;
            WeatherEventsType descrip = new WeatherEventsType();
            descrip.ietfTag = "en-us";
            descrip.Value = "Clear Sky";
            clearSky.Type = new WeatherEventsType[] { descrip };
            clearSky.Start = new MarkedTime();
            clearSky.Start.Time = scenarioStartTime;
            clearSky.End = new MarkedTime();
            clearSky.End.Time = scenarioStopTime;
            AddWeather(clearSky);
        }
        public void AddWeather(WeatherEvents[] eventList)
        {
            if (eventList == null) return;
            foreach (WeatherEvents anEvent in eventList)
            {
                AddWeather(anEvent);
            }
        }
        public void AddWeather(WeatherEvents anEvent)
        {
            Int32 startTimeSpan, stopTimeSpan;

            if (anEvent == null) return;
            startTimeSpan = (Int32)(anEvent.Start.Time - startTime).TotalSeconds;
            stopTimeSpan = (Int32)(anEvent.End.Time - startTime).TotalSeconds;
            if (stopTimeSpan < currentTime)
            {
                // adding weather event that was in the past
                return;
            }

            List<WeatherEvents> aList;
            if (weatherStarts.TryGetValue(startTimeSpan, out aList))
            {
                aList.Add(anEvent);
            }
            else
            {
                aList = new List<WeatherEvents>();
                aList.Add(anEvent);
                weatherStarts.Add(startTimeSpan, aList);
            }

            if (weatherEnds.TryGetValue(stopTimeSpan, out aList))
            {
                aList.Add(anEvent);
            }
            else
            {
                aList = new List<WeatherEvents>();
                aList.Add(anEvent);
                weatherEnds.Add(stopTimeSpan, aList);
            }

        }
        public double GetCurrentWeather(double lat, double lon, double alt, DateTime aTime)
        {
            Int32 timeSpan = (Int32)(aTime - startTime).TotalSeconds;
            currentTime = timeSpan;

            List<WeatherEvents> currentEvents = new List<WeatherEvents>();
            List<Int32> listToRemove = new List<Int32>();

            foreach (KeyValuePair<Int32,List<WeatherEvents>> wEvent in weatherStarts)
            {
                if (wEvent.Key > timeSpan)
                {
                    // the weather hasn't occurred yet
                    continue;
                }
                List<WeatherEvents> toRemove = new List<WeatherEvents>();
                // so weather event has started, check if ended
                foreach (WeatherEvents anEvent in wEvent.Value)
                {
                    if ((anEvent.End.Time - aTime).TotalSeconds > 0)
                    {
                        // still have time left
                        if (anEvent.Region.pointIsInside(lat, lon, alt))
                        {
                            // we are in the zone
                            currentEvents.Add(anEvent);
                        }
                    }
                    else
                    {
                        //time has passed
                        toRemove.Add(anEvent);
                    }
                }
                // now that the iterator is clear clean out the old ones
                foreach (WeatherEvents anEvent in toRemove)
                {
                    wEvent.Value.Remove(anEvent);
                    
                }
                if (wEvent.Value.Count == 0)
                    listToRemove.Add(wEvent.Key);
                

            }
            // remove llists
            foreach (Int32 key in listToRemove)
            {
                weatherStarts.Remove(key);
            }

            // determine the weather with the highest priority
            Int32 topPriority = -2;
            WeatherEvents topOne=null;
            foreach (WeatherEvents anEvent in currentEvents)
            {
                Int32 priority;
                Int32.TryParse(anEvent.OverrideLevel, out priority);

                if (priority > topPriority)
                {
                    topPriority = priority;
                    topOne = anEvent;
                }
            }
            // send the client the current weather
            if (! topOne.Equals(currentWeather))
            {
                currentWeather = topOne;
                String[]      availableLang = topOne.Type.Select(e => e.ietfTag).ToArray<String>();

                int descrip = Utilities.indexOfBestMatch(XSimFieldLibraryImpl.sCurrentLib.myIetf, availableLang);

                XSimFieldLibraryImpl.sCurrentLib.myClient.WeatherUpdate(lat, lon, alt, currentWeather.Type[descrip].Value);
            }
            return currentWeather.PrecipitationRate;

        }

    }
    public class XSimFieldLibraryImpl : XSimFieldLibrary
    {
        internal static XSimFieldLibraryImpl sCurrentLib;
        internal String myIetf;
        protected SimFile myCurrentFile;
        internal XSimClient myClient;
        bool fileDecrypted;
        FieldDataContents myFieldData;
        List<Instrument> interestedInst;
        InjectProcessor injects;
        WeatherProcessor weather;

        #region Library Interface
        /**
         * Call to load the source xml file and initialize the library
         * 
         */
        public Error LoadScenario(System.IO.Stream baseFile, System.String ietfLanguage, XSimClient callbacks)
        {
            try
            {
                myIetf = ietfLanguage;
                sCurrentLib = this;
                myClient = callbacks;
                fileDecrypted = false;
                myFieldData = null;


                XmlSerializer s = new XmlSerializer(typeof(SimFile), new Type[] { typeof(PBKDF2ParameterType) });

                SimFile myBase = (SimFile)s.Deserialize(baseFile);
                myCurrentFile = myBase;
                baseFile.Close();
                interestedInst = new List<Instrument>();
                injects = new InjectProcessor(myBase.BaseFile.StartTime.Time);
                weather = new WeatherProcessor(myBase.BaseFile.StartTime.Time, myBase.BaseFile.StopTime.Time);
                if (myBase.BaseFile.SplashScreen != null)
                {
                    String[] availableLang = myBase.BaseFile.SplashScreen.Select(e => e.ietfTag).ToArray<String>();
                    int index = Utilities.indexOfBestMatch(myIetf, availableLang);
                    EmbeddedFile  splashFile = this.GetFileByID(myBase.BaseFile.SplashScreen[index].SplashImage);
                    MemoryStream    aStream = new MemoryStream(splashFile.Data);
                    callbacks.InjectNotification("Splash Screen", true, splashFile.FileName, splashFile.MimeType, aStream);
                }
#if NO_CRYPTO
                if (myBase.BaseFile.FileEncryption) return Error.encryptionNotSupported;
#endif
            }
            catch (Exception exp)
            {
                HandleError(Error.unexpectedException, "An unexpected exception was thrown!", exp);
            }

            return Error.noErr;

        }
         
        public Error AddSupplementalFile(System.IO.Stream supplementalFile)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception exp)
            {
                HandleError(Error.unexpectedException, "An unexpected exception was thrown!", exp);
            }
            return Error.noErr;

        }

        public string[] GetUserNames()
        {
            String[]   list=null;
            try
            {
                list = myCurrentFile.BaseFile.Authorization.Select(name => name.UserName).ToArray<String>();
            }
            catch (Exception exp)
            {
                HandleError(Error.unexpectedException, "An unexpected exception was thrown!", exp);
            }
            return list;
        }

        public int GetVersion()
        {
            return 5;
        }
        public Error SetCurrentUser(string aUser)
        {
            int i=0;
            Error err = Error.noErr;

#if NO_CRYPTO
            // probably should still validate the user exists
            myFieldData = (FieldDataContents)myCurrentFile.BaseFile.FieldData.Item;
            injects.AddInjects(myFieldData.Inject);
            weather.AddWeather(myFieldData.Weather);
            fileDecrypted = true;
            processFieldData();
            return err;
#else

            try
            {
                if (fileDecrypted)
                {
                    return myClient.ErrorHandler(Error.userAlreadySet, "A user has already been set.", "");
                }

                // retrieve the list of avaialable users
                String[] list = GetUserNames();
                Byte[] fieldKey;
                foreach (String knownName in list)
                {
                    // locate the desired user
                    if (knownName.Equals(aUser))
                    {
                        // load the authorization and authentication objects for the selected user
                        // since any authorization includes the Field privledge we just want to perform
                        // the authentication.
                        SimFileCoreAuthorization anAuth = myCurrentFile.BaseFile.Authorization[i];
                        Authentication authEnforcement = anAuth.Auth;


                        if (authEnforcement.GetType() == typeof(IndividualCert))
                        {
                            // field data key is encrypted to the user's private key

                            IndividualCert publicCert = (IndividualCert)authEnforcement;

                            // request the host application to decrypt it
                            fieldKey = myClient.DecryptKeyRequest(publicCert.CertName.X509IssuerName, publicCert.CertName.X509SerialNumber,
                                (byte[])publicCert.FieldKey.CipherData.Item);

                        }
                        else if (authEnforcement.GetType() == typeof(PasswordAuth))
                        {
                            // field data key is encrypted by a password derived key
                            PasswordAuth thisAuth = (PasswordAuth)authEnforcement;

                            // request the password from the host application
                            String password = myClient.PasswordRequest(aUser);

                            // load the password derivation parameters
                            PBKDF2ParameterType pkParams = thisAuth.PasswordKey.KeyDerivationMethod.PBKDF2Parameter;

                            Byte[] saltBytes = (Byte[])pkParams.Salt.Item;
                            Int32 iterationCount = Int32.Parse(pkParams.IterationCount);
                            int keyLength = Int16.Parse(pkParams.KeyLength);

                            // create the .NET password derived key object
                            Rfc2898DeriveBytes deriver = new System.Security.Cryptography.Rfc2898DeriveBytes(password, saltBytes, iterationCount);
                            Byte[] keyBytes = deriver.GetBytes(keyLength);

                            // now to decrypt the field data key
                            String method = thisAuth.FieldKey.EncryptionMethod.Algorithm;
                            if (method.Equals("AESWrap"))
                            {
                                // Using custom code since for some strange reason .NET doesn't have AESWrap implemented
                                try
                                {
                                    fieldKey = RFC3394.KeyWrapAlgorithm.UnwrapKey(keyBytes, (Byte[])thisAuth.FieldKey.CipherData.Item);
                                }
                                catch (CryptographicException crypt)
                                {
                                    err = Error.badPassword;
                                    HandleError(err, crypt.Message + "\nInvalid password submitted for: ", aUser);
                                    fieldKey = null;
                                }
                            }
                            else
                            {
                                SymmetricAlgorithm symAlg = (SymmetricAlgorithm)CryptoConfig.CreateFromName(method);
                                symAlg.Key = keyBytes;
                                fieldKey = System.Security.Cryptography.Xml.EncryptedXml.DecryptKey((Byte[])thisAuth.FieldKey.CipherData.Item, symAlg);
                            }
                        }
                        else if (authEnforcement.GetType() == typeof(NoAuth))
                        {
                            // The field data key is just stored in the clear
                            NoAuth noAuthDetails = (NoAuth)authEnforcement;
                            fieldKey = noAuthDetails.FieldKey;

                        }
                        else if (authEnforcement.GetType() == typeof(PasswordHash))
                        {
                            // This is utilized when the field data is not encrypted
                            // Just verify if the password is valid
                            String password = myClient.PasswordRequest(aUser);
                            PasswordHash hashAuth = (PasswordHash)authEnforcement;
                            HashAlgorithm hasher = HashAlgorithm.Create(hashAuth.Algorithm);
                            string saltedPassword = hashAuth.PasswordSalt + password;
                            byte[] calculatedHash = hasher.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
                            if (calculatedHash != hashAuth.Hash)
                            {
                                err = Error.badPassword;
                                HandleError(Error.badPassword, "Invalid password submitted for: ", aUser);
                                // NOTE: the host app can bypass the bad password message and still access the file if
                                // it suppresses the badPassword error.
                            }

                            myFieldData = (FieldDataContents)myCurrentFile.BaseFile.FieldData.Item;
                            injects.AddInjects(myFieldData.Inject);
                            weather.AddWeather(myFieldData.Weather);
                            fileDecrypted = true;
                            processFieldData();
                            return Error.noErr;
                        }
                        else
                        {
                            err = Error.unimplemented;
                            HandleError(Error.unimplemented, "Unknown authentication type encountered", authEnforcement.GetType().ToString());
                            return err;
                        }
                        if (myCurrentFile.BaseFile.FieldData.Item is FieldDataContents)
                        {
                            // Field data is already decrypted
                            myFieldData = (FieldDataContents)myCurrentFile.BaseFile.FieldData.Item;
                            fileDecrypted = true;
                            injects.AddInjects(myFieldData.Inject);
                            weather.AddWeather(myFieldData.Weather);
                        }

                        // The field data is in an encrypted format. Now that the key is available attempt to decrypt, decompress, and parse
                        if (fileDecrypted == false)
                        {
                            Byte[] rawData = (Byte[])myCurrentFile.BaseFile.FieldData.Item;
                            Byte[] iv = new byte[16];

                            // The first 16 bytes of the CipherText is the Initial Vector
                            Array.Copy(rawData, iv, 16);

                            // Utilize the .NET standard AES algorithm
                            Aes decrypter = Aes.Create();
                            decrypter.BlockSize = 128;
                            decrypter.Key = fieldKey;
                            decrypter.Mode = CipherMode.CBC;
                            decrypter.Padding = PaddingMode.PKCS7;
                            decrypter.IV = iv;

                            ICryptoTransform decryptor = decrypter.CreateDecryptor();
                            MemoryStream cipherText = new MemoryStream(rawData);
                            // Skip the IV
                            cipherText.Seek(16, SeekOrigin.Begin);
                            CryptoStream cryptoProcessor = new CryptoStream(cipherText, decryptor, CryptoStreamMode.Read);


                            Byte[] recordedCkSum = new Byte[4];
                            Byte[] calculatedCkSum;

                            using (ZLibStream unzipper = new ZLibStream(cryptoProcessor, System.IO.Compression.CompressionMode.Decompress, true))
                            {

                                XmlSerializer fieldSerializer = new XmlSerializer(typeof(FieldDataContents), "http://www.nnss.gov/rsl/sim");
                                myFieldData = (FieldDataContents)fieldSerializer.Deserialize(unzipper);
                                injects.AddInjects(myFieldData.Inject);
                                weather.AddWeather(myFieldData.Weather);
                                fileDecrypted = true;
                                calculatedCkSum = unzipper.GetChecksum();
                            }

                            // The zlib checksum is currently ignored since either .NET is consuming it internally or its not
                            // being properly written out.

                            int cksmSize = cryptoProcessor.Read(recordedCkSum, 0, 4);
                        }
                        processFieldData();
                        return err;
                    }
                    i++;
                }
                err = Error.noSuchUser;
                HandleError(Error.noSuchUser, "The specified user was not found. User = ", aUser);
                return err;
            }
            catch (Exception exp)
            {
                HandleError(Error.unexpectedException, "An unexpected exception occurred!", exp);
            }
            return err;
#endif

        }
        public IDictionary<Instrument, Object> HeartBeat(double latitude, double longitude, double altitude, double height, DateTime gpsTime, bool generateDictionary)
        {
            SortedList<Instrument, Object> resultList = null;
            if (generateDictionary)
            {
                resultList = new SortedList<Instrument, object>();
            }

            try
            {
                if (gpsTime.CompareTo(myCurrentFile.BaseFile.StartTime.Time) < 0)
                {
                    myClient.ErrorHandler(Error.earlyTime, "Heartbeat called with a time earlier than the start time for the scenario. The start time is: ",
                        myCurrentFile.BaseFile.StartTime.Value.ToString());
                    return null;
                }

                if (gpsTime.CompareTo(myCurrentFile.BaseFile.StopTime.Time) > 0)
                {
                    myClient.ErrorHandler(Error.lateTime, "Heartbeat called with a time later than the stop time for the scenario. The stop time is: ",
                        myCurrentFile.BaseFile.StopTime.Value.ToString());
                    return null;
                }

                Dictionary<String, object> sourceValues = null;
                double cmPerSecond  = weather.GetCurrentWeather(latitude, longitude, altitude, gpsTime);
                // loop over instruments
                foreach (Instrument requestedInst in interestedInst)
                {
                    double failFactor = 1.0;
                    // Retrieve the base generic instrument
                    Boolean unique = !requestedInst.IsGeneric();
                    InstrumentType instTemplate;
                    if (unique)
                    {
                        instTemplate = GetInstrumentByID(((InstrumentLink)requestedInst).InstrumentRef);
                        // check if the instrument has a unique failure rate
                        TimeDependentFloat[] failureRate = ((InstrumentLink)requestedInst).PerformanceEff;
                        if (failureRate != null && failureRate.Length > 0)
                        {
                            failFactor = Utilities.getTemporalFloat(gpsTime, failureRate);
                        } 
                    }
                    else
                    {
                        instTemplate = (InstrumentType)requestedInst;
                    }

                    // Calculate all the source terms as of this moment and location
                    if (sourceValues == null)
                        sourceValues = CalculateReadings(latitude, longitude, altitude, height, gpsTime);


                    if (instTemplate is ScalarInst)
                    {
                        ScalarInst inst = (ScalarInst)instTemplate;

                        // value is the instrument measurement
                        double value = 0.0;
                        // loop over the sources
                        value = (double)sourceValues[inst.id];



                        // check if we have a failing instrument
                        value *= failFactor;

                        value = noiseValue(value, inst.DeadTime, inst.GaussianErrorSigma, inst.PercentError, inst.PercentBias, inst.MinValue, inst.MaxValue);

                        // check of autoscale of units
                        string output;
                        String[] availableLang = inst.Units.Select(e => e.ietfTag).ToArray<String>();
                        int match = Utilities.indexOfBestMatch(XSimFieldLibraryImpl.sCurrentLib.myIetf, availableLang);
                        if (inst.AutoScale)
                        {
                            value = Utilities.MetricNormalization(value, inst.Units[match].Value, out output);
                        }
                        else
                        {
                            output = inst.Units[match].Value;
                        }
                        // Notify the host application of the measurement result
                        myClient.ScalarMeasurement(inst, latitude, longitude, altitude, height, gpsTime, (float)value, output);
                        if(resultList != null) resultList.Add(inst, value);
                    }
                    else
                    {
                        // TODO write spectral response function
                         
                        SpectralInst    inst = (SpectralInst)instTemplate;
                        long[] spectra = (long[])sourceValues[inst.id];
                        long totalCounts = 0;
                                                        
                        // check if we have a failing instrument
                        for (int i = 0; i < spectra.Length; i++)
                        {
                            spectra[i] = (long)(failFactor*spectra[i]);
                            totalCounts += spectra[i];
                        }

                                                    // check for dead time
                        if (inst.DeadTime != null)
                        {
                            double deadTime = inst.DeadTime.EvaluatePoly(totalCounts);

                            for (int i = 0; i < spectra.Length; i++)
                            {
                                spectra[i] = (long)(deadTime * spectra[i]);
                                totalCounts += spectra[i];
                            }

                        }
                        Double maxCnts = 0;
                        Double.TryParse(inst.MaxCounts, out maxCnts);
                        // add noise
                        for (int i = 0; i < spectra.Length; i++)
                        {
                            spectra[i] = (long)noiseValue(spectra[i], null, inst.GaussianErrorSigma, inst.PercentError, inst.PercentBias, 0.0, maxCnts);
                        }

                        if(resultList != null) resultList.Add(inst, spectra);

                    }


                   
                }

                // Check for exercise injects
                injects.RetrieveInjects(latitude, longitude, altitude, gpsTime);
                
            }
            catch (Exception exp)
            {
                HandleError(Error.unexpectedException, "An unexpected exception occurred!", exp);
            }

            return resultList;
        }
        public bool EncryptedFilesSupported()
        {
#if NO_CRYPTO
            return false;
#else
            return true;
#endif
        }
        public Error RegisterInstrumentInterest(Instrument anInst, bool interested)
        {
            try
            {
                //FIXME provide feedback for doubly added items
                if (interested)
                {
                    if(!interestedInst.Contains(anInst))
                       interestedInst.Add(anInst);
                }
                else
                {
                    interestedInst.Remove(anInst);
                }
                if (anInst.IsGeneric())
                {
                    ((InstrumentType)anInst).observing = interested;
                }
                else
                {
                    ((InstrumentLink)anInst).observing = interested;
                }
            }
            catch (Exception exp)
            {
                HandleError(Error.unexpectedException, "An unexpected exception occurred!", exp);
            }

            return Error.noErr;
        }

        public Instrument[] GetGenericInstruments()
        {
            try
            {
                return myFieldData.InstrumentType;
            }
            catch (Exception exp)
            {
                HandleError(Error.unexpectedException, "An unexpected exception occurred!", exp);
            }
            return null;
        }
        public Instrument[] GetUniqueInstruments()
        {
            try
            {
                return myFieldData.SpecificInstrument;
            }

            catch (Exception exp)
            {
                HandleError(Error.unexpectedException, "An unexpected exception occurred!", exp);
            }

            return null;
        }
        public void CloseLibrary()
        {
            this.fileDecrypted = false;
            this.injects = null;
            this.interestedInst = null;
            this.myClient = null;
            this.myFieldData = null;
            this.myIetf = null;
            this.weather = null;
            
        }

        #endregion
        private void HandleError(Error err, string message, object param)
        {
            // TODO localization of error messages
            Error newErr = myClient.ErrorHandler(err, message, param);
            if (newErr != Error.noErr) Environment.Exit((int)newErr);

        }

        internal double noiseValue(double value, PolynomialEquation deadTime, PolynomialEquation sigma,
            double percentError, double percentBias, double min, double max) {
                         
            // add noise
            double gaussErr = 0;
            double percentErr = 0;
            double biasErr = 0;
            if (sigma != null)
            {
                double sigmaVal = sigma.EvaluatePoly(value);
                gaussErr = Utilities.sigs() * sigmaVal;
            }
            if (percentError != 0)
            {
                percentErr = percentError / 100.0 * (Utilities.randomFloat() - 0.5);
                percentErr *= value;
            }
            if (percentBias != 0)
            {
                biasErr = value * percentBias;
            }

            value += gaussErr + percentErr + biasErr;

            // factor in dead time now
            if (deadTime != null)
            {
                double deadFraction = deadTime.EvaluatePoly(value);
                if(deadFraction >=1) return min;
                if (deadFraction < 0) deadFraction = 0;
                double liveFraction = 1.0 - deadFraction;

                value *= liveFraction;

            }

            // check for minimum
            if (min > value)
            {
                value = min;
            }

            // check for maximum
            if (max < value)
            {
                value = max;
            }
            return value;
        }
        internal Dictionary<String, Object> CalculateReadings(double lat, double lon, double alt, double height, DateTime gpsTime)
        {
            Dictionary<String, Object> currentValues = new Dictionary<String, Object>();
            // check if any instruments are being monitored
            if ((interestedInst == null) || (interestedInst.Count == 0)) return currentValues;
            foreach (Instrument anInst in interestedInst)
            {
                InstrumentType baseInst;
                if (!anInst.IsGeneric())
                {
                    baseInst = GetInstrumentByID(((InstrumentLink)anInst).InstrumentRef);
                }
                else
                {
                    baseInst = (InstrumentType)anInst;
                }

                if (!currentValues.ContainsKey(baseInst.id))
                {
                    // zero out the base value
                    if (baseInst is ScalarInst)
                    {
                        currentValues.Add(baseInst.id, 0.0);
                    }
                    else
                    {
                        Int32 numChannels;
                        if (!Int32.TryParse(((SpectralInst)baseInst).NumberChannels, out numChannels)) numChannels = 0;
                        long[] spectra = new long[numChannels];
                        currentValues.Add(baseInst.id, spectra);
                    }
                }
            }
            foreach (RadSrcType aSrc in myFieldData.RadiationSource)
            {
                if(aSrc.AreaOfEffect.pointIsInside(lat, lon, alt))
                    aSrc.SpatialDistribution.getIntensity(currentValues, lat, lon, alt, height, gpsTime);
            }

            return currentValues;
        }
        /**
         * Search the input file for a media file based on the id string
         */
        internal EmbeddedFile GetFileByID(string id)
        {
            EmbeddedFile[] files = myCurrentFile.BaseFile.AttachedFiles;
            foreach (EmbeddedFile e in files)
            {
                if (e.id == id)
                {
                    return e;
                }
            }
            files = myFieldData.FieldFile;
            foreach (EmbeddedFile e in files)
            {
                if (e.id == id)
                {
                    return e;
                }
            }
            return null;

        }
        internal static InstrumentType GetInstrumentByID(string id)
        {
            InstrumentType[] inst = sCurrentLib.myFieldData.InstrumentType;
            foreach (InstrumentType i in inst)
            {
                if (i.id == id)
                {
                    return i;
                }
            }
            return null;
        }
        private void processFieldData()
        {
            foreach (InstrumentType inst in myFieldData.InstrumentType)
            {
                inst.initialize();
            }
            foreach (InstrumentLink link in myFieldData.SpecificInstrument)
            {
                link.initialize(myFieldData.InstrumentType);
            }

        }
    }  




    class Utilities
    {
        public static double getTemporalFloat(DateTime aTime, TimeDependentFloat[] floatArray)
        {

            // determine if its interpolation or analytical
            if (floatArray[0].GetType() == typeof(TemporalInterpolatedFloat))
            {
                TemporalInterpolatedFloat prevTimePt = (TemporalInterpolatedFloat) floatArray[0];

                if (floatArray.Length == 1)
                {
                    // special case, only one value
                    return prevTimePt.Value;
                }
                if (aTime.CompareTo(prevTimePt.TimePoint) < 0)
                {
                    // time point is before distribution
                    return prevTimePt.Value;
                }
                // loop through times to determine 
                foreach (TimeDependentFloat newTimePt in floatArray)
                {
                    if (aTime.CompareTo(prevTimePt.TimePoint) > 0)
                    {
                        // passed the time of interest
                        double fullInterval, offsetInterval;
                        fullInterval = (newTimePt.Time - prevTimePt.Time).TotalSeconds;
                        offsetInterval = (aTime - prevTimePt.Time).TotalSeconds;

                        double y2, y1, aFloat;
                        y2 = ((TemporalInterpolatedFloat)newTimePt).Value;
                        y1 = ((TemporalInterpolatedFloat)prevTimePt).Value;

                        aFloat = y1 + (y2 - y1) / fullInterval * offsetInterval;
                        return aFloat;

                    }
                    prevTimePt = (TemporalInterpolatedFloat)newTimePt;
                }

                // time point is beyond bounds, return last known value
                return prevTimePt.Value;
            }
            else if (floatArray[0].GetType() == typeof(TemporalAnalyticalFloat))
            {
                TemporalAnalyticalFloat prevIntervalBaseBt = (TemporalAnalyticalFloat)floatArray[0];
                if (floatArray.Length == 1)
                {
                    return prevIntervalBaseBt.getValueAt(aTime);

                }
                if (aTime.CompareTo(prevIntervalBaseBt.TimePoint) < 0)
                {
                    // time point is before first poly
                    return prevIntervalBaseBt.getValueAt(prevIntervalBaseBt.Time);
                }
                // loop through polynomials to find the correct one
                foreach (TimeDependentFloat newTimePt in floatArray)
                {
                    if (aTime.CompareTo(prevIntervalBaseBt.TimePoint) > 0)
                    {
                        // passed the time of interest
                        return prevIntervalBaseBt.getValueAt(aTime);
                    }
                    prevIntervalBaseBt = (TemporalAnalyticalFloat)newTimePt;
                }
                // the time point is beyond bounds
                return prevIntervalBaseBt.getValueAt(aTime);

            }
            else
            {
                // unknown type for this library
                // should never happen, the parser would catch it first.
                throw new Exception("Unknown Time Dependant Float encountered!");
            }

        }
        
        /*
         * Routines to handle the broken .NET xml parser for list items
         * 
         */
        public static double[] listParser(string fpString)
        {
            List<double> output = new List<double>();

            String[] tokenizedString = fpString.Split(new Char[] { ' ' });

            foreach (String aNumber in tokenizedString)
            {
                
                    Double aDouble;
                    if (Double.TryParse(aNumber, out aDouble))
                    {
                        output.Add(aDouble);
                    }
                
            }
            return output.ToArray();

        }
        public static String FPList(double[] arrayIn) {

            String  textOut = "";
            IEnumerator I = arrayIn.GetEnumerator();
            while (I.MoveNext())
            {
                object anObj = I.Current;
                textOut += anObj.ToString() + ' ';
            }


            return textOut;
        }

        static Random myGenerator = new Random();
        public static double randomFloat()
        {
            return myGenerator.NextDouble();

        }
        public static double distanceInMeters(double lat1, double lat2, double lon1, double lon2, double alt1, double alt2)
        {
            double R = 6378137;
            double L1;
            double dLat, dLon, a, b, c, d;
            double deg2Rad = Math.PI / 180.0;

            dLat = (lat1 - lat2) * deg2Rad;
            dLon = (lon1 - lon2) * deg2Rad;

            a = Math.Sin(dLat / 2);
            a *= a;
            b = Math.Sin(dLon / 2);
            b *= b;
            a += Math.Cos(lat1 * deg2Rad) * Math.Cos(lat2 * deg2Rad) * b;
            c = 2*Math.Atan2(Math.Sqrt(a), Math.Sqrt(1-a));
            d = c * R;

            L1 = alt1 - alt2;
            double distance;

            distance = Math.Sqrt(d * d + L1 * L1);

            return distance;
        }
        public static double calculatePoly(PolynomialPair[] equation, double x)
        {
            double y = 0.0;
            foreach (PolynomialPair aPair in equation)
            {
                y += aPair.Coefficient * Math.Pow(x, aPair.Exponent);
            }
            return y;
        }

        /**
         * returns true if the time value is within the array. Otherwise the output values are set to the nearest 
         * boundary time.
         * */
        public static bool interpolateTimes(DateTime[] timeArray, DateTime targetTime, out double fraction, out int index)
        {
            index = 0;

            if (targetTime.CompareTo(timeArray[0]) <= 0)
            {
                fraction = 0.0;
                return (targetTime.CompareTo(timeArray[0]) != 0);
            }
            DateTime previous = timeArray[0];
            foreach (DateTime aTime in timeArray)
            {
                if (targetTime.CompareTo(aTime) <= 0)
                {
                    fraction = (targetTime - previous).TotalSeconds / (aTime - previous).TotalSeconds;
                    return true;
                }
                previous = aTime;
                index++;
            }

            fraction = 0;
            index--;
            return false;

        }
        public static int indexOfBestMatch(String ietf, String[] tags)
        {
            int output = 0;
            int fit = 0;
            String[] sequence = ietf.Split(new Char[] { '-' });
            int ietfLen = sequence.Length;
            int j = 0;
            foreach (String tag in tags)
            {
                int currentFit=0;
                String[] trialSequence = tag.Split(new Char[] { '-' });
                int len = trialSequence.Length;
                if(len > ietfLen) len = ietfLen;
                for (int i = 0; i < len; i++)
                {
                    if (trialSequence[i] == sequence[i]) currentFit++;
                }
                if (currentFit > fit)
                {
                    fit = currentFit;
                    output = j;
                }
                j++;
            }
            return output;

        }
        public static double erfcc(double x)
        {
            // Returns the complementary error function 
            double t, z, ans;

            z = Math.Abs(x);
            t = 1.0 / (1.0 + 0.5 * z);
            ans = t * Math.Exp(-z * z - 1.26551223 + t * (1.00002368 + t * (0.37409196 + t * (0.09678418 + 
                t * (-0.18628806 + t * (0.27886807 + t * (-1.13520398 + t * (1.48851587 + 
                t * (-0.82215223 + t * 0.17087277)))))))));
            return x >= 0.0 ? ans : 2.0 - ans;
        }
        public static double bisection(double x1, double x2, double xacc, double t) {
            // uses bisection to find root between x1 and x2
            int j;
            double dx, f, fmid, xmid, rtb;
            f = rootFind(x1, t);
            fmid = rootFind(x2, t);
            if (f * fmid >= 0.0) // bad parameters for this case, assume perfect measurement
                return 0;
            if(f<0.0){
                dx = x2-x1;
                rtb = x1;
            } else {
                dx = x1 - x2;
                rtb = x2;
            }
            for (j = 1; j <= 100; j++)
            {   
                xmid = rtb + (dx*=0.5);

                fmid = rootFind(xmid,t);
                if (fmid <= 0.0) rtb = xmid;
                if ((Math.Abs(dx) < xacc) ||( fmid == 0.0)) return rtb;
                
            }
            // too many bisections, assume perfection
            return 0;
    }
        public static double rootFind(double x, double t)
        {
            double ans;

            ans = -1.0 + t + erfcc(x);

            return ans;
        }
        
        public static double sigs() {
            // returns a random number of standard deviations off 
            // truth based on a gaussian distribution
            double t = randomFloat();
            int sign;
            double deviation;

            if (randomFloat() >= 0.5)
            {
                sign = 1;
            }
            else
            {
                sign = -1;
            }
            deviation = sign * bisection(0, 1000, 1e-6, t);

            return deviation;

        }
        public static double MetricNormalization( double value, string baseUnits, out string units )
        {

            int code = 0;
            char aChar;

            // first discover range
            if (value == 0)
            {
                units = baseUnits;
                return 0;
            }
            while (value >= 1000)
            {
                value /= 1000;
                code++;
            }

            while (value < 1)
            {
                value *= 1000;
                code--;
            }



            switch (code)
            {
                case -8:
                    aChar = 'y'; // yocto
                    break;
                case -7:
                    aChar = 'z'; // zepto
                    break;
                case -6:
                    aChar = 'a';// atto
                    break;
                case -5:
                    aChar = 'f'; // fempto
                    break;
                case -4:
                    aChar = 'p'; // pico
                    break;
                case -3:
                    aChar = 'n'; // nano
                    break;
                case -2:
                    aChar = 'u'; // micro
                    break;
                case -1:
                    aChar = 'm'; // milli
                   break;
               case 0:
                    aChar = ' '; // no prefix
                    break;
                case 1:
                    aChar = 'k'; // kilo
                   break;
                case 2:
                    aChar = 'M'; // mega
                    break;
                case 3:
                   aChar = 'G'; //Giga
                    break;
                case 4:
                    aChar = 'T'; //Tera
                    break;
                case 5:
                    aChar = 'P'; // Peta
                    break;
                case 6:
                    aChar = 'E'; // Exa
                    break;
                case 7:
                    aChar = 'Z'; // zetta
                    break;
                case 8:
                    aChar = 'Y'; // yotta
                    break;
                default:
                    aChar = '!';
                    break;

            }

            units =  aChar + baseUnits ;
            return value;

        }
    }
}
