namespace WindowsFormsApplication1
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
            this.Curba1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // Curba1
            // 
            this.Curba1.Location = new System.Drawing.Point(0, 0);
            this.Curba1.Name = "Curba1";
            this.Curba1.Size = new System.Drawing.Size(680, 24);
            this.Curba1.TabIndex = 1;
            this.Curba1.Text = "archivo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 466);
            this.Controls.Add(this.Curba1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Curba1;
            this.Name = "Form1";
            this.Text = "Curba1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Curba1;
    }
}

