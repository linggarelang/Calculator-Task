namespace CalculatorTask
{
    partial class FormCalculate
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
            this.LabelOperasi = new System.Windows.Forms.Label();
            this.labelNilaiA = new System.Windows.Forms.Label();
            this.LabelNilaiB = new System.Windows.Forms.Label();
            this.TextNilaiA = new System.Windows.Forms.TextBox();
            this.TextNilaiB = new System.Windows.Forms.TextBox();
            this.ButtonHitung = new System.Windows.Forms.Button();
            this.ListOperations = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LabelOperasi
            // 
            this.LabelOperasi.AutoSize = true;
            this.LabelOperasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOperasi.Location = new System.Drawing.Point(12, 26);
            this.LabelOperasi.Name = "LabelOperasi";
            this.LabelOperasi.Size = new System.Drawing.Size(43, 13);
            this.LabelOperasi.TabIndex = 0;
            this.LabelOperasi.Text = "Operasi";
            // 
            // labelNilaiA
            // 
            this.labelNilaiA.AutoSize = true;
            this.labelNilaiA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNilaiA.Location = new System.Drawing.Point(12, 54);
            this.labelNilaiA.Name = "labelNilaiA";
            this.labelNilaiA.Size = new System.Drawing.Size(37, 13);
            this.labelNilaiA.TabIndex = 1;
            this.labelNilaiA.Text = "Nilai A";
            // 
            // LabelNilaiB
            // 
            this.LabelNilaiB.AutoSize = true;
            this.LabelNilaiB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNilaiB.Location = new System.Drawing.Point(12, 80);
            this.LabelNilaiB.Name = "LabelNilaiB";
            this.LabelNilaiB.Size = new System.Drawing.Size(37, 13);
            this.LabelNilaiB.TabIndex = 2;
            this.LabelNilaiB.Text = "Nilai B";
            // 
            // TextNilaiA
            // 
            this.TextNilaiA.Location = new System.Drawing.Point(64, 51);
            this.TextNilaiA.Name = "TextNilaiA";
            this.TextNilaiA.Size = new System.Drawing.Size(147, 20);
            this.TextNilaiA.TabIndex = 3;
            // 
            // TextNilaiB
            // 
            this.TextNilaiB.Location = new System.Drawing.Point(64, 77);
            this.TextNilaiB.Name = "TextNilaiB";
            this.TextNilaiB.Size = new System.Drawing.Size(147, 20);
            this.TextNilaiB.TabIndex = 4;
            // 
            // ButtonHitung
            // 
            this.ButtonHitung.Location = new System.Drawing.Point(12, 113);
            this.ButtonHitung.Name = "ButtonHitung";
            this.ButtonHitung.Size = new System.Drawing.Size(199, 23);
            this.ButtonHitung.TabIndex = 6;
            this.ButtonHitung.Text = "Hitung";
            this.ButtonHitung.UseVisualStyleBackColor = true;
            this.ButtonHitung.Click += new System.EventHandler(this.ButtonHitung_Click);
            // 
            // ListOperations
            // 
            this.ListOperations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListOperations.FormattingEnabled = true;
            this.ListOperations.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ListOperations.Items.AddRange(new object[] {
            "Penjumlahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.ListOperations.Location = new System.Drawing.Point(64, 24);
            this.ListOperations.Name = "ListOperations";
            this.ListOperations.Size = new System.Drawing.Size(147, 21);
            this.ListOperations.TabIndex = 0;
            // 
            // FormCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 158);
            this.Controls.Add(this.ListOperations);
            this.Controls.Add(this.ButtonHitung);
            this.Controls.Add(this.TextNilaiB);
            this.Controls.Add(this.TextNilaiA);
            this.Controls.Add(this.LabelNilaiB);
            this.Controls.Add(this.labelNilaiA);
            this.Controls.Add(this.LabelOperasi);
            this.Name = "FormCalculate";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelOperasi;
        private System.Windows.Forms.Label labelNilaiA;
        private System.Windows.Forms.Label LabelNilaiB;
        private System.Windows.Forms.TextBox TextNilaiA;
        private System.Windows.Forms.TextBox TextNilaiB;
        private System.Windows.Forms.Button ButtonHitung;
        private System.Windows.Forms.ComboBox ListOperations;
    }
}