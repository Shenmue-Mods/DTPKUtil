using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTPKutil
{
    public static class WavUtil
    {
        public static byte[] AddWavHeader(byte[] input, byte bitDepth = 16)
        {
            byte[] output = new byte[input.Length + 44];
            Array.Copy(Encoding.ASCII.GetBytes("RIFF"), 0, output, 0, 4);
            WriteUint(4, (uint)output.Length - 8, output);
            Array.Copy(Encoding.ASCII.GetBytes("WAVE"), 0, output, 8, 4);
            Array.Copy(Encoding.ASCII.GetBytes("fmt "), 0, output, 12, 4);
            WriteUint(16, 16, output); //Header size
            output[20] = 1; //PCM
            output[22] = 1; //1 channel
            WriteUint(24, 22050, output); //Sample Rate
            WriteUint(28, (uint)(22050*(bitDepth/8)), output); //Bytes per second
            output[32] = (byte)(bitDepth >> 3); //Bytes per sample
            output[34] = bitDepth; //Bits per sample
            Array.Copy(Encoding.ASCII.GetBytes("data"), 0, output, 36, 4);
            WriteUint(40, (uint)output.Length, output); //Date size
            Array.Copy(input, 0, output, 44, input.Length);

            return output;
        }

        public static byte[] ChangeBitDepth16to32(byte[] input)
        {
            byte[] output = new byte[input.Length * 2];
            //Expand by repeating. 0x9876 becomes 0x98769876 which should be equivalent to the original amplitude.
            
            for(int i=0; i<input.Length; i+=2)
            {
                output[(i * 2) + 0] = input[i];
                output[(i * 2) + 1] = input[i + 1];
                output[(i * 2) + 2] = input[i];
                output[(i * 2) + 3] = input[i + 1];
            }

            return output;
        }

        private static void WriteUint(uint offset, uint value, byte[] destination)
        {
            for (int i = 0; i < 4; i++)
            {
                destination[offset + i] = (byte)(value & 0xFF);
                value >>= 8;
            }
        }

    }
}
