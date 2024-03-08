namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea25 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend25 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StartButton = new System.Windows.Forms.Button();
            this.inputHeight = new System.Windows.Forms.Label();
            this.inputSpeed = new System.Windows.Forms.Label();
            this.inputSize = new System.Windows.Forms.Label();
            this.inputWeight = new System.Windows.Forms.Label();
            this.InputAngle = new System.Windows.Forms.Label();
            this.inputHeightBox = new System.Windows.Forms.NumericUpDown();
            this.inputSpeedBox = new System.Windows.Forms.NumericUpDown();
            this.inputSizeBox = new System.Windows.Forms.NumericUpDown();
            this.inputWeightBox = new System.Windows.Forms.NumericUpDown();
            this.inputAngleBox = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.StepLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inputHeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSpeedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputWeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAngleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(29, 324);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Начать";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // inputHeight
            // 
            this.inputHeight.AutoSize = true;
            this.inputHeight.Location = new System.Drawing.Point(21, 26);
            this.inputHeight.Name = "inputHeight";
            this.inputHeight.Size = new System.Drawing.Size(102, 13);
            this.inputHeight.TabIndex = 1;
            this.inputHeight.Text = "Начальная высота";
            // 
            // inputSpeed
            // 
            this.inputSpeed.AutoSize = true;
            this.inputSpeed.Location = new System.Drawing.Point(21, 79);
            this.inputSpeed.Name = "inputSpeed";
            this.inputSpeed.Size = new System.Drawing.Size(112, 13);
            this.inputSpeed.TabIndex = 2;
            this.inputSpeed.Text = "Начальная скорость";
            this.inputSpeed.Click += new System.EventHandler(this.label2_Click);
            // 
            // inputSize
            // 
            this.inputSize.AutoSize = true;
            this.inputSize.Location = new System.Drawing.Point(26, 141);
            this.inputSize.Name = "inputSize";
            this.inputSize.Size = new System.Drawing.Size(72, 13);
            this.inputSize.TabIndex = 3;
            this.inputSize.Text = "Размер тела";
            // 
            // inputWeight
            // 
            this.inputWeight.AutoSize = true;
            this.inputWeight.Location = new System.Drawing.Point(26, 208);
            this.inputWeight.Name = "inputWeight";
            this.inputWeight.Size = new System.Drawing.Size(66, 13);
            this.inputWeight.TabIndex = 4;
            this.inputWeight.Text = "Масса тела";
            // 
            // InputAngle
            // 
            this.InputAngle.AutoSize = true;
            this.InputAngle.Location = new System.Drawing.Point(26, 261);
            this.InputAngle.Name = "InputAngle";
            this.InputAngle.Size = new System.Drawing.Size(89, 13);
            this.InputAngle.TabIndex = 5;
            this.InputAngle.Text = "Начальный угол";
            // 
            // inputHeightBox
            // 
            this.inputHeightBox.Location = new System.Drawing.Point(24, 47);
            this.inputHeightBox.Name = "inputHeightBox";
            this.inputHeightBox.Size = new System.Drawing.Size(120, 20);
            this.inputHeightBox.TabIndex = 6;
            // 
            // inputSpeedBox
            // 
            this.inputSpeedBox.Location = new System.Drawing.Point(24, 95);
            this.inputSpeedBox.Name = "inputSpeedBox";
            this.inputSpeedBox.Size = new System.Drawing.Size(120, 20);
            this.inputSpeedBox.TabIndex = 7;
            this.inputSpeedBox.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // inputSizeBox
            // 
            this.inputSizeBox.Location = new System.Drawing.Point(24, 157);
            this.inputSizeBox.Name = "inputSizeBox";
            this.inputSizeBox.Size = new System.Drawing.Size(120, 20);
            this.inputSizeBox.TabIndex = 8;
            this.inputSizeBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // inputWeightBox
            // 
            this.inputWeightBox.Location = new System.Drawing.Point(24, 224);
            this.inputWeightBox.Name = "inputWeightBox";
            this.inputWeightBox.Size = new System.Drawing.Size(120, 20);
            this.inputWeightBox.TabIndex = 9;
            this.inputWeightBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // inputAngleBox
            // 
            this.inputAngleBox.Location = new System.Drawing.Point(24, 277);
            this.inputAngleBox.Name = "inputAngleBox";
            this.inputAngleBox.Size = new System.Drawing.Size(120, 20);
            this.inputAngleBox.TabIndex = 10;
            this.inputAngleBox.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // chart1
            // 
            chartArea25.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea25);
            legend25.Name = "123";
            this.chart1.Legends.Add(legend25);
            this.chart1.Location = new System.Drawing.Point(223, 47);
            this.chart1.Name = "chart1";
            series25.BorderWidth = 3;
            series25.ChartArea = "ChartArea1";
            series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series25.Legend = "123";
            series25.Name = "Объект";
            this.chart1.Series.Add(series25);
            this.chart1.Size = new System.Drawing.Size(719, 300);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.HeightLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DistanceLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SpeedLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.StepLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(150, 395);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 211);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(4, 117);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(310, 43);
            this.HeightLabel.TabIndex = 14;
            this.HeightLabel.Text = "Max Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Location = new System.Drawing.Point(4, 69);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(310, 43);
            this.DistanceLabel.TabIndex = 14;
            this.DistanceLabel.Text = "Distance";
            this.DistanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(4, 161);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(310, 48);
            this.SpeedLabel.TabIndex = 15;
            this.SpeedLabel.Text = "Speed at the end point";
            this.SpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StepLabel
            // 
            this.StepLabel.AutoSize = true;
            this.StepLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StepLabel.Location = new System.Drawing.Point(4, 1);
            this.StepLabel.Name = "StepLabel";
            this.StepLabel.Size = new System.Drawing.Size(310, 63);
            this.StepLabel.TabIndex = 13;
            this.StepLabel.Text = "Time Step";
            this.StepLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 638);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.inputAngleBox);
            this.Controls.Add(this.inputWeightBox);
            this.Controls.Add(this.inputSizeBox);
            this.Controls.Add(this.inputSpeedBox);
            this.Controls.Add(this.inputHeightBox);
            this.Controls.Add(this.InputAngle);
            this.Controls.Add(this.inputWeight);
            this.Controls.Add(this.inputSize);
            this.Controls.Add(this.inputSpeed);
            this.Controls.Add(this.inputHeight);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inputHeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSpeedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputWeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAngleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label inputHeight;
        private System.Windows.Forms.Label inputSpeed;
        private System.Windows.Forms.Label inputSize;
        private System.Windows.Forms.Label inputWeight;
        private System.Windows.Forms.Label InputAngle;
        private System.Windows.Forms.NumericUpDown inputHeightBox;
        private System.Windows.Forms.NumericUpDown inputSpeedBox;
        private System.Windows.Forms.NumericUpDown inputSizeBox;
        private System.Windows.Forms.NumericUpDown inputWeightBox;
        private System.Windows.Forms.NumericUpDown inputAngleBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.Label StepLabel;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

