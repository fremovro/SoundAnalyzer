using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using DPF_C_sh.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

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
                dataContext.fileDataChart = new Chart();

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
            dataContext.fileDataChart.ChartAreas.Add(new ChartArea(chosenFile.Value.fileName));

            // Создаем и настраиваем набор точек для рисования графика
            Series pointSeries = new Series("Sound");
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
                dataContext.dpfDataChart = new Chart();

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
            dataContext.dpfDataChart.ChartAreas.Add(new ChartArea(chosenFile.Value.fileName));

            // Создаем и настраиваем набор точек для рисования графика
            Series pointSeries = new Series("Sound");
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
            var musIntervals = new Dictionary<double, Color>()
            {
                { 0.89, Color.FromArgb(102, 255, 153) }, // Большая секунда
                { 0.84, Color.FromArgb(153, 204, 255) }, // Малая терция
                { 0.79, Color.FromArgb(102, 255, 153) }, // Большая терция
                { 0.75, Color.FromArgb(255, 153, 255) }, // Кварта (чистая)
                { 0.67, Color.FromArgb(255, 153, 255) }, // Квинта (чистая)
                { 0.63, Color.FromArgb(191, 191, 191) }, // Малая секста
                { 0.6, Color.FromArgb(255, 153, 153) }, // Большая секста
                { 0.56, Color.FromArgb(255, 255, 153) }, // Маля септима
                { 0.53, Color.FromArgb(191, 191, 191) }, // Большая септима
                { 0.5, Color.FromArgb(191, 191, 191) } // Октава
            };
            var emotionStr = new List<string>() { "Радость", "Страх", "Отвращение" };
            var emotionMusInt = new List<List<double>>() {
                new List<double> {0.79, 0.89, 0.56},
                new List<double> {0.84, 0.75, 0.67 },
                new List<double> {0.6, 0.67, 0.75, 0.56 }
            };

            // Создаём объект - экземпляр нашего приложения
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();

            // Создаём экземпляр рабочей книги Excel
            Microsoft.Office.Interop.Excel.Workbook workBook;

            // Создаём экземпляр листа Excel
            Microsoft.Office.Interop.Excel.Worksheet workSheet, workSheet2;
            workBook = excelApp.Workbooks.Add();
            workBook.Worksheets.Add();
            workSheet = (Microsoft.Office.Interop.Excel.Worksheet)workBook.Worksheets.get_Item(1);
            workSheet2 = (Microsoft.Office.Interop.Excel.Worksheet)workBook.Worksheets.get_Item(2);

            var rowCount = dataContext.requencyRatios.Count();
            var columnCount = dataContext.requencyRatios.First().Value.Count();

            // Заполнение шапки
            for (int i = 0, j = 0, k = 0, upIndent = 1, leftIdent = 2; j < columnCount + 4; j++)
            {
                if (j < columnCount)
                    workSheet.Cells[i + upIndent, j + leftIdent] = $"X{j + 1}";
                if (j == columnCount)
                    workSheet.Cells[i + upIndent, j + leftIdent] = $"Y1";
                if (j > columnCount)
                {
                    workSheet.Cells[i + upIndent, j + leftIdent] = emotionStr[k];
                    k++;
                }
            }

            // Заполнение названий
            for (int i = 0, j = 0, upIndent = 2, leftIdent = 1; i < rowCount; i++)
                workSheet.Cells[i + upIndent, j + leftIdent] = dataContext.wavFiles
                    .Where(e => e.Key == dataContext.requencyRatios.ToArray()[i].Key).FirstOrDefault().Value.fileName;

            // Заполнение значений
            for (int i = 0, upIndent = 2, leftIdent = 2; i < rowCount; i++)
                for (int j = 0; j < columnCount; j++)
                {
                    dataContext.requencyRatios.ToArray()[i].Value.Sort();
                    foreach (var interval in musIntervals)
                        if (interval.Key == dataContext.requencyRatios.ToArray()[i].Value[j])
                            workSheet.Cells[i + upIndent, j + leftIdent].Interior.Color = interval.Value;
                    workSheet.Cells[i + upIndent, j + leftIdent] = dataContext.requencyRatios.ToArray()[i].Value[j];
                }

            // Заполнение предполагаемых результатов
            for (int i = 0, j = 0, upIndent = 2, leftIdent = 2 + columnCount; i < rowCount; i++)
                workSheet.Cells[i + upIndent, j + leftIdent] = dataContext.wavFiles
                    .Where(e => e.Key == dataContext.requencyRatios.ToArray()[i].Key).FirstOrDefault().Value.emotionNum;

            //Заполнение итогов по данному набору параметров
            var correctCount = 0;
            for (int i = 0, upIndent = 2, leftIdent = 3 + columnCount; i < rowCount; i++)
            {
                var maxCount = 0;
                var maxCountIndex = 0;
                for (int j = 0; j < emotionMusInt.Count(); j++)
                {
                    var count = 0;
                    for (int k = 0; k < emotionMusInt[j].Count(); k++)
                        if (dataContext.requencyRatios.ToArray()[i].Value.Contains(emotionMusInt[j][k]))
                            count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxCountIndex = j + 1;
                    }
                    workSheet.Cells[i + upIndent, j + leftIdent] = count;
                }
                workSheet.Cells[i + upIndent, emotionMusInt.Count() + leftIdent] = maxCountIndex;
                if (maxCountIndex == dataContext.wavFiles
                    .Where(e => e.Key == dataContext.requencyRatios.ToArray()[i].Key).FirstOrDefault().Value.emotionNum)
                {
                    workSheet.Cells[i + upIndent, emotionMusInt.Count() + leftIdent].Interior.Color = Color.FromArgb(169, 208, 142);
                    correctCount++;
                }
                else
                    workSheet.Cells[i + upIndent, emotionMusInt.Count() + leftIdent].Interior.Color = Color.FromArgb(244, 176, 132);
            }
            workSheet.Cells[1, 1] = correctCount;

            // Заполнение шапки
            for (int i = 0, j = 0, upIndent = 1, leftIdent = 1; j < 11; j++)
            {
                if (j < 10)
                    workSheet2.Cells[i + upIndent, j + leftIdent] = $"X{j + 1}";
                if (j == 10)
                    workSheet2.Cells[i + upIndent, j + leftIdent] = $"Y1";
            }
            for (int i = 0, upIndent = 2, leftIdent = 1; i < rowCount; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    var flag = false;
                    if (dataContext.requencyRatios.ToArray()[i].Value.Contains(musIntervals.ToArray()[j].Key))
                        flag = true;
                    if (flag)
                        workSheet2.Cells[i + upIndent, j + leftIdent] = "1";
                    else
                        workSheet2.Cells[i + upIndent, j + leftIdent] = "0";
                }
                var temp = new List<double>()
                {
                    { 0 },{ 0 },{ 0 }
                };
                temp[dataContext.wavFiles
                    .Where(e => e.Key == dataContext.requencyRatios.ToArray()[i].Key).FirstOrDefault().Value.emotionNum - 1] = 1; 

                workSheet2.Cells[i + upIndent, 11] = temp[0];
                workSheet2.Cells[i + upIndent, 12] = temp[1];
                workSheet2.Cells[i + upIndent, 13] = temp[2];
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
            for (int i = dataContext.layersList.Count(); i < int.Parse(layerCount.SelectedItem.ToString()); i++)
            {
                NumericUpDown newNumericUpDown = new NumericUpDown();
                NumericUpDown lastOld = dataContext.layersList.LastOrDefault();
                if (lastOld == null)
                {
                    newNumericUpDown.Location = new Point(layerCount.Location.X, layerCount.Location.Y + 30);
                    newNumericUpDown.Size = new Size(layerCount.Size.Width, layerCount.Size.Height);
                }
                else
                {
                    newNumericUpDown.Location = new Point(lastOld.Location.X, lastOld.Location.Y + 30);
                    newNumericUpDown.Size = new Size(layerCount.Size.Width, layerCount.Size.Height);
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
