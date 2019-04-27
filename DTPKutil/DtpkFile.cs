﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTPKutil
{
    public class DtpkFile
    {
        private byte[] _data;
        private List<AudioSample> _samples = new List<AudioSample>();
        public List<AudioSample> Samples
        {
            get { return _samples; }
        }
        public DtpkFile(byte[] data)
        {
            if (data[0] != 'D' && data[1] != 'T' && data[2] != 'P' && data[3] != 'K')
            {
                throw new ArgumentException("Not DTPK");
            }
            _data = data;
            ParseFile();
        }

        private void ParseFile()
        {
            uint sampleTable = ReadUint(0x3C);
            uint sampleCount = ReadUint(sampleTable) + 1;
            for(uint i=0; i < sampleCount; i++)
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
            }
        }

        public string PrintSamplesInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{_samples.Count} samples in file.");
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

        static readonly int[] diff_lookup = {
            1,3,5,7,9,11,13,15,
            -1,-3,-5,-7,-9,-11,-13,-15,
        };

        static int[] index_scale = {
            0x0e6, 0x0e6, 0x0e6, 0x0e6, 0x133, 0x199, 0x200, 0x266,
            0x0e6, 0x0e6, 0x0e6, 0x0e6, 0x133, 0x199, 0x200, 0x266 //same value for speedup
        };

        static int limit(int val, int min, int max)
        {
            if (val < min) return min;
            else if (val > max) return max;
            else return val;
        }

        public byte[] GetSampleData(AudioSample sample, bool decompress)
        {
            if (sample.Compressed && decompress)
            {
                return adpcm2pcm(sample.Location, sample.Size);
            }
            byte[] retval = new byte[sample.Size];
            Array.Copy(_data, sample.Location, retval, 0, sample.Size);
            return retval;
        }

        private byte[] adpcm2pcm(uint src, uint length)
        {
            byte[] dst = new byte[length * 4];
            int dstLoc = 0;
            int signal = 0, step = 0x7f;

            while (dstLoc < dst.Length)
            {
                int data = _data[src++];
                int val = data >> 4; //High nybble

                signal += (step * diff_lookup[val]) / 8;
                signal = limit(signal, -32768, 32767);

                step = (step * index_scale[val]) >> 8;
                step = limit(step, 0x7f, 0x6000);

                dst[dstLoc++] = (byte)(signal & 0xFF);
                dst[dstLoc++] = (byte)((signal >> 8) & 0xFF);
                
                val = data & 15; //Low nybble

                signal += (step * diff_lookup[val]) / 8;
                signal = limit(signal, -32768, 32767);

                step = (step * index_scale[val]) >> 8;
                step = limit(step, 0x7f, 0x6000);

                dst[dstLoc++] = (byte)(signal & 0xFF);
                dst[dstLoc++] = (byte)((signal >> 8) & 0xFF);
            }
            return dst;
        }

        private uint ReadUint(uint offset)
        {
            uint retval = 0;
            for(int i=3; i>=0; i--)
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