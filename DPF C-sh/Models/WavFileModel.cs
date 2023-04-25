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

        public int emotionNum;

        /// <summary>
        /// Частота дискретизации
        /// </summary>
        public int sampleRate;

        //private int byteRate;

        /// <summary>
        /// Размер 1-го сэмпла (в байтах)
        /// </summary>
        public int blockAlign;

        public int bitsPerSample;
        #endregion

        #region Содержимое Wav-файла
        public double[] soundData;
        #endregion

        public WavFileModel(string fileName, int emotionNum, int sampleRate, int blockAlign, int bitsPerSample, double[] soundData)
        {
            this.fileName = fileName;
            this.emotionNum = emotionNum;
            this.sampleRate = sampleRate;
            this.blockAlign = blockAlign;
            this.bitsPerSample = bitsPerSample;
            this.soundData = soundData;
        }
    }
}
