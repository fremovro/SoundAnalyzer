using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using DPF_C_sh.Models;

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
            //// Создаём объект - экземпляр нашего приложения
            //Excel.Application excelApp = new Excel.Application();

            //// Создаём экземпляр рабочей книги Excel
            //Excel.Workbook workBook;

            //// Создаём экземпляр листа Excel
            //Excel.Worksheet workSheet;
            //Excel.Worksheet workSheet2;
            //workBook = excelApp.Workbooks.Add();
            //workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);
            //workSheet2 = (Excel.Worksheet)workBook.Worksheets.Add();

            //// Заполняем первый столбец листа из массива Y[0..n-1]
            //for (int j = 1; j <= dataContext.requencyRatios.Count(); j++)
            //{
            //    workSheet.Cells[j, 1] = 10 * Math.Log10(dataContext.requencyRatios[j - 1].Amplitude / dataContext.maxDpfAmplitude);
            //    workSheet.Cells[j, 2] = res[j - 1].Frecuency;
            //}

            //// Вывод текста
            //int cellerNum = 1;
            //for (int k = 0; k < res.Count; k++)
            //{
            //    for (int l = k + 1; l < res.Count; l++)
            //    {
            //        if (res[k].Frecuency / res[l].Frecuency >= 1)
            //        {
            //            workSheet2.Cells[cellerNum, 1] = res[l].Frecuency / res[k].Frecuency;
            //        }
            //        else
            //            workSheet2.Cells[cellerNum, 1] = res[k].Frecuency / res[l].Frecuency;
            //        cellerNum++;
            //    }
            //}


            //// Открываем созданный excel-файл
            //excelApp.Visible = true;
            //excelApp.UserControl = true;

            //if (resultDataChart.Series.Count < 4)
            //{
            //    for (int i = 0; i < res.Count; i++)
            //    {
            //        resultDataChart.Series.Add("p" + i.ToString());
            //        resultDataChart.Series["p" + i.ToString()].Color = Color.Red;
            //        resultDataChart.Series["p" + i.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            //        resultDataChart.Series["p" + i.ToString()].Points.AddXY(res[i].Frecuency, 10 * Math.Log10(res[i].Amplitude / dataContext.maxDpfAmplitude));
            //    }
            //}
            //else
            //{
            //    for (int i = 0; resultDataChart.Series.Count != 1; i++)
            //    {
            //        resultDataChart.Series.Remove(resultDataChart.Series["p" + i.ToString()]);
            //    }
            //    for (int i = 0; i < res.Count; i++)
            //    {
            //        resultDataChart.Series.Add("p" + i.ToString());
            //        resultDataChart.Series["p" + i.ToString()].Color = Color.Red;
            //        resultDataChart.Series["p" + i.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            //        resultDataChart.Series["p" + i.ToString()].Points.AddXY(res[i].Frecuency, 10 * Math.Log10(res[i].Amplitude / dataContext.maxDpfAmplitude));
            //    }
            //}
        }
    }
}
