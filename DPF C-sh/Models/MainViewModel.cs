using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace DPF_C_sh.Models
{
    internal class MainDataModel
    {
        public Dictionary<int, WavFileModel> wavFiles { get; set; }
        public Dictionary<int, ResultDpfModel> resultDpf { get; set; }
        public Dictionary<int, List<double>> requencyRatios { get; set; }
        public NeuronNetworkModel neuronNetworkModel { get; set; }
        public Chart fileDataChart { get; set; }
        public Chart dpfDataChart { get; set; }

        public MainDataModel() 
        {
            fileDataChart = null;
            dpfDataChart = null;
            wavFiles = new Dictionary<int, WavFileModel>();
            resultDpf = new Dictionary<int, ResultDpfModel>();
            requencyRatios = new Dictionary<int, List<double>>();
        }
    }
}
