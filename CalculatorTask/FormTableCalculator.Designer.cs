namespace CalculatorTask
{
    partial class FormTableCalculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tablesCalculator = new System.Windows.Forms.ListView();
            this.ButtonHitung = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tablesCalculator);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Hasil ]";
            // 
            // tablesCalculator
            // 
            this.tablesCalculator.HideSelection = false;
            this.tablesCalculator.Location = new System.Drawing.Point(6, 19);
            this.tablesCalculator.Name = "tablesCalculator";
            this.tablesCalculator.Size = new System.Drawing.Size(355, 238);
            this.tablesCalculator.TabIndex = 0;
            this.tablesCalculator.UseCompatibleStateImageBehavior = false;
            // 
            // ButtonHitung
            // 
            this.ButtonHitung.Location = new System.Drawing.Point(12, 281);
            this.ButtonHitung.Name = "ButtonHitung";
            this.ButtonHitung.Size = new System.Drawing.Size(367, 23);
            this.ButtonHitung.TabIndex = 1;
            this.ButtonHitung.Text = "Hitung";
            this.ButtonHitung.UseVisualStyleBackColor = true;
            this.ButtonHitung.Click += new System.EventHandler(this.ButtonHitung_Click);
            // 
            // FormTableCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 316);
            this.Controls.Add(this.ButtonHitung);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTableCalculator";
            this.Text = "Hasil Perhitungan";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView tablesCalculator;
        private System.Windows.Forms.Button ButtonHitung;
    }
}