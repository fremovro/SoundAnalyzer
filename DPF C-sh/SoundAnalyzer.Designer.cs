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
            this.OpenFilePart = new System.Windows.Forms.Button();
            this.DPF = new System.Windows.Forms.Button();
            this.NumUpTimeStart = new System.Windows.Forms.NumericUpDown();
            this.NumUpTimeRange = new System.Windows.Forms.NumericUpDown();
            this.CalculateRequencyRatios = new System.Windows.Forms.Button();
            this.NumUpIdent = new System.Windows.Forms.NumericUpDown();
            this.FileDataPanel = new System.Windows.Forms.Panel();
            this.DpfDataPanel = new System.Windows.Forms.Panel();
            this.NumUpSmooth = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.NumUpMaxCount = new System.Windows.Forms.NumericUpDown();
            this.ChosenRequency = new System.Windows.Forms.TextBox();
            this.LeftChangeFile = new System.Windows.Forms.Button();
            this.RightChangeFile = new System.Windows.Forms.Button();
            this.ChosenFileName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpTimeStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpTimeRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpIdent)).BeginInit();
            this.DpfDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpSmooth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpMaxCount)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // OpenFilePart
            // 
            this.OpenFilePart.Location = new System.Drawing.Point(12, 6);
            this.OpenFilePart.Name = "OpenFilePart";
            this.OpenFilePart.Size = new System.Drawing.Size(110, 29);
            this.OpenFilePart.TabIndex = 3;
            this.OpenFilePart.Text = "Open file part";
            this.OpenFilePart.UseVisualStyleBackColor = true;
            this.OpenFilePart.Click += new System.EventHandler(this.OpenFilePart_Click);
            // 
            // DPF
            // 
            this.DPF.Location = new System.Drawing.Point(12, 139);
            this.DPF.Name = "DPF";
            this.DPF.Size = new System.Drawing.Size(167, 29);
            this.DPF.TabIndex = 4;
            this.DPF.Text = "DPF";
            this.DPF.UseVisualStyleBackColor = true;
            this.DPF.Click += new System.EventHandler(this.DPF_Click);
            // 
            // NumUpTimeStart
            // 
            this.NumUpTimeStart.DecimalPlaces = 3;
            this.NumUpTimeStart.Location = new System.Drawing.Point(12, 41);
            this.NumUpTimeStart.Name = "NumUpTimeStart";
            this.NumUpTimeStart.Size = new System.Drawing.Size(79, 22);
            this.NumUpTimeStart.TabIndex = 8;
            this.NumUpTimeStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumUpTimeRange
            // 
            this.NumUpTimeRange.DecimalPlaces = 3;
            this.NumUpTimeRange.Location = new System.Drawing.Point(99, 41);
            this.NumUpTimeRange.Name = "NumUpTimeRange";
            this.NumUpTimeRange.Size = new System.Drawing.Size(79, 22);
            this.NumUpTimeRange.TabIndex = 9;
            this.NumUpTimeRange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CalculateRequencyRatios
            // 
            this.CalculateRequencyRatios.Location = new System.Drawing.Point(12, 196);
            this.CalculateRequencyRatios.Name = "CalculateRequencyRatios";
            this.CalculateRequencyRatios.Size = new System.Drawing.Size(167, 29);
            this.CalculateRequencyRatios.TabIndex = 10;
            this.CalculateRequencyRatios.Text = "Result";
            this.CalculateRequencyRatios.UseVisualStyleBackColor = true;
            this.CalculateRequencyRatios.Click += new System.EventHandler(this.CalculateRequencyRatios_Click);
            // 
            // NumUpIdent
            // 
            this.NumUpIdent.DecimalPlaces = 2;
            this.NumUpIdent.Location = new System.Drawing.Point(99, 230);
            this.NumUpIdent.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.NumUpIdent.Name = "NumUpIdent";
            this.NumUpIdent.Size = new System.Drawing.Size(79, 22);
            this.NumUpIdent.TabIndex = 11;
            this.NumUpIdent.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // FileDataPanel
            // 
            this.FileDataPanel.Location = new System.Drawing.Point(188, 6);
            this.FileDataPanel.Name = "FileDataPanel";
            this.FileDataPanel.Size = new System.Drawing.Size(663, 119);
            this.FileDataPanel.TabIndex = 13;
            // 
            // DpfDataPanel
            // 
            this.DpfDataPanel.Location = new System.Drawing.Point(188, 139);
            this.DpfDataPanel.Name = "DpfDataPanel";
            this.DpfDataPanel.Size = new System.Drawing.Size(663, 283);
            this.DpfDataPanel.TabIndex = 14;
            // 
            // NumUpSmooth
            // 
            this.NumUpSmooth.Location = new System.Drawing.Point(12, 173);
            this.NumUpSmooth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumUpSmooth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NumUpSmooth.Name = "NumUpSmooth";
            this.NumUpSmooth.Size = new System.Drawing.Size(166, 22);
            this.NumUpSmooth.TabIndex = 20;
            this.NumUpSmooth.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(127, 14);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "db (!!!)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // NumUpMaxCount
            // 
            this.NumUpMaxCount.Location = new System.Drawing.Point(12, 230);
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
            this.NumUpMaxCount.TabIndex = 22;
            this.NumUpMaxCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // TextBoxRequency
            // 
            this.ChosenRequency.Location = new System.Drawing.Point(12, 258);
            this.ChosenRequency.Multiline = true;
            this.ChosenRequency.Name = "ChosenRequency";
            this.ChosenRequency.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChosenRequency.Size = new System.Drawing.Size(168, 164);
            this.ChosenRequency.TabIndex = 23;
            // 
            // LeftChangeFile
            // 
            this.LeftChangeFile.Location = new System.Drawing.Point(12, 96);
            this.LeftChangeFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LeftChangeFile.Name = "LeftChangeFile";
            this.LeftChangeFile.Size = new System.Drawing.Size(79, 29);
            this.LeftChangeFile.TabIndex = 24;
            this.LeftChangeFile.Text = "<\r\n";
            this.LeftChangeFile.UseVisualStyleBackColor = true;
            this.LeftChangeFile.Click += new System.EventHandler(this.LeftChangeFile_Click);
            // 
            // RightChangeFile
            // 
            this.RightChangeFile.Location = new System.Drawing.Point(99, 96);
            this.RightChangeFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RightChangeFile.Name = "RightChangeFile";
            this.RightChangeFile.Size = new System.Drawing.Size(79, 29);
            this.RightChangeFile.TabIndex = 25;
            this.RightChangeFile.Text = ">";
            this.RightChangeFile.UseVisualStyleBackColor = true;
            this.RightChangeFile.Click += new System.EventHandler(this.RightChangeFile_Click);
            // 
            // ChosenFileName
            // 
            this.ChosenFileName.Location = new System.Drawing.Point(13, 70);
            this.ChosenFileName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChosenFileName.Name = "ChosenFileName";
            this.ChosenFileName.Size = new System.Drawing.Size(166, 22);
            this.ChosenFileName.TabIndex = 26;
            // 
            // SoundAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 434);
            this.Controls.Add(this.LeftChangeFile);
            this.Controls.Add(this.OpenFilePart);
            this.Controls.Add(this.ChosenFileName);
            this.Controls.Add(this.RightChangeFile);
            this.Controls.Add(this.DPF);
            this.Controls.Add(this.ChosenRequency);
            this.Controls.Add(this.NumUpMaxCount);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.NumUpSmooth);
            this.Controls.Add(this.DpfDataPanel);
            this.Controls.Add(this.FileDataPanel);
            this.Controls.Add(this.NumUpIdent);
            this.Controls.Add(this.CalculateRequencyRatios);
            this.Controls.Add(this.NumUpTimeRange);
            this.Controls.Add(this.NumUpTimeStart);
            this.Name = "SoundAnalyzer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SoundAnalyzer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumUpTimeStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpTimeRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpIdent)).EndInit();
            this.DpfDataPanel.ResumeLayout(false);
            this.DpfDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpSmooth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpMaxCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button OpenFilePart;
        private System.Windows.Forms.Button DPF;
        private System.Windows.Forms.NumericUpDown NumUpTimeStart;
        private System.Windows.Forms.NumericUpDown NumUpTimeRange;
        private System.Windows.Forms.Button CalculateRequencyRatios;
        private System.Windows.Forms.NumericUpDown NumUpIdent;
        private System.Windows.Forms.Panel FileDataPanel;
        private System.Windows.Forms.Panel DpfDataPanel;
        private System.Windows.Forms.NumericUpDown NumUpSmooth;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown NumUpMaxCount;
        private System.Windows.Forms.TextBox ChosenRequency;
        private System.Windows.Forms.Button LeftChangeFile;
        private System.Windows.Forms.Button RightChangeFile;
        private System.Windows.Forms.TextBox ChosenFileName;
    }
}

