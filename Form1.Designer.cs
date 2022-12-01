namespace Oscilog
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btStartStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btClear = new System.Windows.Forms.Button();
            this.slWindowSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.chartFilter = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.chClear = new System.Windows.Forms.CheckBox();
            this.slTicks = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slWindowSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slTicks)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.slTicks);
            this.splitContainer1.Panel1.Controls.Add(this.chClear);
            this.splitContainer1.Panel1.Controls.Add(this.btStartStop);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cbPort);
            this.splitContainer1.Panel1.Controls.Add(this.chartData);
            this.splitContainer1.Panel1.Controls.Add(this.btClear);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.slWindowSize);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.btSave);
            this.splitContainer1.Panel2.Controls.Add(this.chartFilter);
            this.splitContainer1.Panel2.Controls.Add(this.cbFilter);
            this.splitContainer1.Size = new System.Drawing.Size(610, 398);
            this.splitContainer1.SplitterDistance = 182;
            this.splitContainer1.TabIndex = 13;
            // 
            // btStartStop
            // 
            this.btStartStop.Location = new System.Drawing.Point(120, 8);
            this.btStartStop.Name = "btStartStop";
            this.btStartStop.Size = new System.Drawing.Size(49, 23);
            this.btStartStop.TabIndex = 15;
            this.btStartStop.Text = "Старт";
            this.btStartStop.UseVisualStyleBackColor = true;
            this.btStartStop.Click += new System.EventHandler(this.btStartStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Порт:";
            // 
            // cbPort
            // 
            this.cbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(43, 9);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(71, 21);
            this.cbPort.TabIndex = 13;
            // 
            // chartData
            // 
            this.chartData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea7.Name = "ChartArea1";
            this.chartData.ChartAreas.Add(chartArea7);
            this.chartData.Location = new System.Drawing.Point(11, 34);
            this.chartData.Name = "chartData";
            series7.ChartArea = "ChartArea1";
            series7.Name = "Series1";
            this.chartData.Series.Add(series7);
            this.chartData.Size = new System.Drawing.Size(586, 136);
            this.chartData.TabIndex = 12;
            this.chartData.Text = "chart1";
            // 
            // btClear
            // 
            this.btClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClear.Location = new System.Drawing.Point(522, 8);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 10;
            this.btClear.Text = "Очистить";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // slWindowSize
            // 
            this.slWindowSize.Location = new System.Drawing.Point(305, 3);
            this.slWindowSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.slWindowSize.Name = "slWindowSize";
            this.slWindowSize.Size = new System.Drawing.Size(75, 20);
            this.slWindowSize.TabIndex = 18;
            this.slWindowSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.slWindowSize.ValueChanged += new System.EventHandler(this.slWindowSize_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Окно:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Фильтр:";
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.Location = new System.Drawing.Point(522, 2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 15;
            this.btSave.Text = "В Word...";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // chartFilter
            // 
            this.chartFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea8.Name = "ChartArea1";
            this.chartFilter.ChartAreas.Add(chartArea8);
            this.chartFilter.Location = new System.Drawing.Point(11, 31);
            this.chartFilter.Name = "chartFilter";
            series8.ChartArea = "ChartArea1";
            series8.Name = "Series1";
            this.chartFilter.Series.Add(series8);
            this.chartFilter.Size = new System.Drawing.Size(586, 169);
            this.chartFilter.TabIndex = 14;
            this.chartFilter.Text = "chart2";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Медианный фильтр",
            "Скользящее среднее"});
            this.cbFilter.Location = new System.Drawing.Point(63, 3);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(195, 21);
            this.cbFilter.TabIndex = 13;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // chClear
            // 
            this.chClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chClear.AutoSize = true;
            this.chClear.Location = new System.Drawing.Point(268, 11);
            this.chClear.Name = "chClear";
            this.chClear.Size = new System.Drawing.Size(112, 17);
            this.chClear.TabIndex = 16;
            this.chClear.Text = "очищать каждые";
            this.chClear.UseVisualStyleBackColor = true;
            this.chClear.CheckedChanged += new System.EventHandler(this.chClear_CheckedChanged);
            // 
            // slTicks
            // 
            this.slTicks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.slTicks.Enabled = false;
            this.slTicks.Location = new System.Drawing.Point(386, 9);
            this.slTicks.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.slTicks.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.slTicks.Name = "slTicks";
            this.slTicks.Size = new System.Drawing.Size(74, 20);
            this.slTicks.TabIndex = 17;
            this.slTicks.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "тиков";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 398);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Oscilog - jsbot@ya.ru";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slWindowSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slTicks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btStartStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.NumericUpDown slWindowSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown slTicks;
        private System.Windows.Forms.CheckBox chClear;
    }
}

