using System.Drawing;

namespace leervolt
{
    partial class SelectChipDialog
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.acceptButton = new System.Windows.Forms.Button();
            this.soakTemperatureTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reflowTemperatureTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.damageTemperatureTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.soakDurationTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reflowDurationTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chipSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chipNameTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chipTemperatureGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.preheatDurationTextbox = new System.Windows.Forms.TextBox();
            this.coolingDurationTextbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chipTemperatureGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Location = new System.Drawing.Point(734, 546);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(97, 23);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Aceptar";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // soakTemperatureTextbox
            // 
            this.soakTemperatureTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soakTemperatureTextbox.Location = new System.Drawing.Point(579, 99);
            this.soakTemperatureTextbox.Name = "soakTemperatureTextbox";
            this.soakTemperatureTextbox.Size = new System.Drawing.Size(100, 22);
            this.soakTemperatureTextbox.TabIndex = 4;
            this.soakTemperatureTextbox.Text = "140";
            this.soakTemperatureTextbox.TextChanged += new System.EventHandler(this.updateGraphEventWrapper);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temperatura de activación";
            // 
            // reflowTemperatureTextbox
            // 
            this.reflowTemperatureTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflowTemperatureTextbox.Location = new System.Drawing.Point(579, 127);
            this.reflowTemperatureTextbox.Name = "reflowTemperatureTextbox";
            this.reflowTemperatureTextbox.Size = new System.Drawing.Size(100, 22);
            this.reflowTemperatureTextbox.TabIndex = 7;
            this.reflowTemperatureTextbox.Text = "165";
            this.reflowTemperatureTextbox.TextChanged += new System.EventHandler(this.updateGraphEventWrapper);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Temperatura de fundición";
            // 
            // damageTemperatureTextbox
            // 
            this.damageTemperatureTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damageTemperatureTextbox.Location = new System.Drawing.Point(579, 181);
            this.damageTemperatureTextbox.Name = "damageTemperatureTextbox";
            this.damageTemperatureTextbox.Size = new System.Drawing.Size(100, 22);
            this.damageTemperatureTextbox.TabIndex = 9;
            this.damageTemperatureTextbox.Text = "200";
            this.damageTemperatureTextbox.TextChanged += new System.EventHandler(this.updateGraphEventWrapper);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Temperatura de daño";
            // 
            // soakDurationTextbox
            // 
            this.soakDurationTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soakDurationTextbox.Location = new System.Drawing.Point(224, 96);
            this.soakDurationTextbox.Name = "soakDurationTextbox";
            this.soakDurationTextbox.Size = new System.Drawing.Size(100, 22);
            this.soakDurationTextbox.TabIndex = 11;
            this.soakDurationTextbox.Text = "120";
            this.soakDurationTextbox.TextChanged += new System.EventHandler(this.updateGraphEventWrapper);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tiempo de activación";
            // 
            // reflowDurationTextbox
            // 
            this.reflowDurationTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflowDurationTextbox.Location = new System.Drawing.Point(224, 124);
            this.reflowDurationTextbox.Name = "reflowDurationTextbox";
            this.reflowDurationTextbox.Size = new System.Drawing.Size(100, 22);
            this.reflowDurationTextbox.TabIndex = 13;
            this.reflowDurationTextbox.Text = "60";
            this.reflowDurationTextbox.TextChanged += new System.EventHandler(this.updateGraphEventWrapper);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tiempo de fundición";
            // 
            // chipSelectionComboBox
            // 
            this.chipSelectionComboBox.FormattingEnabled = true;
            this.chipSelectionComboBox.Location = new System.Drawing.Point(723, 501);
            this.chipSelectionComboBox.Name = "chipSelectionComboBox";
            this.chipSelectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.chipSelectionComboBox.TabIndex = 14;
            this.chipSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.chipSelectionComboBox_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(734, 585);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(97, 23);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.coolingDurationTextbox);
            this.groupBox1.Controls.Add(this.preheatDurationTextbox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chipNameTextbox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.reflowDurationTextbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.soakDurationTextbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.damageTemperatureTextbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.reflowTemperatureTextbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.soakTemperatureTextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 501);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 220);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // chipNameTextbox
            // 
            this.chipNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chipNameTextbox.Location = new System.Drawing.Point(276, 18);
            this.chipNameTextbox.Name = "chipNameTextbox";
            this.chipNameTextbox.Size = new System.Drawing.Size(232, 22);
            this.chipNameTextbox.TabIndex = 18;
            this.chipNameTextbox.Text = "Intel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(207, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nombre";
            // 
            // chipTemperatureGraph
            // 
            chartArea2.Name = "ChartArea1";
            this.chipTemperatureGraph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chipTemperatureGraph.Legends.Add(legend2);
            this.chipTemperatureGraph.Location = new System.Drawing.Point(48, 31);
            this.chipTemperatureGraph.Name = "chipTemperatureGraph";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Temperatura";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Temperatura de daño";
            this.chipTemperatureGraph.Series.Add(series3);
            this.chipTemperatureGraph.Series.Add(series4);
            this.chipTemperatureGraph.Size = new System.Drawing.Size(795, 451);
            this.chipTemperatureGraph.TabIndex = 17;
            this.chipTemperatureGraph.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tiempo de precalentamiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tiempo de enfriamiento";
            // 
            // preheatDurationTextbox
            // 
            this.preheatDurationTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preheatDurationTextbox.Location = new System.Drawing.Point(224, 68);
            this.preheatDurationTextbox.Name = "preheatDurationTextbox";
            this.preheatDurationTextbox.Size = new System.Drawing.Size(100, 22);
            this.preheatDurationTextbox.TabIndex = 21;
            this.preheatDurationTextbox.Text = "180";
            this.preheatDurationTextbox.TextChanged += new System.EventHandler(this.updateGraphEventWrapper);
            // 
            // coolingDurationTextbox
            // 
            this.coolingDurationTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coolingDurationTextbox.Location = new System.Drawing.Point(224, 152);
            this.coolingDurationTextbox.Name = "coolingDurationTextbox";
            this.coolingDurationTextbox.Size = new System.Drawing.Size(100, 22);
            this.coolingDurationTextbox.TabIndex = 22;
            this.coolingDurationTextbox.Text = "150";
            this.coolingDurationTextbox.TextChanged += new System.EventHandler(this.updateGraphEventWrapper);
            // 
            // SelectChipDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 733);
            this.ControlBox = false;
            this.Controls.Add(this.chipTemperatureGraph);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.chipSelectionComboBox);
            this.Controls.Add(this.acceptButton);
            this.Name = "SelectChipDialog";
            this.Text = "SelectChipDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chipTemperatureGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.TextBox soakTemperatureTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reflowTemperatureTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox damageTemperatureTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox soakDurationTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox reflowDurationTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox chipSelectionComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox chipNameTextbox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chipTemperatureGraph;
        private System.Windows.Forms.TextBox coolingDurationTextbox;
        private System.Windows.Forms.TextBox preheatDurationTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}