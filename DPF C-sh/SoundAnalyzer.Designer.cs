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
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpMaxCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpSmooth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpIdent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpTimeRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpTimeStart)).BeginInit();
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1143, 530);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1135, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DPF";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1138, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "NeuronNetwork";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LeftChangeFile
            // 
            this.LeftChangeFile.Location = new System.Drawing.Point(12, 106);
            this.LeftChangeFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LeftChangeFile.Name = "LeftChangeFile";
            this.LeftChangeFile.Size = new System.Drawing.Size(105, 36);
            this.LeftChangeFile.TabIndex = 39;
            this.LeftChangeFile.Text = "<\r\n";
            this.LeftChangeFile.UseVisualStyleBackColor = true;
            this.LeftChangeFile.Click += new System.EventHandler(this.LeftChangeFile_Click);
            // 
            // OpenFilePart
            // 
            this.OpenFilePart.Location = new System.Drawing.Point(12, 4);
            this.OpenFilePart.Margin = new System.Windows.Forms.Padding(4);
            this.OpenFilePart.Name = "OpenFilePart";
            this.OpenFilePart.Size = new System.Drawing.Size(147, 27);
            this.OpenFilePart.TabIndex = 27;
            this.OpenFilePart.Text = "Open file part";
            this.OpenFilePart.UseVisualStyleBackColor = true;
            this.OpenFilePart.Click += new System.EventHandler(this.OpenFilePart_Click);
            // 
            // ChosenFileName
            // 
            this.ChosenFileName.Location = new System.Drawing.Point(13, 74);
            this.ChosenFileName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChosenFileName.Name = "ChosenFileName";
            this.ChosenFileName.Size = new System.Drawing.Size(220, 22);
            this.ChosenFileName.TabIndex = 41;
            // 
            // RightChangeFile
            // 
            this.RightChangeFile.Location = new System.Drawing.Point(128, 106);
            this.RightChangeFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RightChangeFile.Name = "RightChangeFile";
            this.RightChangeFile.Size = new System.Drawing.Size(105, 36);
            this.RightChangeFile.TabIndex = 40;
            this.RightChangeFile.Text = ">";
            this.RightChangeFile.UseVisualStyleBackColor = true;
            this.RightChangeFile.Click += new System.EventHandler(this.RightChangeFile_Click);
            // 
            // DPF
            // 
            this.DPF.Location = new System.Drawing.Point(12, 159);
            this.DPF.Margin = new System.Windows.Forms.Padding(4);
            this.DPF.Name = "DPF";
            this.DPF.Size = new System.Drawing.Size(223, 36);
            this.DPF.TabIndex = 28;
            this.DPF.Text = "DPF";
            this.DPF.UseVisualStyleBackColor = true;
            this.DPF.Click += new System.EventHandler(this.DPF_Click);
            // 
            // ChosenRequency
            // 
            this.ChosenRequency.Location = new System.Drawing.Point(12, 306);
            this.ChosenRequency.Margin = new System.Windows.Forms.Padding(4);
            this.ChosenRequency.Multiline = true;
            this.ChosenRequency.Name = "ChosenRequency";
            this.ChosenRequency.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChosenRequency.Size = new System.Drawing.Size(223, 191);
            this.ChosenRequency.TabIndex = 38;
            // 
            // NumUpMaxCount
            // 
            this.NumUpMaxCount.Location = new System.Drawing.Point(12, 271);
            this.NumUpMaxCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.NumUpMaxCount.Size = new System.Drawing.Size(105, 22);
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
            this.checkBox1.Location = new System.Drawing.Point(168, 8);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 20);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.Text = "db (!!!)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // NumUpSmooth
            // 
            this.NumUpSmooth.Location = new System.Drawing.Point(12, 201);
            this.NumUpSmooth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumUpSmooth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NumUpSmooth.Name = "NumUpSmooth";
            this.NumUpSmooth.Size = new System.Drawing.Size(221, 22);
            this.NumUpSmooth.TabIndex = 35;
            this.NumUpSmooth.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // DpfDataPanel
            // 
            this.DpfDataPanel.Location = new System.Drawing.Point(247, 159);
            this.DpfDataPanel.Margin = new System.Windows.Forms.Padding(4);
            this.DpfDataPanel.Name = "DpfDataPanel";
            this.DpfDataPanel.Size = new System.Drawing.Size(884, 338);
            this.DpfDataPanel.TabIndex = 34;
            // 
            // FileDataPanel
            // 
            this.FileDataPanel.Location = new System.Drawing.Point(247, 4);
            this.FileDataPanel.Margin = new System.Windows.Forms.Padding(4);
            this.FileDataPanel.Name = "FileDataPanel";
            this.FileDataPanel.Size = new System.Drawing.Size(884, 137);
            this.FileDataPanel.TabIndex = 33;
            // 
            // NumUpIdent
            // 
            this.NumUpIdent.DecimalPlaces = 2;
            this.NumUpIdent.Location = new System.Drawing.Point(128, 271);
            this.NumUpIdent.Margin = new System.Windows.Forms.Padding(4);
            this.NumUpIdent.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.NumUpIdent.Name = "NumUpIdent";
            this.NumUpIdent.Size = new System.Drawing.Size(105, 22);
            this.NumUpIdent.TabIndex = 32;
            this.NumUpIdent.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // CalculateRequencyRatios
            // 
            this.CalculateRequencyRatios.Location = new System.Drawing.Point(12, 229);
            this.CalculateRequencyRatios.Margin = new System.Windows.Forms.Padding(4);
            this.CalculateRequencyRatios.Name = "CalculateRequencyRatios";
            this.CalculateRequencyRatios.Size = new System.Drawing.Size(223, 36);
            this.CalculateRequencyRatios.TabIndex = 31;
            this.CalculateRequencyRatios.Text = "Result";
            this.CalculateRequencyRatios.UseVisualStyleBackColor = true;
            this.CalculateRequencyRatios.Click += new System.EventHandler(this.CalculateRequencyRatios_Click);
            // 
            // NumUpTimeRange
            // 
            this.NumUpTimeRange.DecimalPlaces = 3;
            this.NumUpTimeRange.Location = new System.Drawing.Point(128, 38);
            this.NumUpTimeRange.Margin = new System.Windows.Forms.Padding(4);
            this.NumUpTimeRange.Name = "NumUpTimeRange";
            this.NumUpTimeRange.Size = new System.Drawing.Size(105, 22);
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
            this.NumUpTimeStart.Location = new System.Drawing.Point(12, 38);
            this.NumUpTimeStart.Margin = new System.Windows.Forms.Padding(4);
            this.NumUpTimeStart.Name = "NumUpTimeStart";
            this.NumUpTimeStart.Size = new System.Drawing.Size(105, 22);
            this.NumUpTimeStart.TabIndex = 29;
            this.NumUpTimeStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SoundAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 534);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}

