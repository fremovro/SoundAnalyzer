namespace DPF_C_sh
{
    partial class SoundAnalyzer
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LeftChangeFile = new System.Windows.Forms.Button();
            this.OpenFilePart = new System.Windows.Forms.Button();
            this.ChosenFileName = new System.Windows.Forms.TextBox();
            this.RightChangeFile = new System.Windows.Forms.Button();
            this.DPF = new System.Windows.Forms.Button();
            this.ChosenRequency = new System.Windows.Forms.TextBox();
            this.NumUpMaxCount = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.NumUpSmooth = new System.Windows.Forms.NumericUpDown();
            this.DpfDataPanel = new System.Windows.Forms.Panel();
            this.FileDataPanel = new System.Windows.Forms.Panel();
            this.NumUpIdent = new System.Windows.Forms.NumericUpDown();
            this.CalculateRequencyRatios = new System.Windows.Forms.Button();
            this.NumUpTimeRange = new System.Windows.Forms.NumericUpDown();
            this.NumUpTimeStart = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.progressLearning = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.iterationCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.learnNetwork = new System.Windows.Forms.Button();
            this.openNetwork = new System.Windows.Forms.Button();
            this.activationSelector = new System.Windows.Forms.ComboBox();
            this.algoritmSelector = new System.Windows.Forms.ComboBox();
            this.layerSelector = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.resultText = new System.Windows.Forms.RichTextBox();
            this.predictGet = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpMaxCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpSmooth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpIdent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpTimeRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpTimeStart)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationCount)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(857, 431);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LeftChangeFile);
            this.tabPage1.Controls.Add(this.OpenFilePart);
            this.tabPage1.Controls.Add(this.ChosenFileName);
            this.tabPage1.Controls.Add(this.RightChangeFile);
            this.tabPage1.Controls.Add(this.DPF);
            this.tabPage1.Controls.Add(this.ChosenRequency);
            this.tabPage1.Controls.Add(this.NumUpMaxCount);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.NumUpSmooth);
            this.tabPage1.Controls.Add(this.DpfDataPanel);
            this.tabPage1.Controls.Add(this.FileDataPanel);
            this.tabPage1.Controls.Add(this.NumUpIdent);
            this.tabPage1.Controls.Add(this.CalculateRequencyRatios);
            this.tabPage1.Controls.Add(this.NumUpTimeRange);
            this.tabPage1.Controls.Add(this.NumUpTimeStart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(849, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DPF";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LeftChangeFile
            // 
            this.LeftChangeFile.Location = new System.Drawing.Point(9, 86);
            this.LeftChangeFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LeftChangeFile.Name = "LeftChangeFile";
            this.LeftChangeFile.Size = new System.Drawing.Size(79, 29);
            this.LeftChangeFile.TabIndex = 39;
            this.LeftChangeFile.Text = "<\r\n";
            this.LeftChangeFile.UseVisualStyleBackColor = true;
            this.LeftChangeFile.Click += new System.EventHandler(this.LeftChangeFile_Click);
            // 
            // OpenFilePart
            // 
            this.OpenFilePart.Location = new System.Drawing.Point(9, 3);
            this.OpenFilePart.Name = "OpenFilePart";
            this.OpenFilePart.Size = new System.Drawing.Size(110, 22);
            this.OpenFilePart.TabIndex = 27;
            this.OpenFilePart.Text = "Open file part";
            this.OpenFilePart.UseVisualStyleBackColor = true;
            this.OpenFilePart.Click += new System.EventHandler(this.OpenFilePart_Click);
            // 
            // ChosenFileName
            // 
            this.ChosenFileName.Location = new System.Drawing.Point(10, 60);
            this.ChosenFileName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChosenFileName.Name = "ChosenFileName";
            this.ChosenFileName.Size = new System.Drawing.Size(166, 22);
            this.ChosenFileName.TabIndex = 41;
            // 
            // RightChangeFile
            // 
            this.RightChangeFile.Location = new System.Drawing.Point(96, 86);
            this.RightChangeFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RightChangeFile.Name = "RightChangeFile";
            this.RightChangeFile.Size = new System.Drawing.Size(79, 29);
            this.RightChangeFile.TabIndex = 40;
            this.RightChangeFile.Text = ">";
            this.RightChangeFile.UseVisualStyleBackColor = true;
            this.RightChangeFile.Click += new System.EventHandler(this.RightChangeFile_Click);
            // 
            // DPF
            // 
            this.DPF.Location = new System.Drawing.Point(9, 129);
            this.DPF.Name = "DPF";
            this.DPF.Size = new System.Drawing.Size(167, 29);
            this.DPF.TabIndex = 28;
            this.DPF.Text = "DPF";
            this.DPF.UseVisualStyleBackColor = true;
            this.DPF.Click += new System.EventHandler(this.DPF_Click);
            // 
            // ChosenRequency
            // 
            this.ChosenRequency.Location = new System.Drawing.Point(9, 249);
            this.ChosenRequency.Multiline = true;
            this.ChosenRequency.Name = "ChosenRequency";
            this.ChosenRequency.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChosenRequency.Size = new System.Drawing.Size(168, 156);
            this.ChosenRequency.TabIndex = 38;
            // 
            // NumUpMaxCount
            // 
            this.NumUpMaxCount.Location = new System.Drawing.Point(9, 220);
            this.NumUpMaxCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumUpMaxCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumUpMaxCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUpMaxCount.Name = "NumUpMaxCount";
            this.NumUpMaxCount.Size = new System.Drawing.Size(79, 22);
            this.NumUpMaxCount.TabIndex = 37;
            this.NumUpMaxCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(126, 6);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.Text = "db (!!!)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // NumUpSmooth
            // 
            this.NumUpSmooth.Location = new System.Drawing.Point(9, 163);
            this.NumUpSmooth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumUpSmooth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NumUpSmooth.Name = "NumUpSmooth";
            this.NumUpSmooth.Size = new System.Drawing.Size(166, 22);
            this.NumUpSmooth.TabIndex = 35;
            this.NumUpSmooth.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // DpfDataPanel
            // 
            this.DpfDataPanel.Location = new System.Drawing.Point(185, 129);
            this.DpfDataPanel.Name = "DpfDataPanel";
            this.DpfDataPanel.Size = new System.Drawing.Size(663, 275);
            this.DpfDataPanel.TabIndex = 34;
            // 
            // FileDataPanel
            // 
            this.FileDataPanel.Location = new System.Drawing.Point(185, 3);
            this.FileDataPanel.Name = "FileDataPanel";
            this.FileDataPanel.Size = new System.Drawing.Size(663, 111);
            this.FileDataPanel.TabIndex = 33;
            // 
            // NumUpIdent
            // 
            this.NumUpIdent.DecimalPlaces = 2;
            this.NumUpIdent.Location = new System.Drawing.Point(96, 220);
            this.NumUpIdent.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.NumUpIdent.Name = "NumUpIdent";
            this.NumUpIdent.Size = new System.Drawing.Size(79, 22);
            this.NumUpIdent.TabIndex = 32;
            this.NumUpIdent.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // CalculateRequencyRatios
            // 
            this.CalculateRequencyRatios.Location = new System.Drawing.Point(9, 186);
            this.CalculateRequencyRatios.Name = "CalculateRequencyRatios";
            this.CalculateRequencyRatios.Size = new System.Drawing.Size(167, 29);
            this.CalculateRequencyRatios.TabIndex = 31;
            this.CalculateRequencyRatios.Text = "Result";
            this.CalculateRequencyRatios.UseVisualStyleBackColor = true;
            this.CalculateRequencyRatios.Click += new System.EventHandler(this.CalculateRequencyRatios_Click);
            // 
            // NumUpTimeRange
            // 
            this.NumUpTimeRange.DecimalPlaces = 3;
            this.NumUpTimeRange.Location = new System.Drawing.Point(96, 31);
            this.NumUpTimeRange.Name = "NumUpTimeRange";
            this.NumUpTimeRange.Size = new System.Drawing.Size(79, 22);
            this.NumUpTimeRange.TabIndex = 30;
            this.NumUpTimeRange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumUpTimeStart
            // 
            this.NumUpTimeStart.DecimalPlaces = 3;
            this.NumUpTimeStart.Location = new System.Drawing.Point(9, 31);
            this.NumUpTimeStart.Name = "NumUpTimeStart";
            this.NumUpTimeStart.Size = new System.Drawing.Size(79, 22);
            this.NumUpTimeStart.TabIndex = 29;
            this.NumUpTimeStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.progressLearning);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.iterationCount);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.learnNetwork);
            this.tabPage2.Controls.Add(this.openNetwork);
            this.tabPage2.Controls.Add(this.activationSelector);
            this.tabPage2.Controls.Add(this.algoritmSelector);
            this.tabPage2.Controls.Add(this.layerSelector);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(849, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "NeuronNetwork";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // progressLearning
            // 
            this.progressLearning.BackColor = System.Drawing.SystemColors.Control;
            this.progressLearning.Location = new System.Drawing.Point(24, 42);
            this.progressLearning.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressLearning.Name = "progressLearning";
            this.progressLearning.Size = new System.Drawing.Size(445, 41);
            this.progressLearning.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(700, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Кол-во итераций";
            // 
            // iterationCount
            // 
            this.iterationCount.Location = new System.Drawing.Point(665, 143);
            this.iterationCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iterationCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.iterationCount.Name = "iterationCount";
            this.iterationCount.Size = new System.Drawing.Size(166, 22);
            this.iterationCount.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(697, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Функция активации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(698, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Алгоритм обучения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Количество слоёв";
            // 
            // learnNetwork
            // 
            this.learnNetwork.Location = new System.Drawing.Point(198, 123);
            this.learnNetwork.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.learnNetwork.Name = "learnNetwork";
            this.learnNetwork.Size = new System.Drawing.Size(106, 19);
            this.learnNetwork.TabIndex = 20;
            this.learnNetwork.Text = "Обучить";
            this.learnNetwork.UseVisualStyleBackColor = true;
            this.learnNetwork.Click += new System.EventHandler(this.learnNetwork_Click);
            // 
            // openNetwork
            // 
            this.openNetwork.Location = new System.Drawing.Point(690, 178);
            this.openNetwork.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.openNetwork.Name = "openNetwork";
            this.openNetwork.Size = new System.Drawing.Size(120, 43);
            this.openNetwork.TabIndex = 19;
            this.openNetwork.Text = "Открыть файл готовой сети";
            this.openNetwork.UseVisualStyleBackColor = true;
            this.openNetwork.Click += new System.EventHandler(this.openNetwork_Click);
            // 
            // activationSelector
            // 
            this.activationSelector.FormattingEnabled = true;
            this.activationSelector.Items.AddRange(new object[] {
            "BipolarSigmoidFunction",
            "SigmoidFunction",
            "ThresholdFunction",
            "TanhActivationFunction"});
            this.activationSelector.Location = new System.Drawing.Point(665, 103);
            this.activationSelector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.activationSelector.Name = "activationSelector";
            this.activationSelector.Size = new System.Drawing.Size(167, 21);
            this.activationSelector.TabIndex = 18;
            // 
            // algoritmSelector
            // 
            this.algoritmSelector.FormattingEnabled = true;
            this.algoritmSelector.Items.AddRange(new object[] {
            "BackPropagationLearning",
            "DeltaRuleLearning",
            "PerceptronLearning",
            "ResilientBackpropagationLearning",
            "LevenbergMarquardtLearning"});
            this.algoritmSelector.Location = new System.Drawing.Point(665, 64);
            this.algoritmSelector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.algoritmSelector.Name = "algoritmSelector";
            this.algoritmSelector.Size = new System.Drawing.Size(167, 21);
            this.algoritmSelector.TabIndex = 17;
            // 
            // layerSelector
            // 
            this.layerSelector.FormattingEnabled = true;
            this.layerSelector.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.layerSelector.Location = new System.Drawing.Point(508, 64);
            this.layerSelector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.layerSelector.Name = "layerSelector";
            this.layerSelector.Size = new System.Drawing.Size(140, 21);
            this.layerSelector.TabIndex = 16;
            this.layerSelector.SelectedIndexChanged += new System.EventHandler(this.layerSelector_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.resultText);
            this.tabPage3.Controls.Add(this.predictGet);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(849, 405);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Predict";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(364, 119);
            this.resultText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(219, 79);
            this.resultText.TabIndex = 17;
            this.resultText.Text = "";
            // 
            // predictGet
            // 
            this.predictGet.Location = new System.Drawing.Point(86, 119);
            this.predictGet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.predictGet.Name = "predictGet";
            this.predictGet.Size = new System.Drawing.Size(120, 19);
            this.predictGet.TabIndex = 16;
            this.predictGet.Text = "Test NN";
            this.predictGet.UseVisualStyleBackColor = true;
            this.predictGet.Click += new System.EventHandler(this.predictGet_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 22);
            this.textBox1.TabIndex = 18;
            // 
            // SoundAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 434);
            this.Controls.Add(this.tabControl1);
            this.Name = "SoundAnalyzer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SoundAnalyzer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpMaxCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpSmooth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpIdent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpTimeRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpTimeStart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationCount)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button LeftChangeFile;
        private System.Windows.Forms.Button OpenFilePart;
        private System.Windows.Forms.TextBox ChosenFileName;
        private System.Windows.Forms.Button RightChangeFile;
        private System.Windows.Forms.Button DPF;
        private System.Windows.Forms.TextBox ChosenRequency;
        private System.Windows.Forms.NumericUpDown NumUpMaxCount;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown NumUpSmooth;
        private System.Windows.Forms.Panel DpfDataPanel;
        private System.Windows.Forms.Panel FileDataPanel;
        private System.Windows.Forms.NumericUpDown NumUpIdent;
        private System.Windows.Forms.Button CalculateRequencyRatios;
        private System.Windows.Forms.NumericUpDown NumUpTimeRange;
        private System.Windows.Forms.NumericUpDown NumUpTimeStart;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button learnNetwork;
        private System.Windows.Forms.Button openNetwork;
        private System.Windows.Forms.ComboBox activationSelector;
        private System.Windows.Forms.ComboBox algoritmSelector;
        private System.Windows.Forms.ComboBox layerSelector;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox resultText;
        private System.Windows.Forms.Button predictGet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown iterationCount;
        private System.Windows.Forms.ProgressBar progressLearning;
        private System.Windows.Forms.TextBox textBox1;
    }
}

