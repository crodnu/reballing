namespace leervolt
{
    partial class MainProgramForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProgramForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.exitButton = new System.Windows.Forms.Button();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.controlTemperatureLabel = new System.Windows.Forms.Label();
            this.arduinoPort = new System.IO.Ports.SerialPort(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.runningIndicator = new System.Windows.Forms.PictureBox();
            this.sendDataButton = new System.Windows.Forms.Button();
            this.temperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.selectChipButton = new System.Windows.Forms.Button();
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
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ReballingButtonsControl = new System.Windows.Forms.GroupBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.preheatDurationLabel = new System.Windows.Forms.Label();
            this.soakDurationLabel = new System.Windows.Forms.Label();
            this.reflowDurationLabel = new System.Windows.Forms.Label();
            this.coolingDurationLabel = new System.Windows.Forms.Label();
            this.soakTemperatureLabel = new System.Windows.Forms.Label();
            this.reflowTemperatureLabel = new System.Windows.Forms.Label();
            this.damageTemperatureLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.preheatProgressBar = new leervolt.ColorProgressBar();
            this.soakProgressBar = new leervolt.ColorProgressBar();
            this.reflowProgressBar = new leervolt.ColorProgressBar();
            this.coolingProgressBar = new leervolt.ColorProgressBar();
            this.emergencyCoolingButton = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            this.ReballingButtonsControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.controlTemperatureLabel.Size = new System.Drawing.Size(237, 57);
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
            this.startButton.Location = new System.Drawing.Point(6, 13);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(88, 76);
            this.startButton.TabIndex = 7;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pauseButton.Image = ((System.Drawing.Image)(resources.GetObject("pauseButton.Image")));
            this.pauseButton.Location = new System.Drawing.Point(100, 13);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(88, 76);
            this.pauseButton.TabIndex = 8;
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // runningIndicator
            // 
            this.runningIndicator.BackColor = System.Drawing.Color.White;
            this.runningIndicator.Image = ((System.Drawing.Image)(resources.GetObject("runningIndicator.Image")));
            this.runningIndicator.Location = new System.Drawing.Point(312, 13);
            this.runningIndicator.Name = "runningIndicator";
            this.runningIndicator.Size = new System.Drawing.Size(75, 76);
            this.runningIndicator.TabIndex = 9;
            this.runningIndicator.TabStop = false;
            this.runningIndicator.Visible = false;
            this.runningIndicator.WaitOnLoad = true;
            // 
            // sendDataButton
            // 
            this.sendDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendDataButton.Location = new System.Drawing.Point(12, 550);
            this.sendDataButton.Name = "sendDataButton";
            this.sendDataButton.Size = new System.Drawing.Size(158, 29);
            this.sendDataButton.TabIndex = 20;
            this.sendDataButton.Text = "Enviar";
            this.sendDataButton.UseVisualStyleBackColor = true;
            this.sendDataButton.Visible = false;
            this.sendDataButton.Click += new System.EventHandler(this.sendDataButton_Click);
            // 
            // temperatureChart
            // 
            chartArea2.Name = "ChartArea1";
            this.temperatureChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.temperatureChart.Legends.Add(legend2);
            this.temperatureChart.Location = new System.Drawing.Point(274, 234);
            this.temperatureChart.Name = "temperatureChart";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series10.Color = System.Drawing.Color.DarkTurquoise;
            series10.Legend = "Legend1";
            series10.Name = "Temperatura de enfriamiento";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series11.Color = System.Drawing.Color.Red;
            series11.Legend = "Legend1";
            series11.Name = "Temperatura de fundición";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series12.Color = System.Drawing.Color.Goldenrod;
            series12.Legend = "Legend1";
            series12.Name = "Temperatura de activación";
            series13.BorderWidth = 4;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series13.Color = System.Drawing.Color.DarkOliveGreen;
            series13.LabelBorderWidth = 3;
            series13.Legend = "Legend1";
            series13.Name = "Temperatura de precalentamiento";
            series13.YValuesPerPoint = 3;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series14.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            series14.Legend = "Legend1";
            series14.Name = "Enfriamiento de emergencia";
            series15.BorderWidth = 4;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Color = System.Drawing.Color.PaleGreen;
            series15.Legend = "Legend1";
            series15.Name = "Sonda de abajo";
            series16.BorderWidth = 4;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Color = System.Drawing.Color.Blue;
            series16.Legend = "Legend1";
            series16.Name = "Sonda de arriba";
            series17.BorderWidth = 5;
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series17.Color = System.Drawing.Color.DarkOrchid;
            series17.Legend = "Legend1";
            series17.Name = "Curva del chip";
            series18.ChartArea = "ChartArea1";
            series18.Color = System.Drawing.Color.Transparent;
            series18.IsVisibleInLegend = false;
            series18.Legend = "Legend1";
            series18.Name = "dummy";
            this.temperatureChart.Series.Add(series10);
            this.temperatureChart.Series.Add(series11);
            this.temperatureChart.Series.Add(series12);
            this.temperatureChart.Series.Add(series13);
            this.temperatureChart.Series.Add(series14);
            this.temperatureChart.Series.Add(series15);
            this.temperatureChart.Series.Add(series16);
            this.temperatureChart.Series.Add(series17);
            this.temperatureChart.Series.Add(series18);
            this.temperatureChart.Size = new System.Drawing.Size(884, 393);
            this.temperatureChart.TabIndex = 27;
            this.temperatureChart.Text = "chart1";
            // 
            // selectChipButton
            // 
            this.selectChipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectChipButton.Location = new System.Drawing.Point(12, 596);
            this.selectChipButton.Name = "selectChipButton";
            this.selectChipButton.Size = new System.Drawing.Size(158, 31);
            this.selectChipButton.TabIndex = 31;
            this.selectChipButton.Text = "Seleccionar chip";
            this.selectChipButton.UseVisualStyleBackColor = true;
            this.selectChipButton.Click += new System.EventHandler(this.selectChipButton_Click);
            // 
            // lowerProbeTemperature
            // 
            this.lowerProbeTemperature.BackColor = System.Drawing.Color.LightGreen;
            this.lowerProbeTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowerProbeTemperature.CausesValidation = false;
            this.lowerProbeTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerProbeTemperature.ForeColor = System.Drawing.Color.Black;
            this.lowerProbeTemperature.Location = new System.Drawing.Point(244, 42);
            this.lowerProbeTemperature.Name = "lowerProbeTemperature";
            this.lowerProbeTemperature.Size = new System.Drawing.Size(243, 57);
            this.lowerProbeTemperature.TabIndex = 6;
            // 
            // upperProbeTemperature
            // 
            this.upperProbeTemperature.BackColor = System.Drawing.Color.LightSkyBlue;
            this.upperProbeTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upperProbeTemperature.CausesValidation = false;
            this.upperProbeTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperProbeTemperature.ForeColor = System.Drawing.Color.Black;
            this.upperProbeTemperature.Location = new System.Drawing.Point(491, 42);
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
            this.stopButton.Location = new System.Drawing.Point(194, 13);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(88, 76);
            this.stopButton.TabIndex = 62;
            this.stopButton.UseVisualStyleBackColor = true;
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
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(1097, 382);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(75, 70);
            this.pictureBox13.TabIndex = 69;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Visible = false;
            this.pictureBox13.WaitOnLoad = true;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(1097, 382);
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
            this.pictureBox16.Location = new System.Drawing.Point(1097, 382);
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
            // ReballingButtonsControl
            // 
            this.ReballingButtonsControl.Controls.Add(this.stopButton);
            this.ReballingButtonsControl.Controls.Add(this.runningIndicator);
            this.ReballingButtonsControl.Controls.Add(this.pauseButton);
            this.ReballingButtonsControl.Controls.Add(this.startButton);
            this.ReballingButtonsControl.Enabled = false;
            this.ReballingButtonsControl.Location = new System.Drawing.Point(9, 107);
            this.ReballingButtonsControl.Name = "ReballingButtonsControl";
            this.ReballingButtonsControl.Size = new System.Drawing.Size(393, 95);
            this.ReballingButtonsControl.TabIndex = 75;
            this.ReballingButtonsControl.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(1097, 382);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(75, 70);
            this.pictureBox14.TabIndex = 70;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Visible = false;
            this.pictureBox14.WaitOnLoad = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 16);
            this.label7.TabIndex = 78;
            this.label7.Text = "Tiempo de precalentamiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 79;
            this.label2.Text = "Tiempo de activación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 16);
            this.label6.TabIndex = 80;
            this.label6.Text = "Tiempo de fundición";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 16);
            this.label8.TabIndex = 81;
            this.label8.Text = "Tiempo de enfriamiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 16);
            this.label9.TabIndex = 82;
            this.label9.Text = "Temperatura de activacion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 16);
            this.label10.TabIndex = 83;
            this.label10.Text = "Temperatura de fundición";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 494);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 16);
            this.label11.TabIndex = 84;
            this.label11.Text = "Temperatura de daño";
            // 
            // preheatDurationLabel
            // 
            this.preheatDurationLabel.AutoSize = true;
            this.preheatDurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preheatDurationLabel.Location = new System.Drawing.Point(236, 276);
            this.preheatDurationLabel.Name = "preheatDurationLabel";
            this.preheatDurationLabel.Size = new System.Drawing.Size(30, 16);
            this.preheatDurationLabel.TabIndex = 85;
            this.preheatDurationLabel.Text = "n/a";
            // 
            // soakDurationLabel
            // 
            this.soakDurationLabel.AutoSize = true;
            this.soakDurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soakDurationLabel.Location = new System.Drawing.Point(236, 303);
            this.soakDurationLabel.Name = "soakDurationLabel";
            this.soakDurationLabel.Size = new System.Drawing.Size(30, 16);
            this.soakDurationLabel.TabIndex = 86;
            this.soakDurationLabel.Text = "n/a";
            // 
            // reflowDurationLabel
            // 
            this.reflowDurationLabel.AutoSize = true;
            this.reflowDurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflowDurationLabel.Location = new System.Drawing.Point(236, 330);
            this.reflowDurationLabel.Name = "reflowDurationLabel";
            this.reflowDurationLabel.Size = new System.Drawing.Size(30, 16);
            this.reflowDurationLabel.TabIndex = 87;
            this.reflowDurationLabel.Text = "n/a";
            // 
            // coolingDurationLabel
            // 
            this.coolingDurationLabel.AutoSize = true;
            this.coolingDurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coolingDurationLabel.Location = new System.Drawing.Point(236, 356);
            this.coolingDurationLabel.Name = "coolingDurationLabel";
            this.coolingDurationLabel.Size = new System.Drawing.Size(30, 16);
            this.coolingDurationLabel.TabIndex = 88;
            this.coolingDurationLabel.Text = "n/a";
            // 
            // soakTemperatureLabel
            // 
            this.soakTemperatureLabel.AutoSize = true;
            this.soakTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soakTemperatureLabel.Location = new System.Drawing.Point(236, 408);
            this.soakTemperatureLabel.Name = "soakTemperatureLabel";
            this.soakTemperatureLabel.Size = new System.Drawing.Size(30, 16);
            this.soakTemperatureLabel.TabIndex = 89;
            this.soakTemperatureLabel.Text = "n/a";
            // 
            // reflowTemperatureLabel
            // 
            this.reflowTemperatureLabel.AutoSize = true;
            this.reflowTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflowTemperatureLabel.Location = new System.Drawing.Point(236, 436);
            this.reflowTemperatureLabel.Name = "reflowTemperatureLabel";
            this.reflowTemperatureLabel.Size = new System.Drawing.Size(30, 16);
            this.reflowTemperatureLabel.TabIndex = 90;
            this.reflowTemperatureLabel.Text = "n/a";
            // 
            // damageTemperatureLabel
            // 
            this.damageTemperatureLabel.AutoSize = true;
            this.damageTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damageTemperatureLabel.Location = new System.Drawing.Point(236, 494);
            this.damageTemperatureLabel.Name = "damageTemperatureLabel";
            this.damageTemperatureLabel.Size = new System.Drawing.Size(30, 16);
            this.damageTemperatureLabel.TabIndex = 91;
            this.damageTemperatureLabel.Text = "n/a";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(719, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 16);
            this.label12.TabIndex = 95;
            this.label12.Text = "Fase de enfriamiento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(719, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 16);
            this.label13.TabIndex = 94;
            this.label13.Text = "Fase de fundición";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(719, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 16);
            this.label14.TabIndex = 93;
            this.label14.Text = "Fase de activación";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(719, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(189, 16);
            this.label15.TabIndex = 92;
            this.label15.Text = "Fase de precalentamiento";
            // 
            // preheatProgressBar
            // 
            this.preheatProgressBar.Location = new System.Drawing.Point(914, 55);
            this.preheatProgressBar.Name = "preheatProgressBar";
            this.preheatProgressBar.Size = new System.Drawing.Size(151, 23);
            this.preheatProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.preheatProgressBar.TabIndex = 96;
            // 
            // soakProgressBar
            // 
            this.soakProgressBar.Location = new System.Drawing.Point(914, 89);
            this.soakProgressBar.Name = "soakProgressBar";
            this.soakProgressBar.Size = new System.Drawing.Size(151, 23);
            this.soakProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.soakProgressBar.TabIndex = 97;
            // 
            // reflowProgressBar
            // 
            this.reflowProgressBar.Location = new System.Drawing.Point(914, 124);
            this.reflowProgressBar.Name = "reflowProgressBar";
            this.reflowProgressBar.Size = new System.Drawing.Size(151, 23);
            this.reflowProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.reflowProgressBar.TabIndex = 98;
            // 
            // coolingProgressBar
            // 
            this.coolingProgressBar.Location = new System.Drawing.Point(914, 158);
            this.coolingProgressBar.Name = "coolingProgressBar";
            this.coolingProgressBar.Size = new System.Drawing.Size(151, 23);
            this.coolingProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.coolingProgressBar.TabIndex = 99;
            // 
            // emergencyCoolingButton
            // 
            this.emergencyCoolingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emergencyCoolingButton.Location = new System.Drawing.Point(1084, 55);
            this.emergencyCoolingButton.Name = "emergencyCoolingButton";
            this.emergencyCoolingButton.Size = new System.Drawing.Size(88, 126);
            this.emergencyCoolingButton.TabIndex = 100;
            this.emergencyCoolingButton.Text = "Enfriar";
            this.emergencyCoolingButton.UseVisualStyleBackColor = true;
            this.emergencyCoolingButton.Visible = false;
            this.emergencyCoolingButton.Click += new System.EventHandler(this.emergencyCoolingButton_Click);
            // 
            // MainProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1184, 639);
            this.Controls.Add(this.emergencyCoolingButton);
            this.Controls.Add(this.coolingProgressBar);
            this.Controls.Add(this.reflowProgressBar);
            this.Controls.Add(this.soakProgressBar);
            this.Controls.Add(this.preheatProgressBar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.damageTemperatureLabel);
            this.Controls.Add(this.reflowTemperatureLabel);
            this.Controls.Add(this.soakTemperatureLabel);
            this.Controls.Add(this.coolingDurationLabel);
            this.Controls.Add(this.reflowDurationLabel);
            this.Controls.Add(this.soakDurationLabel);
            this.Controls.Add(this.preheatDurationLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ReballingButtonsControl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
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
            this.Controls.Add(this.selectChipButton);
            this.Controls.Add(this.temperatureChart);
            this.Controls.Add(this.sendDataButton);
            this.Controls.Add(this.controlTemperatureLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.lowerFanOnIcon);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainProgramForm";
            this.Text = "MainProgramForm";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            this.ReballingButtonsControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
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
        private System.Windows.Forms.Button sendDataButton;
        public System.Windows.Forms.DataVisualization.Charting.Chart temperatureChart;
        private System.Windows.Forms.Button selectChipButton;
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
        public System.Windows.Forms.PictureBox pictureBox13;
        public System.Windows.Forms.PictureBox pictureBox15;
        public System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox ReballingButtonsControl;
        public System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label preheatDurationLabel;
        private System.Windows.Forms.Label soakDurationLabel;
        private System.Windows.Forms.Label reflowDurationLabel;
        private System.Windows.Forms.Label coolingDurationLabel;
        private System.Windows.Forms.Label soakTemperatureLabel;
        private System.Windows.Forms.Label reflowTemperatureLabel;
        private System.Windows.Forms.Label damageTemperatureLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private ColorProgressBar preheatProgressBar;
        private ColorProgressBar soakProgressBar;
        private ColorProgressBar reflowProgressBar;
        private ColorProgressBar coolingProgressBar;
        private System.Windows.Forms.Button emergencyCoolingButton;
    }
}

