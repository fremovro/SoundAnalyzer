using System;
using System.Windows.Forms;
using DPF_C_sh.Models;
using DPF_C_sh.Methods;
using System.Linq;

namespace DPF_C_sh
{
    public partial class SoundAnalyzer : Form
    {
        private MainDataModel _dataContext;
        private DataManagerMethods _dataManagerMethods;
        private AccessoryMethods _accessoryMethods;

        public SoundAnalyzer()
        {
            InitializeComponent();

            _dataContext = new MainDataModel();
            _dataManagerMethods = new DataManagerMethods();
            _accessoryMethods = new AccessoryMethods();
        }

        private void SoundAnalyzer_Load(object sender, EventArgs e)
        {
            //for (int waveInDevice = 0; waveInDevice < WaveIn.DeviceCount; waveInDevice++)
            //{
            //    WaveInCapabilities deviceInfo = WaveIn.GetCapabilities(waveInDevice);

            //    comboBox1.Items.Add(deviceInfo.ProductName);
            //}
        }

        private void OpenFilePart_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Multiselect = true,
                Title = "Select .wav files"
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                _dataManagerMethods.ReadWavFiles(fileDialog, NumUpTimeStart,
                    NumUpTimeRange, ref _dataContext);
                
                _accessoryMethods.PrintFileDataGraphByKey(ref _dataContext, NumUpTimeStart, FileDataPanel,
                    ChosenFileName, _dataContext.wavFiles.First().Key);
            }
        }

        private void DPF_Click(object sender, EventArgs e)
        {
            _dataManagerMethods.DPF(ref _dataContext);

            _accessoryMethods.PrintResultDataGraphByKey(ref _dataContext, DpfDataPanel, NumUpSmooth, ChosenFileName);
        }

        private void CalculateRequencyRatios_Click(object sender, EventArgs e)
        {
            _dataManagerMethods.CalculateRequencyRatios(ref _dataContext, NumUpMaxCount, NumUpIdent);

            _accessoryMethods.PrintRequencyRatiosByKey(_dataContext, ChosenRequency, ChosenFileName);
        }

        private void LeftChangeFile_Click(object sender, EventArgs e)
        {
            _accessoryMethods.ChoseNextFile(ref _dataContext, NumUpTimeStart, NumUpSmooth, FileDataPanel, DpfDataPanel,
                    ChosenFileName, ChosenRequency, _dataContext.wavFiles.First().Key, true);
        }

        private void RightChangeFile_Click(object sender, EventArgs e)
        {
            _accessoryMethods.ChoseNextFile(ref _dataContext, NumUpTimeStart, NumUpSmooth, FileDataPanel, DpfDataPanel,
                    ChosenFileName, ChosenRequency, _dataContext.wavFiles.First().Key, false);
        }
    }
}
