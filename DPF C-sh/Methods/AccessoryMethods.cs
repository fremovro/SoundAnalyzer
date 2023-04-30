﻿using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DPF_C_sh.Models;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace DPF_C_sh.Methods
{
    internal class AccessoryMethods
    {
        public AccessoryMethods() { }

        public void PrintFileDataGraphByKey(ref MainDataModel dataContext, NumericUpDown numUpTimeStart, Panel panel, 
            TextBox chosenFileName, int fileKey)
        {
            var chosenFile = dataContext.wavFiles
                .Where(el => el.Key == fileKey).FirstOrDefault();

            if (dataContext.fileDataChart == null)
            {
                // Создание элемента Chart
                dataContext.fileDataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();

                // Растягивание элемента Chart на панели
                dataContext.fileDataChart.Parent = panel;
                dataContext.fileDataChart.Dock = DockStyle.Fill;
            }
            else
            {
                dataContext.fileDataChart.Series.Clear();
                dataContext.fileDataChart.ChartAreas.Clear();
            }

            // Добавление области для отрисовки графика
            dataContext.fileDataChart.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea(chosenFile.Value.fileName));

            // Создаем и настраиваем набор точек для рисования графика
            System.Windows.Forms.DataVisualization.Charting.Series pointSeries = new System.Windows.Forms.DataVisualization.Charting.Series("Sound");
            pointSeries.ChartType = SeriesChartType.Line;
            pointSeries.ChartArea = chosenFile.Value.fileName;

            var x = (double)numUpTimeStart.Value;
            var delta = 1.00 / chosenFile.Value.sampleRate;

            foreach (var data in chosenFile.Value.soundData)
            {
                pointSeries.Points.AddXY(x, data);
                x += delta;
            }

            //Добавляем созданный набор точек в Chart
            dataContext.fileDataChart.Series.Add(pointSeries);

            chosenFileName.Text = chosenFile.Value.fileName;
        }

        public void PrintResultDataGraphByKey(ref MainDataModel dataContext, Panel panel, NumericUpDown NumUpSmooth, TextBox ChosenFileName)
        {
            var chosenFile = dataContext.wavFiles
                .Where(el => el.Value.fileName == ChosenFileName.Text).FirstOrDefault();

            var chosenResultDpf = dataContext.resultDpf
                .Where(el => el.Key == chosenFile.Key).FirstOrDefault();

            if (dataContext.dpfDataChart is null)
            {
                // Создание элемента Chart
                dataContext.dpfDataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();

                // Растягивание элемента Chart на панели
                dataContext.dpfDataChart.Parent = panel;
                dataContext.dpfDataChart.Dock = DockStyle.Fill;
            }
            else
            {
                dataContext.dpfDataChart.Series.Clear();
                dataContext.dpfDataChart.ChartAreas.Clear();
            }

            // Добавление области для отрисовки графика
            dataContext.dpfDataChart.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea(chosenFile.Value.fileName));

            // Создаем и настраиваем набор точек для рисования графика
            System.Windows.Forms.DataVisualization.Charting.Series pointSeries = new System.Windows.Forms.DataVisualization.Charting.Series("Sound");
            pointSeries.ChartType = SeriesChartType.Line;
            pointSeries.ChartArea = chosenFile.Value.fileName;

            // Сглаживание
            for (int k = 0; k < NumUpSmooth.Value; k++)
                for (int j = 0, m = 4; j < m; j++)
                    for (int i = 2, l = chosenResultDpf.Value.resultDpfData.Count - 1; i < l; i++)
                        chosenResultDpf.Value.resultDpfData[i].Amplitude = 0.5 * (0.5 * (chosenResultDpf.Value.resultDpfData[i - 1].Amplitude 
                            + chosenResultDpf.Value.resultDpfData[i + 1].Amplitude) + chosenResultDpf.Value.resultDpfData[i].Amplitude);

            // Заполнение набора точек
            foreach(var data in chosenResultDpf.Value.resultDpfData)
                if (data.Frecuency > 0)
                    pointSeries.Points.AddXY(data.Frecuency, data.Amplitude);

            // Добавление созданного набора точек к графику
            dataContext.dpfDataChart.Series.Add(pointSeries);
        }

        public void PrintRequencyRatiosByKey(MainDataModel dataContext, TextBox textBox, TextBox ChosenFileName)
        {
            var chosenFile = dataContext.wavFiles
                .Where(el => el.Value.fileName == ChosenFileName.Text).FirstOrDefault();

            var chosenResultRR = dataContext.requencyRatios
                .Where(el => el.Key == chosenFile.Key).FirstOrDefault();

            textBox.Text = "Полученные отношения частот:\r\n";

            foreach(var e in chosenResultRR.Value)
                textBox.Text += e.ToString() + "\r\n";
        }

        public void ChoseNextFile(ref MainDataModel dataContext, NumericUpDown numUpTimeStart, NumericUpDown numUpSmooth,
            Panel filePanel, Panel dpfPanel,
            TextBox chosenFileName, TextBox chosenRequency, int fileKey, bool left)
        {
            string newName = string.Empty;

            var chosenFile = dataContext.wavFiles
                    .Where(el => el.Value.fileName == chosenFileName.Text).FirstOrDefault();

            var newChosenFile = left
                ? dataContext.wavFiles.Where(el => el.Key == chosenFile.Key - 1).FirstOrDefault()
                : dataContext.wavFiles.Where(el => el.Key == chosenFile.Key + 1).FirstOrDefault();

            if(newChosenFile.Value != null)
            {
                if (dataContext.wavFiles.Any())
                    PrintFileDataGraphByKey(ref dataContext, numUpTimeStart, filePanel,
                        chosenFileName, newChosenFile.Key);

                if(dataContext.resultDpf.Any())
                    PrintResultDataGraphByKey(ref dataContext, dpfPanel, numUpSmooth, chosenFileName);

                if(dataContext.requencyRatios.Any())
                    PrintRequencyRatiosByKey(dataContext, chosenRequency, chosenFileName);
            }
        }

        public void CreateExcelRequencyRatios(MainDataModel dataContext)
        {
            // Создаём объект - экземпляр нашего приложения
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();

            // Создаём экземпляр рабочей книги Excel
            Microsoft.Office.Interop.Excel.Workbook workBook;

            // Создаём экземпляр листа Excel
            Microsoft.Office.Interop.Excel.Worksheet workSheet;
            workBook = excelApp.Workbooks.Add();
            workSheet = (Microsoft.Office.Interop.Excel.Worksheet)workBook.Worksheets.get_Item(1);

            double[][] output = new double[dataContext.requencyRatios.ToArray().Length][];

            foreach (var el in dataContext.wavFiles)
                output[el.Key] = new double[] { el.Value.emotionNum };

            int index = 1;
            foreach (var el in dataContext.requencyRatios)
            {
                if (index == 1)
                {
                    for (var i = 0; i < el.Value.Count; i++)
                        workSheet.Cells[index, i + 1] = $"X{i + 1}";
                    workSheet.Cells[index, el.Value.Count + 1] = $"Y1";
                    index++;
                }
                for (var i = 0; i < el.Value.Count; i++)
                    workSheet.Cells[index, i + 1] = el.Value[i];
                workSheet.Cells[index, el.Value.Count + 1] = output[el.Key][0];
                index++;
            }
            // Открываем созданный excel-файл
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }

        public void NLayerGenerator(ref MainDataModel dataContext, ComboBox layerCount, TabPage tabPage)
        {
            for (int i = dataContext.layersList.Count() - 1; dataContext.layersList.Count() != int.Parse(layerCount.SelectedItem.ToString()) && i >= 0; i--)
            {
                tabPage.Controls.Remove(dataContext.layersList[i]);
                dataContext.layersList.Remove(dataContext.layersList[i]);
            }
            var loc = layerCount.Location;
            for (int i = dataContext.layersList.Count(); i < int.Parse(layerCount.SelectedItem.ToString()); i++)
            {
                NumericUpDown newNumericUpDown = new NumericUpDown();
                NumericUpDown lastOld = dataContext.layersList.LastOrDefault();
                if (lastOld == null)
                {
                    newNumericUpDown.Location = new System.Drawing.Point(loc.X, loc.Y+30);
                    newNumericUpDown.Size = layerCount.Size;
                }
                else
                {
                    newNumericUpDown.Location = new System.Drawing.Point(lastOld.Location.X, lastOld.Location.Y + 30);
                    newNumericUpDown.Size = layerCount.Size;
                }
                dataContext.layersList.Add(newNumericUpDown);
                tabPage.Controls.Add(newNumericUpDown);
            }
        }

        public void NOpenLearnedFile(ref MainDataModel dataContext, OpenFileDialog openFileDialog)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dataContext.neuronNetworkModel = new NeuronNetworkModel(openFileDialog.FileName);
            }
        }
    }
}
