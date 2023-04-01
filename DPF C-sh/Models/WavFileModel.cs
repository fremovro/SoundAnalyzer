using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPF_C_sh.Models
{
    internal class WavFileModel
    {
        #region Заголовок Wav-файла
        public string fileName;
        //private int chunkID;

        //private int chunkSize;

        //private int format;

        //private int subchunk1ID;

        //private int subchunk1Size;

        //private int audioFormat;

        //private int numChannels;

        /// <summary>
        /// Частота дискретизации
        /// </summary>
        public int sampleRate;

        //private int byteRate;

        /// <summary>
        /// Размер 1-го сэмпла (в байтах)
        /// </summary>
        public int blockAlign;

        /// <summary>
        /// Размер 1-го сэмпла (в битах) - для моно
        /// </summary>
        //private int bitsPerSample;

        //private int fmtExtraSize;

        public int bitsPerSample;
        #endregion

        #region Содержимое Wav-файла
        //private int dataID;

        //private int dataSize;

        public double[] soundData;
        #endregion

        //public WavFileModel(int chunkID, int chunkSize, int format, int subchunk1ID, int subchunk1Size, int audioFormat, int numChannels,
        //    int sampleRate, int byteRate, int blockAlign, int bitsPerSample, int fmtExtraSize, int dataID, int dataSize)
        //{

        //}

        public WavFileModel(string fileName, int sampleRate, int blockAlign, int bitsPerSample, double[] soundData)
        {
            this.fileName = fileName;
            this.sampleRate = sampleRate;
            this.blockAlign = blockAlign;
            this.bitsPerSample = bitsPerSample;
            this.soundData = soundData;
        }
    }
}
