using DPF_C_sh.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DPF_C_sh.Methods
{
    internal class DataManagerMethods
    {
        public DataManagerMethods() { }

        /// <summary>
        /// Считывание файла (формат .wav)
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="numUpTimeStart"></param>
        /// <param name="numUpTimeRange"></param>
        /// <param name="dataContext"></param>
        public void ReadWavFiles(OpenFileDialog fileDialog, NumericUpDown numUpTimeStart, NumericUpDown numUpTimeRange, ref MainViewModel dataContext)
        {
            dataContext.wavFiles = new Dictionary<int, WavFileModel>();
            var index = 0;

            foreach(var file in fileDialog.FileNames)
            {
                int xxp;
                if (index == 2)
                    xxp = 0;
                using (FileStream fileStream = new FileStream(file, FileMode.Open))
                using (BinaryReader reader = new BinaryReader(fileStream))
                {

                    #region Считывание заголовка
                    var chunkID = reader.ReadInt32();
                    var chunkSize = reader.ReadInt32();
                    var format = reader.ReadInt32();
                    var subchunk1ID = reader.ReadInt32();
                    var subchunk1Size = reader.ReadInt32();
                    var audioFormat = reader.ReadInt16();
                    var numChannels = reader.ReadInt16();
                    var sampleRate = reader.ReadInt32();
                    var byteRate = reader.ReadInt32();
                    var blockAlign = reader.ReadInt16();
                    var bitsPerSample = reader.ReadInt16();

                    if (subchunk1Size == 18)
                    {
                        var fmtExtraSize = reader.ReadInt16();
                        reader.ReadBytes(fmtExtraSize);
                    }
                    #endregion

                    #region Считываение данных
                    var dataID = reader.ReadInt32();
                    var dataSize = reader.ReadInt32();
                    var tempData = reader.ReadBytes(chunkSize);
                    #endregion

                    // Номер начального байта
                    var i = (int)((double)numUpTimeStart.Value * sampleRate * blockAlign);

                    // Номер конечного байта
                    var endByteNum = i + (int)((double)numUpTimeRange.Value * sampleRate * blockAlign);

                    var sound = 0;
                    var tempSoundData = new List<double>();

                    // Преобразование массива байтов в последовательность сигналов
                    while (i < tempData.Length && i < endByteNum)
                    {
                        if (bitsPerSample == 8)
                            sound = Convert.ToInt16(tempData[i]);
                        else if (bitsPerSample == 16)
                            sound = BitConverter.ToInt16(tempData, i);
                        else if (bitsPerSample == 32)
                            sound = BitConverter.ToInt32(tempData, i);

                        tempSoundData.Add(sound);
                        i += blockAlign;
                    }
                    reader.Close();
                    fileStream.Close();

                    dataContext.wavFiles.Add(index, 
                        new WavFileModel(file.Split('\\')[file.Split('\\').Length - 1].Split('.')[0], 
                        sampleRate, blockAlign, bitsPerSample, tempSoundData.ToArray()));

                    index++;
                }
            }
        }

        /// <summary>
        /// Дискретное преобразование Фурье
        /// </summary>
        /// <param name="dataContext"></param>
        /// <param name="maxAmplitude"></param>
        /// <returns></returns>
        public void DPF(ref MainViewModel dataContext)
        {
            var result = new List<SoundElement>();
            //var minAmplitude = double.MaxValue;
            var maxAmplitude = double.MinValue;

            int n = dataContext.wavFile.soundData.Length;
            if (n > 0)
            {
                alglib.complex[] dpfResult = new alglib.complex[n];
                alglib.fftr1d(dataContext.wavFile.soundData, n, out dpfResult);

                // частота = частота дискретизации / размер массива
                var frequency = (double)dataContext.wavFile.sampleRate / n;

                for (int k = 0; k < n / 2; k++)
                {
                    var amplitudeValue = (2 * Math.Sqrt(Math.Pow(dpfResult[k].x, 2) + Math.Pow(dpfResult[k].y, 2))) / n;
                    var frequencyValue = frequency * k;

                    maxAmplitude = amplitudeValue > maxAmplitude ? amplitudeValue : maxAmplitude;
                    //minAmplitude = amplitudeValue < minAmplitude ? amplitudeValue : minAmplitude;

                    result.Add(new SoundElement(amplitudeValue, frequencyValue));
                }
            }

            dataContext.maxDpfAmplitude = maxAmplitude;

            dataContext.resultDpfData = result;
        }

        public void CalculateRequencyRatios(ref MainViewModel dataContext, NumericUpDown numUpMaxCount, NumericUpDown numUpIdent)
        {
            dataContext.requencyRatios = new List<double>();

            var delta = (int)numUpIdent.Value;

            var resultLocalMaximum = FindLocalMaximum(dataContext.resultDpfData, delta, numUpMaxCount);

            for (int k = 0; k < resultLocalMaximum.Count; k++)
            {
                for (int l = k + 1; l < resultLocalMaximum.Count; l++)
                {
                    dataContext.requencyRatios.Add(resultLocalMaximum[k].Frecuency / resultLocalMaximum[l].Frecuency >= 1 
                        ? resultLocalMaximum[l].Frecuency / resultLocalMaximum[k].Frecuency : resultLocalMaximum[k].Frecuency / resultLocalMaximum[l].Frecuency);
                }
            }
        }

        private List<SoundElement> FindLocalMaximum(List<SoundElement> resultData, int separatorCount, NumericUpDown numUpMaxCount)
        {
            var resultTemp = new List<SoundElement>();
            var res = new List<SoundElement>();
            SoundElement temp;

            for (int i = 2; i < resultData.Count() - 1; i++)
            {
                if (resultData[i].Amplitude > resultData[i + 1].Amplitude && resultData[i].Amplitude > resultData[i - 1].Amplitude)
                {
                    resultTemp.Add(resultData[i]);
                }
            }
            for (int i = 0; i < resultTemp.Count() - 1; i++)
            {
                for (int j = i + 1; j < resultTemp.Count(); j++)
                {
                    if (resultTemp[i].Amplitude < resultTemp[j].Amplitude)
                    {
                        temp = resultTemp[j];
                        resultTemp[j] = resultTemp[i];
                        resultTemp[i] = temp;
                    }
                }
            }
            for (int i = 0; i < resultTemp.Count(); i++)
            {
                if (i == 0)
                {
                    res.Add(resultTemp[i]);
                }
                else
                {
                    bool f = true;
                    for (int j = 0; j < res.Count(); j++)
                    {
                        if (Math.Abs(resultTemp[i].Frecuency - res[j].Frecuency) < separatorCount)
                        {
                            f = false;
                        }
                    }
                    if (f) res.Add(resultTemp[i]);
                }
            }
            res.RemoveRange((int)numUpMaxCount.Value, res.Count() - (int)numUpMaxCount.Value);
            return res;
        }
    }
}
