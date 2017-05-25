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
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gov.nnss.rsl.xsim.impl
{
    /**
     * Wrapper class to correct for the zlib wrapper produced as per the XSim Standard
     * that is not handled directly by .NET library
     */
    public class ZLibStream : DeflateStream

    {
        private CompressionMode myMode;
        public ZLibStream(Stream aStream, CompressionMode aMode) : base(aStream, aMode)
        {
            CleanHeader(aStream, aMode);
        }
        public ZLibStream(Stream aStream, CompressionMode aMode, Boolean opt)
            : base(aStream, aMode, opt)
        {
            CleanHeader(aStream, aMode);

        }
        private void CleanHeader(Stream aStream, CompressionMode aMode) {

            myMode = aMode;
            if (aMode == CompressionMode.Compress)
            {
                // Write the zlib header
                aStream.WriteByte(0x78); // 8 specifies deflate usage, 7 specifies 32k window size (log2(32K) - 8)
                aStream.WriteByte(0x9C); // default compression
            }
            else
            {
                // validate the header
                byte marker = (byte)aStream.ReadByte();
                if (marker != 0x78)
                {
                    throw new Exception("ZLib stream provided does not have a valid header!");
                }
                aStream.ReadByte();
            }

        }
        public override int Read(byte[] array, int offset, int count)
        {
            int output = base.Read(array, offset, count);

            UpdateChecksum(array, offset, count);
            return output;
        }

        public override int ReadByte()
        {
            int output =  base.ReadByte();
            UpdateChecksum((byte)output);
            return output;
        }

        public override void Write(byte[] array, int offset, int count)
        {
            base.Write(array, offset, count);
            UpdateChecksum(array, offset, count);
        }

        public override void WriteByte(byte value)
        {
            base.WriteByte(value);
            UpdateChecksum(value);
        }
        public Byte[] GetChecksum()
        {
            Int32 check = this.Checksum;
            Byte[] bytes = new Byte[4];
            bytes[0] = (byte)(check >> 24);
            bytes[1] = (byte)(0x000000FF & (check >> 16));
            bytes[2] = (byte)(0x000000FF & (check >> 8));
            bytes[3] = (byte)(0x000000FF & check);

            return bytes;
        }
        public Boolean VerifyChecksum()
        {
            Int32 check = this.Checksum;
            Byte[] bytes = new Byte[4];
            BaseStream.Read(bytes, 0, 4);
            if (bytes[0] != (byte)(check >> 24)
                || bytes[1] != (byte)(0x000000FF & (check >> 16))
                || bytes[2] != (byte)(0x000000FF & (check >> 8))
                || bytes[3] != (byte)(0x000000FF & check))
            {
                return false;
            }
            return true;


        }
        private Int32 a = 1;
        private Int32 b = 0;
        private Int32 Checksum
        {
            get
            {
                return ((b * 65536) + a);
            }
        }
        private void UpdateChecksum(byte[] data, int offset, int length)
        {
            // Adler checksum
            for (int counter = 0; counter < length; ++counter)
            {
                UpdateChecksum(data[offset + counter]);
            }
        }
        private void UpdateChecksum(byte aByte)
        {
            a = (a + aByte) % 65521;
            b = (b + a) % 65521;
        }
    }
}
