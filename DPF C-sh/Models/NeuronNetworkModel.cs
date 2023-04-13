using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Neuro.Learning;
using AForge.Neuro;

namespace DPF_C_sh.Models
{
    internal class NeuronNetworkModel
    {
        /// <summary>
        /// Массив входных значений для обчующей/тестовой выборки
        /// </summary>
        double[][] input;
        /// <summary>
        /// Массив выходных значений для обчующей/тестовой выборки
        /// </summary>
        double[][] output;
        /// <summary>
        /// Файл нейросети
        /// </summary>
        ActivationNetwork network;
        /// <summary>
        /// Функция обучения обратного распространения
        /// </summary>
        BackPropagationLearning teacher0;
        /// <summary>
        /// Функция обучения дельта-рул
        /// </summary>
        DeltaRuleLearning teacher1;
        /// <summary>
        /// Функция обучения простейшего персептрона (только для сети с 1 слоем)
        /// </summary>
        PerceptronLearning teacher2;
        /// <summary>
        /// Функция обучения устойчивоого обратноого распространения
        /// </summary>
        ResilientBackpropagationLearning teacher3;

        /// <summary>
        /// Конструктор сети для обучения/тестирования
        /// </summary>
        /// <param name="input"></param>
        /// <param name="ouput"></param>
        public NeuronNetworkModel(double[][] input, double[][] ouput)
        {
            this.input = input;
            this.output = ouput;
        }
        /// <summary>
        /// Конструктор сети для открытия уже обученной сети
        /// </summary>
        /// <param name="_network"></param>
        public NeuronNetworkModel(string _network)
        {
            this.network = (ActivationNetwork)Network.Load(_network);
        }
        /// <summary>
        /// Обучение нейросети
        /// </summary>
        /// <param name="Layers"></param>
        /// <param name="LearningAlg"></param>
        /// <param name="Activation"></param>
        public void Learning(int[] Layers, string LearningAlg, string Activation)
        {
            if (network == null)
            {
                //Установить сеть
                if (Activation == "SigmoidFunction")
                    network = new ActivationNetwork(new SigmoidFunction(2), 2, Layers);
                else if (Activation == "ThresholdFunction")
                    network = new ActivationNetwork(new ThresholdFunction(), 2, Layers);
                else if (Activation == "BipolarSigmoidFunction")
                    network = new ActivationNetwork(new BipolarSigmoidFunction(2), 2, Layers);
                //Метод обучения - это алгоритм обучения восприятию 
                if (LearningAlg == "BackPropagationLearning")
                    teacher0 = new BackPropagationLearning(network);
                else if (LearningAlg == "DeltaRuleLearning")
                    teacher1 = new DeltaRuleLearning(network);
                else if (LearningAlg == "PerceptronLearning")
                    teacher2 = new PerceptronLearning(network);
                else if (LearningAlg == "ResilientBackpropagationLearning")
                    teacher3 = new ResilientBackpropagationLearning(network);

                //Определение абсолютная ошибка 
                double error = 1.0;
                Console.WriteLine();
                Console.WriteLine("learning error  ===>  {0}", error);

                //Количество итераций 
                int iterations = 0;
                Console.WriteLine();
                while (error > 0.001)
                {
                    if (LearningAlg == "BackPropagationLearning")
                        error = teacher0.RunEpoch(input, output);
                    else if (LearningAlg == "DeltaRuleLearning")
                        error = teacher1.RunEpoch(input, output);
                    else if (LearningAlg == "PerceptronLearning")
                        error = teacher2.RunEpoch(input, output);
                    else if (LearningAlg == "ResilientBackpropagationLearning")
                        error = teacher3.RunEpoch(input, output);
                    Console.WriteLine("learning error  ===>  {0}", error);
                    iterations++;
                }
                Console.WriteLine("iterations  ===>  {0}", iterations);
                Console.WriteLine();
                Console.WriteLine("sim:");
                network.Save("learnedNetwork");
            }
        }

        public string GetPredict(double[][] PredictData)
        {
            string res = "";
            for (int i = 0; i < PredictData.Length; i++)
            {
                res += String.Format("sim{0}:  ===>  {1}\n", i, network.Compute(PredictData[i])[0]);
            }
            return res;
        }
    }
}
