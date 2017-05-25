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

#if !NO_CRYPTO
using System.Security.Cryptography;
#endif

using XSim = gov.nnss.rsl.xsim;


namespace gov.nnss.rsl.xsim
{
    public interface XSimClient
    {
        void ScalarMeasurement(Instrument anInst, double latitude, double longitude, double altitude, double height,
            System.DateTime aTime, float aValue, String units);
        void SpectralMeasurement(Instrument anInst, double latitude, double longitude, double altitude, double height,
            DateTime aTime, UInt32[] spectra);
        // includes splash screen
        void InjectNotification(String title, bool autoPlay, String fileName, String mimeType, System.IO.Stream injectData);
        void WeatherUpdate(double latitude, double longitude, double altitude, String weatherType);
        String PasswordRequest(String userName);
        Byte[] DecryptKeyRequest(String certIssuer, String certSerialNumber, Byte[] encryptedKey);
        Error ErrorHandler(Error errorCode, String errorMessage, object parameter);
        void UpdateFile(Uri replacementURI, Uri supplementalURI, bool defaultUpdate);
    }

    public enum Error
    {
        noErr = 0,
        memErr, // memory allocation failure in library
        ioError, // standard io error
        noUserSpecified, // attempted to call a function which requires a current user
        malformedFileFormat, // XML source file isn't to specification
        noSuchUser, // attempted to specify a user that doesn't exist
        badPassword, // password provided isn't valid
        parseError, // Basic XML parsing syntax error
        instrumentNotFound, // instrument specified not found
        earlyTime, // requesting data from a time before the simulation starts
        lateTime, // requesting data from a time after the simulation ends
        unimplemented, // this function or option is not implemented yet
        userAlreadySet, // A user has already been successfully set
        unexpectedException, // An exception was thrown that was not expected
        encryptionNotSupported, // Used for library version built without encryption encountering encrypted data
    }
    public interface XSimFieldLibrary
    {
        /**
         * Entry point into the library. Provide a stream pre-loaded with the XSim format data, 
         * the preferred language ("en-us"), and an object supporting the callbacks
         */
        Error LoadScenario(System.IO.Stream baseFile, String ietfLanguage, XSimClient callbacks);
        /**
         * Currently not implemented but in the future can be used to modify and existing loaded file
         */
        Error AddSupplementalFile(System.IO.Stream supplementalFile);
        /**
         * Return a list of all the valid users that can access the field data from the
         * previously loaded XSim file
         */
        String[] GetUserNames();

        /**
         * Trigger the authentication and decryption process based on the selected user name
         */
        Error SetCurrentUser(String aUser);
        /**
         * Should be called once a second with the updated time and position. 
         * returns a dictionary of the instrument's and the Double or UInt32 array object if
         * generateDictionary is true, otherwise null 
         */
        IDictionary<Instrument, Object> HeartBeat(double latitude, double longitude, double altitude, double height, DateTime gpsTime, bool generateDictionary);
        /**
         * In order to get measurement results from an instrument the client must register interest in that instrument. To
         * stop data generation for that instrument base false for the interested parameter.
         */
        Error RegisterInstrumentInterest(Instrument anInst, bool interested);
        /**
         * Provides a list of serialized instruments available in the simulation file.
         */
        Instrument[] GetUniqueInstruments();
        /**
         * Provides a list of instrument types/models.
         */
        Instrument[] GetGenericInstruments();

        /**
         * Returns the version of this library
         */
        int GetVersion();
        /**
         * Indicates if the library was compiled with decryption capability
         */
        bool EncryptedFilesSupported();
        /**
         * Optional call to release resources the library has allocated
         */
        void CloseLibrary();
    }

    public interface Instrument
    {
        /*
         * Returns the contents of a zip file containing an HTML5 application to display the image of 
         * an instrument. When values are available from the heartbeat function the environment's javascript variables of
         * value (the scalar measurement value)
         * latitude (the current latitude, in degrees)
         * longitude (the current longitude, in degrees)
         * measTime (the GMT time of the measurement)
         * spectra (an array integer values representing channel values)
         * The HTML5 app shall trigger an update whenever the measTime value is updated so update that value last
         */
        System.IO.Stream GetSkin();
        /* 
         * Returns a localized name of the instrument
         */
        String GetName();
        /*
         * Returns a serial number of the instrument if available
         */
        String GetSerialNumber();
        /*
         * Returns a unique UUID of the instrument if available
         */
        Guid GetGUID();
        /*
         * Indicates if the instrument is a generic base model or a serialized individual instrument
         */ 
        Boolean IsGeneric();
    }

    /*
     * Version Notes:
     * 1: Initial pre-release beta
     *      Inject notifications only provide a stream and file name. The file name does not refer to a storage location.
     *      Compile with NO_CRYPTO defined in order to remove all crypto functionality from the binary
     *      
     * 2: Fixed a bug where registering interest only in a base model would not stick. Fixed algorithm for 
     *      calculating if a location is inside a conic section.
     *      
     * 3: Left out an update of the SimFile to correctly handle non-rectangular nested grids such as those used in RASCAL
     */
}
