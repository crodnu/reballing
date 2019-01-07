namespace leervolt
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.exitButton = new System.Windows.Forms.Button();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.controlTemperatureLabel = new System.Windows.Forms.Label();
            this.arduinoPort = new System.IO.Ports.SerialPort(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.runningIndicator = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sendDataButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.temperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.intelButton = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.xBoxButton = new System.Windows.Forms.Button();
            this.otherChipButton = new System.Windows.Forms.Button();
            this.lowerProbeTemperature = new System.Windows.Forms.Label();
            this.upperProbeTemperature = new System.Windows.Forms.Label();
            this.lowerResistanceIcon1 = new System.Windows.Forms.PictureBox();
            this.lowerResistanceIcon2 = new System.Windows.Forms.PictureBox();
            this.lowerResistanceIcon3 = new System.Windows.Forms.PictureBox();
            this.lowerResistanceIcon4 = new System.Windows.Forms.PictureBox();
            this.upperResistanceIcon = new System.Windows.Forms.PictureBox();
            this.upperFanOnIcon = new System.Windows.Forms.PictureBox();
            this.upperFanOffIcon = new System.Windows.Forms.PictureBox();
            this.lowerFanOffIcon = new System.Windows.Forms.PictureBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.lowerFanOnIcon = new System.Windows.Forms.PictureBox();
            this.idkWhatThisIsLabel1 = new System.Windows.Forms.Label();
            this.idkWhatThisIsLabel2 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.runningIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerResistanceIcon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerResistanceIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerResistanceIcon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerResistanceIcon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperResistanceIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperFanOnIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperFanOffIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerFanOffIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerFanOnIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(735, 7);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(88, 35);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Salir";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // portComboBox
            // 
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(578, 9);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(126, 21);
            this.portComboBox.TabIndex = 1;
            this.portComboBox.Visible = false;
            this.portComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccionar el puerto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 20);
            this.label3.TabIndex = 4;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // controlTemperatureLabel
            // 
            this.controlTemperatureLabel.BackColor = System.Drawing.Color.Red;
            this.controlTemperatureLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlTemperatureLabel.ForeColor = System.Drawing.Color.White;
            this.controlTemperatureLabel.Location = new System.Drawing.Point(1, 42);
            this.controlTemperatureLabel.Name = "controlTemperatureLabel";
            this.controlTemperatureLabel.Size = new System.Drawing.Size(205, 57);
            this.controlTemperatureLabel.TabIndex = 5;
            // 
            // arduinoPort
            // 
            this.arduinoPort.DtrEnable = true;
            this.arduinoPort.PortName = "COM3";
            this.arduinoPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.arduinoPort_DataReceived);
            // 
            // startButton
            // 
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Image = ((System.Drawing.Image)(resources.GetObject("startButton.Image")));
            this.startButton.Location = new System.Drawing.Point(12, 112);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(88, 76);
            this.startButton.TabIndex = 7;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Visible = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pauseButton.Image = ((System.Drawing.Image)(resources.GetObject("pauseButton.Image")));
            this.pauseButton.Location = new System.Drawing.Point(212, 112);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(88, 76);
            this.pauseButton.TabIndex = 8;
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Visible = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // runningIndicator
            // 
            this.runningIndicator.BackColor = System.Drawing.Color.White;
            this.runningIndicator.Image = ((System.Drawing.Image)(resources.GetObject("runningIndicator.Image")));
            this.runningIndicator.Location = new System.Drawing.Point(123, 117);
            this.runningIndicator.Name = "runningIndicator";
            this.runningIndicator.Size = new System.Drawing.Size(75, 70);
            this.runningIndicator.TabIndex = 9;
            this.runningIndicator.TabStop = false;
            this.runningIndicator.Visible = false;
            this.runningIndicator.WaitOnLoad = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 221);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 247);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(80, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 273);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(80, 20);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 299);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(80, 20);
            this.textBox5.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "T1";
            // 
            // sendDataButton
            // 
            this.sendDataButton.Location = new System.Drawing.Point(12, 369);
            this.sendDataButton.Name = "sendDataButton";
            this.sendDataButton.Size = new System.Drawing.Size(75, 29);
            this.sendDataButton.TabIndex = 20;
            this.sendDataButton.Text = "Enviar";
            this.sendDataButton.UseVisualStyleBackColor = true;
            this.sendDataButton.Visible = false;
            this.sendDataButton.Click += new System.EventHandler(this.sendDataButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "T2";
            // 
            // temperatureChart
            // 
            chartArea1.Name = "ChartArea1";
            this.temperatureChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.temperatureChart.Legends.Add(legend1);
            this.temperatureChart.Location = new System.Drawing.Point(197, 234);
            this.temperatureChart.Name = "temperatureChart";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.LabelBorderWidth = 3;
            series1.Legend = "Legend1";
            series1.Name = "Control";
            series1.YValuesPerPoint = 3;
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.Name = "Sonda de abajo";
            series3.BorderWidth = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "Sonda de arriba";
            this.temperatureChart.Series.Add(series1);
            this.temperatureChart.Series.Add(series2);
            this.temperatureChart.Series.Add(series3);
            this.temperatureChart.Size = new System.Drawing.Size(961, 393);
            this.temperatureChart.TabIndex = 27;
            this.temperatureChart.Text = "chart1";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 419);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 24);
            this.label11.TabIndex = 28;
            this.label11.Text = "Seleccionar curva";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(98, 277);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "T4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "T3";
            // 
            // intelButton
            // 
            this.intelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intelButton.Location = new System.Drawing.Point(40, 463);
            this.intelButton.Name = "intelButton";
            this.intelButton.Size = new System.Drawing.Size(78, 29);
            this.intelButton.TabIndex = 31;
            this.intelButton.Text = "Intel P 4";
            this.intelButton.UseVisualStyleBackColor = true;
            this.intelButton.Click += new System.EventHandler(this.intelButton_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 325);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(80, 20);
            this.textBox6.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Tiempo1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(98, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Tiempo2";
            // 
            // xBoxButton
            // 
            this.xBoxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xBoxButton.Location = new System.Drawing.Point(40, 514);
            this.xBoxButton.Name = "xBoxButton";
            this.xBoxButton.Size = new System.Drawing.Size(78, 29);
            this.xBoxButton.TabIndex = 35;
            this.xBoxButton.Text = "X Box 360";
            this.xBoxButton.UseVisualStyleBackColor = true;
            this.xBoxButton.Click += new System.EventHandler(this.xBoxButton_Click);
            // 
            // otherChipButton
            // 
            this.otherChipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherChipButton.Location = new System.Drawing.Point(40, 569);
            this.otherChipButton.Name = "otherChipButton";
            this.otherChipButton.Size = new System.Drawing.Size(78, 29);
            this.otherChipButton.TabIndex = 36;
            this.otherChipButton.Text = "Curva 3";
            this.otherChipButton.UseVisualStyleBackColor = true;
            this.otherChipButton.Click += new System.EventHandler(this.otherChipButton_Click);
            // 
            // lowerProbeTemperature
            // 
            this.lowerProbeTemperature.BackColor = System.Drawing.Color.LightGreen;
            this.lowerProbeTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowerProbeTemperature.CausesValidation = false;
            this.lowerProbeTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerProbeTemperature.ForeColor = System.Drawing.Color.Black;
            this.lowerProbeTemperature.Location = new System.Drawing.Point(212, 42);
            this.lowerProbeTemperature.Name = "lowerProbeTemperature";
            this.lowerProbeTemperature.Size = new System.Drawing.Size(218, 57);
            this.lowerProbeTemperature.TabIndex = 6;
            // 
            // upperProbeTemperature
            // 
            this.upperProbeTemperature.BackColor = System.Drawing.Color.LightSkyBlue;
            this.upperProbeTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upperProbeTemperature.CausesValidation = false;
            this.upperProbeTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperProbeTemperature.ForeColor = System.Drawing.Color.Black;
            this.upperProbeTemperature.Location = new System.Drawing.Point(436, 42);
            this.upperProbeTemperature.Name = "upperProbeTemperature";
            this.upperProbeTemperature.Size = new System.Drawing.Size(210, 57);
            this.upperProbeTemperature.TabIndex = 7;
            // 
            // lowerResistanceIcon1
            // 
            this.lowerResistanceIcon1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lowerResistanceIcon1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowerResistanceIcon1.Location = new System.Drawing.Point(559, 202);
            this.lowerResistanceIcon1.Name = "lowerResistanceIcon1";
            this.lowerResistanceIcon1.Size = new System.Drawing.Size(31, 19);
            this.lowerResistanceIcon1.TabIndex = 39;
            this.lowerResistanceIcon1.TabStop = false;
            this.lowerResistanceIcon1.Tag = "";
            this.lowerResistanceIcon1.WaitOnLoad = true;
            // 
            // lowerResistanceIcon2
            // 
            this.lowerResistanceIcon2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lowerResistanceIcon2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowerResistanceIcon2.Location = new System.Drawing.Point(596, 202);
            this.lowerResistanceIcon2.Name = "lowerResistanceIcon2";
            this.lowerResistanceIcon2.Size = new System.Drawing.Size(31, 19);
            this.lowerResistanceIcon2.TabIndex = 40;
            this.lowerResistanceIcon2.TabStop = false;
            this.lowerResistanceIcon2.Tag = "g";
            this.lowerResistanceIcon2.WaitOnLoad = true;
            // 
            // lowerResistanceIcon3
            // 
            this.lowerResistanceIcon3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lowerResistanceIcon3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowerResistanceIcon3.Location = new System.Drawing.Point(633, 202);
            this.lowerResistanceIcon3.Name = "lowerResistanceIcon3";
            this.lowerResistanceIcon3.Size = new System.Drawing.Size(31, 19);
            this.lowerResistanceIcon3.TabIndex = 41;
            this.lowerResistanceIcon3.TabStop = false;
            this.lowerResistanceIcon3.Tag = "g";
            this.lowerResistanceIcon3.WaitOnLoad = true;
            // 
            // lowerResistanceIcon4
            // 
            this.lowerResistanceIcon4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lowerResistanceIcon4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowerResistanceIcon4.Location = new System.Drawing.Point(670, 202);
            this.lowerResistanceIcon4.Name = "lowerResistanceIcon4";
            this.lowerResistanceIcon4.Size = new System.Drawing.Size(31, 19);
            this.lowerResistanceIcon4.TabIndex = 42;
            this.lowerResistanceIcon4.TabStop = false;
            this.lowerResistanceIcon4.WaitOnLoad = true;
            // 
            // upperResistanceIcon
            // 
            this.upperResistanceIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.upperResistanceIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upperResistanceIcon.Location = new System.Drawing.Point(596, 128);
            this.upperResistanceIcon.Name = "upperResistanceIcon";
            this.upperResistanceIcon.Size = new System.Drawing.Size(68, 19);
            this.upperResistanceIcon.TabIndex = 43;
            this.upperResistanceIcon.TabStop = false;
            this.upperResistanceIcon.WaitOnLoad = true;
            // 
            // upperFanOnIcon
            // 
            this.upperFanOnIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.upperFanOnIcon.Image = ((System.Drawing.Image)(resources.GetObject("upperFanOnIcon.Image")));
            this.upperFanOnIcon.Location = new System.Drawing.Point(493, 106);
            this.upperFanOnIcon.Name = "upperFanOnIcon";
            this.upperFanOnIcon.Size = new System.Drawing.Size(47, 38);
            this.upperFanOnIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upperFanOnIcon.TabIndex = 45;
            this.upperFanOnIcon.TabStop = false;
            this.upperFanOnIcon.WaitOnLoad = true;
            // 
            // upperFanOffIcon
            // 
            this.upperFanOffIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.upperFanOffIcon.Image = ((System.Drawing.Image)(resources.GetObject("upperFanOffIcon.Image")));
            this.upperFanOffIcon.Location = new System.Drawing.Point(493, 106);
            this.upperFanOffIcon.Name = "upperFanOffIcon";
            this.upperFanOffIcon.Size = new System.Drawing.Size(47, 38);
            this.upperFanOffIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upperFanOffIcon.TabIndex = 60;
            this.upperFanOffIcon.TabStop = false;
            this.upperFanOffIcon.WaitOnLoad = true;
            // 
            // lowerFanOffIcon
            // 
            this.lowerFanOffIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lowerFanOffIcon.Image = ((System.Drawing.Image)(resources.GetObject("lowerFanOffIcon.Image")));
            this.lowerFanOffIcon.Location = new System.Drawing.Point(496, 179);
            this.lowerFanOffIcon.Name = "lowerFanOffIcon";
            this.lowerFanOffIcon.Size = new System.Drawing.Size(47, 38);
            this.lowerFanOffIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lowerFanOffIcon.TabIndex = 61;
            this.lowerFanOffIcon.TabStop = false;
            this.lowerFanOffIcon.WaitOnLoad = true;
            // 
            // stopButton
            // 
            this.stopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.Location = new System.Drawing.Point(306, 112);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(88, 76);
            this.stopButton.TabIndex = 62;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Visible = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // lowerFanOnIcon
            // 
            this.lowerFanOnIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lowerFanOnIcon.Image = ((System.Drawing.Image)(resources.GetObject("lowerFanOnIcon.Image")));
            this.lowerFanOnIcon.Location = new System.Drawing.Point(496, 179);
            this.lowerFanOnIcon.Name = "lowerFanOnIcon";
            this.lowerFanOnIcon.Size = new System.Drawing.Size(47, 38);
            this.lowerFanOnIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lowerFanOnIcon.TabIndex = 63;
            this.lowerFanOnIcon.TabStop = false;
            this.lowerFanOnIcon.WaitOnLoad = true;
            // 
            // idkWhatThisIsLabel1
            // 
            this.idkWhatThisIsLabel1.AutoSize = true;
            this.idkWhatThisIsLabel1.Location = new System.Drawing.Point(811, 218);
            this.idkWhatThisIsLabel1.Name = "idkWhatThisIsLabel1";
            this.idkWhatThisIsLabel1.Size = new System.Drawing.Size(41, 13);
            this.idkWhatThisIsLabel1.TabIndex = 66;
            this.idkWhatThisIsLabel1.Text = "label21";
            // 
            // idkWhatThisIsLabel2
            // 
            this.idkWhatThisIsLabel2.AutoSize = true;
            this.idkWhatThisIsLabel2.Location = new System.Drawing.Point(874, 218);
            this.idkWhatThisIsLabel2.Name = "idkWhatThisIsLabel2";
            this.idkWhatThisIsLabel2.Size = new System.Drawing.Size(41, 13);
            this.idkWhatThisIsLabel2.TabIndex = 67;
            this.idkWhatThisIsLabel2.Text = "label22";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(1083, 9);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(75, 70);
            this.pictureBox13.TabIndex = 69;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Visible = false;
            this.pictureBox13.WaitOnLoad = true;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(1083, 9);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(75, 70);
            this.pictureBox14.TabIndex = 70;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Visible = false;
            this.pictureBox14.WaitOnLoad = true;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(1083, 87);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(75, 70);
            this.pictureBox15.TabIndex = 71;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Visible = false;
            this.pictureBox15.WaitOnLoad = true;
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(1083, 87);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(75, 70);
            this.pictureBox16.TabIndex = 72;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Visible = false;
            this.pictureBox16.WaitOnLoad = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Upper fan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Lower fan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1184, 639);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.idkWhatThisIsLabel2);
            this.Controls.Add(this.idkWhatThisIsLabel1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.lowerFanOffIcon);
            this.Controls.Add(this.upperFanOffIcon);
            this.Controls.Add(this.upperFanOnIcon);
            this.Controls.Add(this.upperResistanceIcon);
            this.Controls.Add(this.lowerResistanceIcon4);
            this.Controls.Add(this.lowerResistanceIcon3);
            this.Controls.Add(this.lowerResistanceIcon2);
            this.Controls.Add(this.lowerResistanceIcon1);
            this.Controls.Add(this.upperProbeTemperature);
            this.Controls.Add(this.lowerProbeTemperature);
            this.Controls.Add(this.otherChipButton);
            this.Controls.Add(this.xBoxButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.intelButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.temperatureChart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sendDataButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.runningIndicator);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.controlTemperatureLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.lowerFanOnIcon);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.runningIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerResistanceIcon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerResistanceIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerResistanceIcon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerResistanceIcon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperResistanceIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperFanOnIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperFanOffIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerFanOffIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerFanOnIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label controlTemperatureLabel;
        private System.IO.Ports.SerialPort arduinoPort;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.PictureBox runningIndicator;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendDataButton;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataVisualization.Charting.Chart temperatureChart;
        private System.Windows.Forms.Button intelButton;
        private System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button xBoxButton;
        private System.Windows.Forms.Button otherChipButton;
        private System.Windows.Forms.Label lowerProbeTemperature;
        private System.Windows.Forms.Label upperProbeTemperature;
        private System.Windows.Forms.PictureBox lowerResistanceIcon4;
        public System.Windows.Forms.PictureBox lowerResistanceIcon1;
        public System.Windows.Forms.PictureBox lowerResistanceIcon2;
        public System.Windows.Forms.PictureBox lowerResistanceIcon3;
        public System.Windows.Forms.PictureBox upperResistanceIcon;
        public System.Windows.Forms.Button stopButton;
        public System.Windows.Forms.PictureBox upperFanOnIcon;
        public System.Windows.Forms.PictureBox upperFanOffIcon;
        public System.Windows.Forms.PictureBox lowerFanOffIcon;
        public System.Windows.Forms.PictureBox lowerFanOnIcon;
        private System.Windows.Forms.Label idkWhatThisIsLabel1;
        private System.Windows.Forms.Label idkWhatThisIsLabel2;
        public System.Windows.Forms.PictureBox pictureBox13;
        public System.Windows.Forms.PictureBox pictureBox14;
        public System.Windows.Forms.PictureBox pictureBox15;
        public System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

