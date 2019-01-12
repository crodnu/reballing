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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectChipDialog));
            this.acceptButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.initialTemperatureTextbox = new System.Windows.Forms.TextBox();
            this.firstPlateauTemperatureTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.secondPlateauTemperatureTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.damageTemperatureTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstPlateauDurationTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.secondPlateauDurationTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chipSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chipNameTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temp1 ";
            // 
            // initialTemperatureTextbox
            // 
            this.initialTemperatureTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialTemperatureTextbox.Location = new System.Drawing.Point(78, 46);
            this.initialTemperatureTextbox.Name = "initialTemperatureTextbox";
            this.initialTemperatureTextbox.Size = new System.Drawing.Size(100, 22);
            this.initialTemperatureTextbox.TabIndex = 2;
            this.initialTemperatureTextbox.Text = "120";
            this.initialTemperatureTextbox.TextChanged += new System.EventHandler(this.updateGraphEventWrapper);
            // 
            // firstPlateauTemperatureTextbox
            // 
            this.firstPlateauTemperatureTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstPlateauTemperatureTextbox.Location = new System.Drawing.Point(74, 81);
            this.firstPlateauTemperatureTextbox.Name = "firstPlateauTemperatureTextbox";
            this.firstPlateauTemperatureTextbox.Size = new System.Drawing.Size(100, 22);
            this.firstPlateauTemperatureTextbox.TabIndex = 4;
            this.firstPlateauTemperatureTextbox.Text = "140";
            this.firstPlateauTemperatureTextbox.TextChanged += new System.EventHandler(this.updateGraphEventWrapper);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temp2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(847, 476);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // secondPlateauTemperatureTextbox
            // 
            this.secondPlateauTemperatureTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondPlateauTemperatureTextbox.Location = new System.Drawing.Point(371, 46);
            this.secondPlateauTemperatureTextbox.Name = "secondPlateauTemperatureTextbox";
            this.secondPlateauTemperatureTextbox.Size = new System.Drawing.Size(100, 22);
            this.secondPlateauTemperatureTextbox.TabIndex = 7;
            this.secondPlateauTemperatureTextbox.Text = "165";
            this.secondPlateauTemperatureTextbox.TextChanged += new System.EventHandler(this.updateGraphEventWrapper);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Temp3";
            // 
            // damageTemperatureTextbox
            // 
            this.damageTemperatureTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damageTemperatureTextbox.Location = new System.Drawing.Point(371, 81);
            this.damageTemperatureTextbox.Name = "damageTemperatureTextbox";
            this.damageTemperatureTextbox.Size = new System.Drawing.Size(100, 22);
            this.damageTemperatureTextbox.TabIndex = 9;
            this.damageTemperatureTextbox.Text = "165";
            this.damageTemperatureTextbox.TextChanged += new System.EventHandler(this.updateGraphEventWrapper);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Temperatura de daño";
            // 
            // firstPlateauDurationTextbox
            // 
            this.firstPlateauDurationTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstPlateauDurationTextbox.Location = new System.Drawing.Point(562, 46);
            this.firstPlateauDurationTextbox.Name = "firstPlateauDurationTextbox";
            this.firstPlateauDurationTextbox.Size = new System.Drawing.Size(100, 22);
            this.firstPlateauDurationTextbox.TabIndex = 11;
            this.firstPlateauDurationTextbox.Text = "0222";
            this.firstPlateauDurationTextbox.TextChanged += new System.EventHandler(this.updateGraphEventWrapper);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(486, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "tiempo1";
            // 
            // secondPlateauDurationTextbox
            // 
            this.secondPlateauDurationTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondPlateauDurationTextbox.Location = new System.Drawing.Point(562, 81);
            this.secondPlateauDurationTextbox.Name = "secondPlateauDurationTextbox";
            this.secondPlateauDurationTextbox.Size = new System.Drawing.Size(100, 22);
            this.secondPlateauDurationTextbox.TabIndex = 13;
            this.secondPlateauDurationTextbox.Text = "0555";
            this.secondPlateauDurationTextbox.TextChanged += new System.EventHandler(this.updateGraphEventWrapper);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(486, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "tiempo2";
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
            this.groupBox1.Controls.Add(this.chipNameTextbox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.secondPlateauDurationTextbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.firstPlateauDurationTextbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.damageTemperatureTextbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.secondPlateauTemperatureTextbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.firstPlateauTemperatureTextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.initialTemperatureTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 501);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 115);
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
            // SelectChipDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 620);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.chipSelectionComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.acceptButton);
            this.Name = "SelectChipDialog";
            this.Text = "SelectChipDialog";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox initialTemperatureTextbox;
        private System.Windows.Forms.TextBox firstPlateauTemperatureTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox secondPlateauTemperatureTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox damageTemperatureTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstPlateauDurationTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox secondPlateauDurationTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox chipSelectionComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox chipNameTextbox;
    }
}