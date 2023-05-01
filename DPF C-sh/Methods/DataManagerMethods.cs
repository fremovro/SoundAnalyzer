//using AForge.Neuro.Learning;
//using AForge.Neuro;
using Accord.Neuro.Learning;
using Accord.Neuro;
using DPF_C_sh.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using AForge.Math.Metrics;
using DPF_C_sh.ActivationFunctionsCustom;

namespace DPF_C_sh.Methods
{
    internal class DataManagerMethods
    {
        public DataManagerMethods() { }

        #region Методы для нахождения отношений частот
        /// <summary>
        /// Считывание файла (формат .wav)
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="numUpTimeStart"></param>
        /// <param name="numUpTimeRange"></param>
        /// <param name="dataContext"></param>
        public void ReadWavFiles(OpenFileDialog fileDialog, NumericUpDown numUpTimeStart, NumericUpDown numUpTimeRange, ref MainDataModel dataContext)
        {
            dataContext.wavFiles = new Dictionary<int, WavFileModel>();
            var index = 0;

            foreach(var file in fileDialog.FileNames)
            {
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
                        new WavFileModel(file.Split('\\')[file.Split('\\').Length - 1].Split('.')[0].Split('-')[0],
                        Convert.ToInt32(file.Split('\\')[file.Split('\\').Length - 1].Split('.')[0].Split('-')[1]),
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
        public void DPF(ref MainDataModel dataContext)
        {
            dataContext.resultDpf = new Dictionary<int, ResultDpfModel>();

            foreach (var file in dataContext.wavFiles)
            {
                var result = new List<SoundElement>();
                var maxAmplitude = double.MinValue;

                int n = file.Value.soundData.Length;
                if (n > 0)
                {
                    alglib.complex[] dpfResult = new alglib.complex[n];
                    alglib.fftr1d(file.Value.soundData, n, out dpfResult);

                    // частота = частота дискретизации / размер массива
                    var frequency = (double)file.Value.sampleRate / n;

                    for (int k = 0; k < n / 2; k++)
                    {
                        var amplitudeValue = (2 * Math.Sqrt(Math.Pow(dpfResult[k].x, 2) + Math.Pow(dpfResult[k].y, 2))) / n;
                        var frequencyValue = frequency * k;

                        maxAmplitude = amplitudeValue > maxAmplitude ? amplitudeValue : maxAmplitude;

                        result.Add(new SoundElement(amplitudeValue, frequencyValue));
                    }
                }

                dataContext.resultDpf.Add(file.Key, new ResultDpfModel(result, maxAmplitude));
            }
        }

        public void CalculateRequencyRatios(ref MainDataModel dataContext, NumericUpDown numUpMaxCount, NumericUpDown numUpIdent)
        {
            dataContext.requencyRatios = new Dictionary<int, List<double>>();
            foreach (var resultDpf in dataContext.resultDpf)
            {
                var delta = (int)numUpIdent.Value;

                var resultLocalMaximum = FindLocalMaximum(resultDpf.Value.resultDpfData, delta, numUpMaxCount);

                dataContext.requencyRatios.Add(resultDpf.Key, new List<double>());

                for (int k = 0; k < resultLocalMaximum.Count; k++)
                    for (int l = k + 1; l < resultLocalMaximum.Count; l++)
                    {
                        dataContext.requencyRatios[resultDpf.Key].Add(resultLocalMaximum[k].Frecuency / resultLocalMaximum[l].Frecuency >= 1
                            ? Math.Round(resultLocalMaximum[l].Frecuency / resultLocalMaximum[k].Frecuency, 2) : Math.Round(resultLocalMaximum[k].Frecuency / resultLocalMaximum[l].Frecuency,2));
                    }
            }
        }

        private List<SoundElement> FindLocalMaximum(List<SoundElement> resultData, int separatorCount, NumericUpDown numUpMaxCount)
        {
            var resultTemp = new List<SoundElement>();
            var res = new List<SoundElement>();
            SoundElement temp;
            for (int i = 2; i < resultData.Count() - 1; i++)
                if (resultData[i].Amplitude > resultData[i + 1].Amplitude && resultData[i].Amplitude > resultData[i - 1].Amplitude)
                    resultTemp.Add(resultData[i]);

            for (int i = 0; i < resultTemp.Count() - 1; i++)
                for (int j = i + 1; j < resultTemp.Count(); j++)
                    if (resultTemp[i].Amplitude < resultTemp[j].Amplitude)
                    {
                        temp = resultTemp[j];
                        resultTemp[j] = resultTemp[i];
                        resultTemp[i] = temp;
                    }

            for (int i = 0; i < resultTemp.Count(); i++)
                if (i == 0)
                    res.Add(resultTemp[i]);
                else
                {
                    bool f = true;
                    for (int j = 0; j < res.Count(); j++)
                        if (Math.Abs(resultTemp[i].Frecuency - res[j].Frecuency) < separatorCount)
                            f = false;
                    if (f) res.Add(resultTemp[i]);
                }
            res.RemoveRange((int)numUpMaxCount.Value, res.Count() - (int)numUpMaxCount.Value);

            return res;
        }
        #endregion

        #region Методы для работы с нейросетью
        public void NSampleGeneration(ref MainDataModel dataContext)
        {
            double[][] input = new double[dataContext.requencyRatios.ToArray().Length][];
            double[][] output = new double[dataContext.requencyRatios.ToArray().Length][];

            foreach (var el in dataContext.wavFiles)
            {
                output[el.Key] = Enumerable.Repeat(0.0, 3).ToArray();
                output[el.Key][el.Value.emotionNum] = 1;
            }

            int index = 0;
            foreach(var el in dataContext.requencyRatios)
            {
                el.Value.Sort();
                input[index] = el.Value.ToArray();
                index++;
            }
            dataContext.neuronNetworkModel = new NeuronNetworkModel(input, output);
        }

        public void NLearning(ref MainDataModel dataContext, ComboBox LearningAlg, ComboBox Activation, NumericUpDown iterationsCount)
        {
            int[] Layers = new int[dataContext.layersList.Count()];
            for (int i = 0; i < dataContext.layersList.Count(); i++)
            {
                Layers[i] = (int)dataContext.layersList[i].Value;
            }

            if (dataContext.neuronNetworkModel.network == null)
            {
                //Установить сеть
                if (Activation.Text == "SigmoidFunction")
                    dataContext.neuronNetworkModel.network = new ActivationNetwork(new SigmoidFunction(), Layers[0], Layers.Skip(1).Take(Layers.Length-1).ToArray());
                else if (Activation.Text == "ThresholdFunction")
                    dataContext.neuronNetworkModel.network = new ActivationNetwork(new ThresholdFunction(), Layers[0], Layers.Skip(1).Take(Layers.Length-1).ToArray());
                else if (Activation.Text == "BipolarSigmoidFunction")
                    dataContext.neuronNetworkModel.network = new ActivationNetwork(new BipolarSigmoidFunction(), Layers[0], Layers.Skip(1).Take(Layers.Length-1).ToArray());
                else if (Activation.Text == "TanhActivationFunction")
                    dataContext.neuronNetworkModel.network = new ActivationNetwork(new TanhActivationFunction(), Layers[0], Layers.Skip(1).Take(Layers.Length - 1).ToArray());
                //Метод обучения - это алгоритм обучения восприятию 
                if (LearningAlg.Text == "BackPropagationLearning")
                    dataContext.neuronNetworkModel.teacher0 = new BackPropagationLearning(dataContext.neuronNetworkModel.network);
                else if (LearningAlg.Text == "DeltaRuleLearning")
                    dataContext.neuronNetworkModel.teacher1 = new DeltaRuleLearning(dataContext.neuronNetworkModel.network);
                else if (LearningAlg.Text == "PerceptronLearning")
                    dataContext.neuronNetworkModel.teacher2 = new PerceptronLearning(dataContext.neuronNetworkModel.network);
                else if (LearningAlg.Text == "ResilientBackpropagationLearning")
                    dataContext.neuronNetworkModel.teacher3 = new ResilientBackpropagationLearning(dataContext.neuronNetworkModel.network);
                else if (LearningAlg.Text == "LevenbergMarquardtLearning")
                    dataContext.neuronNetworkModel.teacher4 = new LevenbergMarquardtLearning(dataContext.neuronNetworkModel.network);
                //dataContext.neuronNetworkModel.teacher0.LearningRate = 1;
                //Определение абсолютная ошибка 
                double error = 1.0;
                Console.WriteLine();
                Console.WriteLine("learning error  ===>  {0}", error);

                //Количество итераций 
                int iterations = 0;
                Console.WriteLine();
                while (error > 0.01 && iterations < iterationsCount.Value)
                {
                    if (LearningAlg.Text == "BackPropagationLearning")
                        error = dataContext.neuronNetworkModel.teacher0.RunEpoch(dataContext.neuronNetworkModel.input, dataContext.neuronNetworkModel.output);
                    else if (LearningAlg.Text == "DeltaRuleLearning")
                        error = dataContext.neuronNetworkModel.teacher1.RunEpoch(dataContext.neuronNetworkModel.input, dataContext.neuronNetworkModel.output);
                    else if (LearningAlg.Text == "PerceptronLearning")
                        error = dataContext.neuronNetworkModel.teacher2.RunEpoch(dataContext.neuronNetworkModel.input, dataContext.neuronNetworkModel.output);
                    else if (LearningAlg.Text == "ResilientBackpropagationLearning")
                        error = dataContext.neuronNetworkModel.teacher3.RunEpoch(dataContext.neuronNetworkModel.input, dataContext.neuronNetworkModel.output);
                    Console.WriteLine("learning error  ===>  {0}", error);
                    iterations++;
                }
                Console.WriteLine("iterations  ===>  {0}", iterations);
                Console.WriteLine();
                Console.WriteLine("sim:");
                //dataContext.neuronNetworkModel.network.Save("learnedNetwork");
            }
        }

        public void NGetPredict(MainDataModel dataContext, RichTextBox resText, NumericUpDown numericUpDown1, NumericUpDown numericUpDown2, NumericUpDown numericUpDown3)
        {
            double[][] PredictData = new double[1][];
            PredictData[0] = new double[] { (double)numericUpDown1.Value, (double)numericUpDown2.Value, (double)numericUpDown3.Value };
            string res = "";
            for (int i = 0; i < PredictData.Length; i++)
            {
                res += String.Format("sim{0}:  ===>  {1}, {2}, {3}\n", i, dataContext.neuronNetworkModel.network.Compute(PredictData[i])[0], dataContext.neuronNetworkModel.network.Compute(PredictData[i])[1], dataContext.neuronNetworkModel.network.Compute(PredictData[i])[2]);
            }
            resText.Text = res;
        }
        #endregion
    }
}
