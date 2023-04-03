using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPF_C_sh.Models
{
    internal class ResultDpfModel
    {
        public List<SoundElement> resultDpfData { get; set; }
        public double maxDpfAmplitude { get; set; }

        public ResultDpfModel(List<SoundElement> ResultDpfData, double MaxDpfAmplitude) 
        { 
            resultDpfData = ResultDpfData;
            maxDpfAmplitude = MaxDpfAmplitude;
        }
    }
}
