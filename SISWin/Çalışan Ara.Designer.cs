namespace SISWin
{
    partial class Çalışan_Ara
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblAyrac = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstCalisanlar = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(414, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadı:";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAd.Location = new System.Drawing.Point(555, 40);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(166, 34);
            this.txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyad.Location = new System.Drawing.Point(555, 87);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(166, 34);
            this.txtSoyad.TabIndex = 4;
            // 
            // lblAyrac
            // 
            this.lblAyrac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAyrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyrac.Location = new System.Drawing.Point(365, 214);
            this.lblAyrac.Name = "lblAyrac";
            this.lblAyrac.Size = new System.Drawing.Size(388, 2);
            this.lblAyrac.TabIndex = 5;
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.Location = new System.Drawing.Point(586, 150);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(135, 39);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Çalışanlar";
            // 
            // lstCalisanlar
            // 
            this.lstCalisanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCalisanlar.FormattingEnabled = true;
            this.lstCalisanlar.ItemHeight = 29;
            this.lstCalisanlar.Location = new System.Drawing.Point(365, 257);
            this.lstCalisanlar.Name = "lstCalisanlar";
            this.lstCalisanlar.ScrollAlwaysVisible = true;
            this.lstCalisanlar.Size = new System.Drawing.Size(356, 207);
            this.lstCalisanlar.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SISWin.Properties.Resources.hastane;
            this.pictureBox1.Location = new System.Drawing.Point(52, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Çalışan_Ara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 476);
            this.Controls.Add(this.lstCalisanlar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.lblAyrac);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Çalışan_Ara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışan Ara";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblAyrac;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstCalisanlar;
    }
}