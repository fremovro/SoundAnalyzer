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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.learnNetwork = new System.Windows.Forms.Button();
            this.openNetwork = new System.Windows.Forms.Button();
            this.activationSelector = new System.Windows.Forms.ComboBox();
            this.algoritmSelector = new System.Windows.Forms.ComboBox();
            this.layerSelector = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.predictGet = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpMaxCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpSmooth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpIdent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpTimeRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpTimeStart)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1286, 696);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1278, 662);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DPF";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LeftChangeFile
            // 
            this.LeftChangeFile.Location = new System.Drawing.Point(14, 139);
            this.LeftChangeFile.Name = "LeftChangeFile";
            this.LeftChangeFile.Size = new System.Drawing.Size(118, 47);
            this.LeftChangeFile.TabIndex = 39;
            this.LeftChangeFile.Text = "<\r\n";
            this.LeftChangeFile.UseVisualStyleBackColor = true;
            this.LeftChangeFile.Click += new System.EventHandler(this.LeftChangeFile_Click);
            // 
            // OpenFilePart
            // 
            this.OpenFilePart.Location = new System.Drawing.Point(14, 5);
            this.OpenFilePart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OpenFilePart.Name = "OpenFilePart";
            this.OpenFilePart.Size = new System.Drawing.Size(165, 35);
            this.OpenFilePart.TabIndex = 27;
            this.OpenFilePart.Text = "Open file part";
            this.OpenFilePart.UseVisualStyleBackColor = true;
            this.OpenFilePart.Click += new System.EventHandler(this.OpenFilePart_Click);
            // 
            // ChosenFileName
            // 
            this.ChosenFileName.Location = new System.Drawing.Point(15, 97);
            this.ChosenFileName.Name = "ChosenFileName";
            this.ChosenFileName.Size = new System.Drawing.Size(247, 29);
            this.ChosenFileName.TabIndex = 41;
            // 
            // RightChangeFile
            // 
            this.RightChangeFile.Location = new System.Drawing.Point(144, 139);
            this.RightChangeFile.Name = "RightChangeFile";
            this.RightChangeFile.Size = new System.Drawing.Size(118, 47);
            this.RightChangeFile.TabIndex = 40;
            this.RightChangeFile.Text = ">";
            this.RightChangeFile.UseVisualStyleBackColor = true;
            this.RightChangeFile.Click += new System.EventHandler(this.RightChangeFile_Click);
            // 
            // DPF
            // 
            this.DPF.Location = new System.Drawing.Point(14, 209);
            this.DPF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DPF.Name = "DPF";
            this.DPF.Size = new System.Drawing.Size(251, 47);
            this.DPF.TabIndex = 28;
            this.DPF.Text = "DPF";
            this.DPF.UseVisualStyleBackColor = true;
            this.DPF.Click += new System.EventHandler(this.DPF_Click);
            // 
            // ChosenRequency
            // 
            this.ChosenRequency.Location = new System.Drawing.Point(14, 402);
            this.ChosenRequency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChosenRequency.Multiline = true;
            this.ChosenRequency.Name = "ChosenRequency";
            this.ChosenRequency.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChosenRequency.Size = new System.Drawing.Size(250, 249);
            this.ChosenRequency.TabIndex = 38;
            // 
            // NumUpMaxCount
            // 
            this.NumUpMaxCount.Location = new System.Drawing.Point(14, 356);
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
            this.NumUpMaxCount.Size = new System.Drawing.Size(118, 29);
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
            this.checkBox1.Location = new System.Drawing.Point(189, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 25);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.Text = "db (!!!)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // NumUpSmooth
            // 
            this.NumUpSmooth.Location = new System.Drawing.Point(14, 264);
            this.NumUpSmooth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NumUpSmooth.Name = "NumUpSmooth";
            this.NumUpSmooth.Size = new System.Drawing.Size(249, 29);
            this.NumUpSmooth.TabIndex = 35;
            this.NumUpSmooth.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // DpfDataPanel
            // 
            this.DpfDataPanel.Location = new System.Drawing.Point(278, 209);
            this.DpfDataPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DpfDataPanel.Name = "DpfDataPanel";
            this.DpfDataPanel.Size = new System.Drawing.Size(994, 444);
            this.DpfDataPanel.TabIndex = 34;
            // 
            // FileDataPanel
            // 
            this.FileDataPanel.Location = new System.Drawing.Point(278, 5);
            this.FileDataPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FileDataPanel.Name = "FileDataPanel";
            this.FileDataPanel.Size = new System.Drawing.Size(994, 180);
            this.FileDataPanel.TabIndex = 33;
            // 
            // NumUpIdent
            // 
            this.NumUpIdent.DecimalPlaces = 2;
            this.NumUpIdent.Location = new System.Drawing.Point(144, 356);
            this.NumUpIdent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumUpIdent.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.NumUpIdent.Name = "NumUpIdent";
            this.NumUpIdent.Size = new System.Drawing.Size(118, 29);
            this.NumUpIdent.TabIndex = 32;
            this.NumUpIdent.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // CalculateRequencyRatios
            // 
            this.CalculateRequencyRatios.Location = new System.Drawing.Point(14, 301);
            this.CalculateRequencyRatios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CalculateRequencyRatios.Name = "CalculateRequencyRatios";
            this.CalculateRequencyRatios.Size = new System.Drawing.Size(251, 47);
            this.CalculateRequencyRatios.TabIndex = 31;
            this.CalculateRequencyRatios.Text = "Result";
            this.CalculateRequencyRatios.UseVisualStyleBackColor = true;
            this.CalculateRequencyRatios.Click += new System.EventHandler(this.CalculateRequencyRatios_Click);
            // 
            // NumUpTimeRange
            // 
            this.NumUpTimeRange.DecimalPlaces = 3;
            this.NumUpTimeRange.Location = new System.Drawing.Point(144, 50);
            this.NumUpTimeRange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumUpTimeRange.Name = "NumUpTimeRange";
            this.NumUpTimeRange.Size = new System.Drawing.Size(118, 29);
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
            this.NumUpTimeStart.Location = new System.Drawing.Point(14, 50);
            this.NumUpTimeStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumUpTimeStart.Name = "NumUpTimeStart";
            this.NumUpTimeStart.Size = new System.Drawing.Size(118, 29);
            this.NumUpTimeStart.TabIndex = 29;
            this.NumUpTimeStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.learnNetwork);
            this.tabPage2.Controls.Add(this.openNetwork);
            this.tabPage2.Controls.Add(this.activationSelector);
            this.tabPage2.Controls.Add(this.algoritmSelector);
            this.tabPage2.Controls.Add(this.layerSelector);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.predictGet);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1278, 662);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "NeuronNetwork";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1045, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Функция активации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1046, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Алгоритм обучения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(793, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Количество слоёв";
            // 
            // learnNetwork
            // 
            this.learnNetwork.Location = new System.Drawing.Point(118, 327);
            this.learnNetwork.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.learnNetwork.Name = "learnNetwork";
            this.learnNetwork.Size = new System.Drawing.Size(160, 30);
            this.learnNetwork.TabIndex = 20;
            this.learnNetwork.Text = "Обучить";
            this.learnNetwork.UseVisualStyleBackColor = true;
            this.learnNetwork.Click += new System.EventHandler(this.learnNetwork_Click);
            // 
            // openNetwork
            // 
            this.openNetwork.Location = new System.Drawing.Point(1036, 231);
            this.openNetwork.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.openNetwork.Name = "openNetwork";
            this.openNetwork.Size = new System.Drawing.Size(180, 70);
            this.openNetwork.TabIndex = 19;
            this.openNetwork.Text = "Открыть файл готовой сети";
            this.openNetwork.UseVisualStyleBackColor = true;
            // 
            // activationSelector
            // 
            this.activationSelector.FormattingEnabled = true;
            this.activationSelector.Items.AddRange(new object[] {
            "BipolarSigmoidFunction",
            "SigmoidFunction",
            "ThresholdFunction"});
            this.activationSelector.Location = new System.Drawing.Point(998, 167);
            this.activationSelector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.activationSelector.Name = "activationSelector";
            this.activationSelector.Size = new System.Drawing.Size(248, 29);
            this.activationSelector.TabIndex = 18;
            // 
            // algoritmSelector
            // 
            this.algoritmSelector.FormattingEnabled = true;
            this.algoritmSelector.Items.AddRange(new object[] {
            "BackPropagationLearning",
            "DeltaRuleLearning",
            "PerceptronLearning",
            "ResilientBackpropagationLearning"});
            this.algoritmSelector.Location = new System.Drawing.Point(998, 104);
            this.algoritmSelector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.algoritmSelector.Name = "algoritmSelector";
            this.algoritmSelector.Size = new System.Drawing.Size(248, 29);
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
            this.layerSelector.Location = new System.Drawing.Point(763, 104);
            this.layerSelector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layerSelector.Name = "layerSelector";
            this.layerSelector.Size = new System.Drawing.Size(209, 29);
            this.layerSelector.TabIndex = 16;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(60, 39);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(620, 221);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // predictGet
            // 
            this.predictGet.Location = new System.Drawing.Point(468, 327);
            this.predictGet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.predictGet.Name = "predictGet";
            this.predictGet.Size = new System.Drawing.Size(180, 30);
            this.predictGet.TabIndex = 15;
            this.predictGet.Text = "Test NN";
            this.predictGet.UseVisualStyleBackColor = true;
            // 
            // SoundAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 701);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button predictGet;
    }
}

