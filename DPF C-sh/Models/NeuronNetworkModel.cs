﻿using System;
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
        public double[][] input;
        /// <summary>
        /// Массив выходных значений для обчующей/тестовой выборки
        /// </summary>
        public double[][] output;
        /// <summary>
        /// Файл нейросети
        /// </summary>
        public ActivationNetwork network;
        /// <summary>
        /// Функция обучения обратного распространения
        /// </summary>
        public BackPropagationLearning teacher0;
        /// <summary>
        /// Функция обучения дельта-рул
        /// </summary>
        public DeltaRuleLearning teacher1;
        /// <summary>
        /// Функция обучения простейшего персептрона (только для сети с 1 слоем)
        /// </summary>
        public PerceptronLearning teacher2;
        /// <summary>
        /// Функция обучения устойчивоого обратноого распространения
        /// </summary>
        public ResilientBackpropagationLearning teacher3;

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
    }
}
