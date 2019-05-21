using System;
using System.Text;
using System.Collections.Generic;

namespace DTPKutil
{
    public enum DtpkVariant
    {
        Dreamcast,
        Xbox,
    }
    public class DtpkFile
    {
        private byte[] _data;
        public byte[] FileData
        {
            get { return _data; }
        }
        private List<AudioSample> _samples = new List<AudioSample>();
        public List<AudioSample> Samples
        {
            get { return _samples; }
        }
        private DtpkVariant _variant;
        public bool Is2018Format { get; private set; }
        public DtpkFile(byte[] data)
        {
            if (data[0] == 'D' && data[1] == 'T' && data[2] == 'P' && data[3] == 'K')
            {
                _variant = DtpkVariant.Dreamcast;
            }
            else if(data[3] == 'x' && data[2] == 'b' && data[1] == 'o' && data[0] == 'x' &&
                data[7] == 'D' && data[6] == 'T' && data[5] == 'P' && data[4] == 'K')
            {
                _variant = DtpkVariant.Xbox;
            }
            else
            {
                throw new ArgumentException("Not DTPK");
            }
            _data = data;
            ParseFile();
        }

        private void ParseFile()
        {
            if (_variant == DtpkVariant.Dreamcast)
                ParseDreamcast();
            else if (_variant == DtpkVariant.Xbox)
                ParseXbox();
        }

        private void ParseDreamcast()
        {
            uint sampleTable = ReadUint(0x3C);
            uint sampleCount = ReadUint(sampleTable) + 1;
            for (uint i = 0; i < sampleCount; i++)
            {
                uint sampleEntryStart = sampleTable + 4 + (i * 0x10);
                AudioSample sample = new AudioSample();
                uint info = ReadUint(sampleEntryStart);
                sample.Location = info & 0x7FFFFF;
                sample.UnknownFlag = ((info & 0x800000) == 0x800000);
                sample.Compressed = ((info & 0x1000000) == 0x1000000);
                sample.UnknownFlag2 = ((info & 0x2000000) == 0x2000000);
                sample.LoopStart = ReadUShort(sampleEntryStart + 4);
                sample.LoopEnd = ReadUShort(sampleEntryStart + 6);
                sample.Size = ReadUint(sampleEntryStart + 12);
                _samples.Add(sample);
                if (sample.Compressed && (sample.Size >> 1) > sample.LoopEnd)
                {
                    //sample.Size >> 1 is the total sample count on DC
                    //LoopEnd is always <= Sample count. If LoopEnd is > Sample count,
                    //we probably have 32 bit samples meaning we are the PC version
                    Is2018Format = true;
                }
            }
        }

        private void ParseXbox()
        {
            uint sampleTable = ReadUint(0xB8);
            uint sampleCount = ReadUint(sampleTable) + 1;
            throw new ArgumentException("XBOX is not supported at this time.");
            /*for (uint i = 0; i < sampleCount; i++)
            {
                uint sampleEntryStart = sampleTable + 4 + (i * 0x10);
                AudioSample sample = new AudioSample();
                uint info = ReadUint(sampleEntryStart);
                sample.Location = info & 0x7FFFFF;
                sample.UnknownFlag = ((info & 0x800000) == 0x800000);
                sample.Compressed = ((info & 0x1000000) == 0x1000000);
                sample.UnknownFlag2 = ((info & 0x2000000) == 0x2000000);
                sample.LoopStart = ReadUShort(sampleEntryStart + 4);
                sample.LoopEnd = ReadUShort(sampleEntryStart + 6);
                sample.Size = ReadUint(sampleEntryStart + 12);
                _samples.Add(sample);
            }*/
        }

        public string PrintSamplesInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{_samples.Count} samples in file.");
            if (Is2018Format)
            {
                sb.AppendLine($"This file is probably from the 2018 port");
            }
            for(int i=0; i<_samples.Count; i++)
            {
                AudioSample sample = _samples[i];
                sb.Append($"{i + 1}. ");
                sb.Append((sample.Compressed) ? "ADPCM " : "PCM ");
                sb.Append((sample.UnknownFlag ? "Flag1=Yes " : "Flag1=No "));
                sb.Append((sample.UnknownFlag2 ? "Flag2=Yes. " : "Flag2=No. "));
                sb.Append($"Offset: {sample.Location.ToString("X")} Len: {sample.Size.ToString("X")} ");
                sb.AppendLine($"Loop Start: {sample.LoopStart} Loop End: {sample.LoopEnd}");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Get a copy of this DtpkFile with all samples decompressed
        /// </summary>
        public DtpkFile Decompress(bool into32bit = false)
        {
            uint sizeIncrease = 0;
            if (!Is2018Format)
            {
                foreach (AudioSample sample in _samples)
                {
                    if (into32bit)
                    {
                        if (sample.Compressed)
                        {
                            sizeIncrease += ((sample.Size * 8) - sample.Size);
                        }
                        else
                        {
                            sizeIncrease += sample.Size; //Double for 32 bit
                        }
                    }
                    else if(sample.Compressed)
                    {
                        sizeIncrease += ((sample.Size * 4) - sample.Size);
                    }
                }
            }
            byte[] newFile = new byte[_data.Length + sizeIncrease];
            Array.Copy(_data, newFile, _data.Length);
            WriteUint(0x8, (uint)newFile.Length, newFile);
            uint sampleStart = _samples[0].Location;
            uint sampleTable = ReadUint(0x3C);
            for (uint i = 0; i < _samples.Count; i++)
            {
                var sample = _samples[(int)i];
                uint sampleEntryStart = sampleTable + 4 + (i * 0x10);
                uint sampleLocation = sampleStart;
                if (sample.UnknownFlag)
                {
                    sampleLocation |= 0x800000;
                }
                if (sample.UnknownFlag2)
                {
                    sampleLocation |= 0x2000000;
                }
                WriteUint(sampleEntryStart, sampleLocation, newFile);
                byte[] sampleData = GetSampleData(sample, true, into32bit);
                if (!Is2018Format && sample.Compressed)
                {
                    WriteUint(sampleEntryStart + 0xC, (uint)sampleData.Length, newFile);
                }
                Array.Copy(sampleData, 0, newFile, sampleStart, sampleData.Length);
                sampleStart += (uint)sampleData.Length;
            }
            
            return new DtpkFile(newFile);
        }

        public byte[] GetSampleData(AudioSample sample, bool decompress, bool scaleTo32bit)
        {
            byte[] retval = null;
            if (!Is2018Format && sample.Compressed && decompress)
            {
                retval = adpcm2pcm(sample.Location, sample.Size);
            }
            else
            {
                retval = new byte[sample.Size];
                Array.Copy(_data, sample.Location, retval, 0, sample.Size);
            }
            if (scaleTo32bit)
            {
                retval = WavUtil.ChangeBitDepth16to32(retval);
            }
            return retval;
        }

        #region AICA ADPCM decoding
        static readonly int[] diff_lookup = {
            1,3,5,7,9,11,13,15,
            -1,-3,-5,-7,-9,-11,-13,-15,
        };

        static int[] index_scale = {
            0x0e6, 0x0e6, 0x0e6, 0x0e6, 0x133, 0x199, 0x200, 0x266
        };

        private byte[] adpcm2pcm(uint src, uint length)
        {
            byte[] dst = new byte[length * 4];
            int dstLoc = 0;
            int cur_quant = 0x7f;
            int cur_sample = 0;
            bool highNybble = false;

            while (dstLoc < dst.Length)
            {
                int shift1 = highNybble ? 4 : 0;
                int delta = (_data[src] >> shift1) & 0xf;

                int x = cur_quant * diff_lookup[delta & 15];
                x = cur_sample + ((int)(x + ((uint)x >> 29)) >> 3);
                cur_sample = (x < -32768) ? -32768 : ((x > 32767) ? 32767 : x);
                cur_quant = (cur_quant * index_scale[delta & 7]) >> 8;
                cur_quant = (cur_quant < 0x7f) ? 0x7f : ((cur_quant > 0x6000) ? 0x6000 : cur_quant);

                dst[dstLoc++] = (byte)(cur_sample & 0xFF);
                dst[dstLoc++] = (byte)((cur_sample >> 8) & 0xFF);

                highNybble = !highNybble;
                if (!highNybble)
                {
                    src++;
                }
            }
            return dst;
        }
        #endregion

        private uint ReadUint(uint offset)
        {
            uint retval = 0;
            for (int i = 3; i >= 0; i--)
            {
                retval <<= 8;
                retval += _data[i + offset];
            }
            return retval;
        }
        private ushort ReadUShort(uint offset)
        {
            ushort retval = 0;
            for (int i = 1; i >= 0; i--)
            {
                retval <<= 8;
                retval += _data[i + offset];
            }
            return retval;
        }
        private static void WriteUint(uint offset, uint value, byte[] destination)
        {
            for (int i = 0; i < 4; i++)
            {
                destination[offset + i] = (byte)(value & 0xFF);
                value >>= 8;
            }
        }
        private static void WriteUshort(uint offset, ushort value, byte[] destination)
        {
            for (int i = 0; i < 2; i++)
            {
                destination[offset + i] = (byte)(value & 0xFF);
                value >>= 8;
            }
        }
    }

    public class AudioSample
    {
        public uint Location { get; internal set; }
        public uint Size { get; internal set; }
        public bool UnknownFlag { get; internal set; }
        public bool Compressed { get; internal set; }
        public bool UnknownFlag2 { get; internal set; }
        public ushort LoopStart { get; internal set; }
        public ushort LoopEnd { get; internal set; }
    }
}
