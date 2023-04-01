using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace DPF_C_sh.Models
{
    internal class MainViewModel
    {
        public Dictionary<int, WavFileModel> wavFiles { get; set; }
        public List<SoundElement> resultDpfData { get; set; }
        public List<double> requencyRatios { get; set; }
        public Chart fileDataChart { get; set; }
        public Chart dpfDataChart { get; set; }
        public double maxDpfAmplitude { get; set; }

        public MainViewModel() 
        {
            fileDataChart = null;
            dpfDataChart = null;
        }
    }
}
