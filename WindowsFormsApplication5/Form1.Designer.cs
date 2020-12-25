namespace WindowsFormsApplication5
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
            this.kalimat = new System.Windows.Forms.Label();
            this.huruf = new System.Windows.Forms.Label();
            this.hasil = new System.Windows.Forms.Label();
            this.perubahan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.inKalimat = new System.Windows.Forms.TextBox();
            this.inHuruf = new System.Windows.Forms.TextBox();
            this.berubah = new System.Windows.Forms.TextBox();
            this.outputLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kalimat
            // 
            this.kalimat.AutoSize = true;
            this.kalimat.Location = new System.Drawing.Point(24, 26);
            this.kalimat.Name = "kalimat";
            this.kalimat.Size = new System.Drawing.Size(88, 13);
            this.kalimat.TabIndex = 0;
            this.kalimat.Text = "Masukan Kalimat";
            // 
            // huruf
            // 
            this.huruf.AutoSize = true;
            this.huruf.Location = new System.Drawing.Point(24, 81);
            this.huruf.Name = "huruf";
            this.huruf.Size = new System.Drawing.Size(80, 13);
            this.huruf.TabIndex = 1;
            this.huruf.Text = "Masukan Huruf";
            // 
            // hasil
            // 
            this.hasil.AutoSize = true;
            this.hasil.Location = new System.Drawing.Point(24, 199);
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(36, 13);
            this.hasil.TabIndex = 2;
            this.hasil.Text = "Hasil :";
            this.hasil.Click += new System.EventHandler(this.hasil_Click);
            // 
            // perubahan
            // 
            this.perubahan.Location = new System.Drawing.Point(162, 141);
            this.perubahan.Name = "perubahan";
            this.perubahan.Size = new System.Drawing.Size(308, 23);
            this.perubahan.TabIndex = 3;
            this.perubahan.Text = "Konversi!";
            this.perubahan.UseVisualStyleBackColor = true;
            this.perubahan.Click += new System.EventHandler(this.perubahan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Menjadi";
            // 
            // inKalimat
            // 
            this.inKalimat.Location = new System.Drawing.Point(162, 26);
            this.inKalimat.Name = "inKalimat";
            this.inKalimat.Size = new System.Drawing.Size(308, 20);
            this.inKalimat.TabIndex = 8;
            // 
            // inHuruf
            // 
            this.inHuruf.Location = new System.Drawing.Point(162, 78);
            this.inHuruf.Name = "inHuruf";
            this.inHuruf.Size = new System.Drawing.Size(84, 20);
            this.inHuruf.TabIndex = 9;
            this.inHuruf.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // berubah
            // 
            this.berubah.Location = new System.Drawing.Point(386, 78);
            this.berubah.Name = "berubah";
            this.berubah.Size = new System.Drawing.Size(84, 20);
            this.berubah.TabIndex = 10;
            this.berubah.TextChanged += new System.EventHandler(this.berubah_TextChanged);
            // 
            // outputLabel1
            // 
            this.outputLabel1.AutoSize = true;
            this.outputLabel1.Location = new System.Drawing.Point(285, 199);
            this.outputLabel1.Name = "outputLabel1";
            this.outputLabel1.Size = new System.Drawing.Size(0, 13);
            this.outputLabel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 261);
            this.Controls.Add(this.outputLabel1);
            this.Controls.Add(this.berubah);
            this.Controls.Add(this.inHuruf);
            this.Controls.Add(this.inKalimat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.perubahan);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.huruf);
            this.Controls.Add(this.kalimat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kalimat;
        private System.Windows.Forms.Label huruf;
        private System.Windows.Forms.Label hasil;
        private System.Windows.Forms.Button perubahan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inKalimat;
        private System.Windows.Forms.TextBox inHuruf;
        private System.Windows.Forms.TextBox berubah;
        private System.Windows.Forms.Label outputLabel1;
    }
}

