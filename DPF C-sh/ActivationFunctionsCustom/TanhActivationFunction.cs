//using AForge.Neuro;
using Accord.Neuro.Learning;
using Accord.Neuro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPF_C_sh.ActivationFunctionsCustom
{
    public class TanhActivationFunction : IActivationFunction
    {
        public double Function(double x)
        {
            return Math.Tanh(x);
        }

        public double Derivative(double x)
        {
            double tanh = Function(x);
            return 1 - tanh * tanh;
        }

        public double Derivative2(double y)
        {
            return 1 - y * y;
        }
    }
}
