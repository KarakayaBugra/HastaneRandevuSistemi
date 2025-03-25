namespace SISWin
{
    partial class FormSeansYonetimii
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAyrac = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSeanslar = new System.Windows.Forms.ListBox();
            this.linkSeanEkle = new System.Windows.Forms.LinkLabel();
            this.linkSeansIptalEt = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SISWin.Properties.Resources.hastane;
            this.pictureBox1.Location = new System.Drawing.Point(51, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Uzman:";
            // 
            // lblAyrac
            // 
            this.lblAyrac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAyrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyrac.Location = new System.Drawing.Point(423, 116);
            this.lblAyrac.Name = "lblAyrac";
            this.lblAyrac.Size = new System.Drawing.Size(444, 2);
            this.lblAyrac.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Seanslar";
            // 
            // lstSeanslar
            // 
            this.lstSeanslar.FormattingEnabled = true;
            this.lstSeanslar.ItemHeight = 16;
            this.lstSeanslar.Location = new System.Drawing.Point(446, 178);
            this.lstSeanslar.Name = "lstSeanslar";
            this.lstSeanslar.ScrollAlwaysVisible = true;
            this.lstSeanslar.Size = new System.Drawing.Size(475, 260);
            this.lstSeanslar.TabIndex = 30;
            // 
            // linkSeanEkle
            // 
            this.linkSeanEkle.AutoSize = true;
            this.linkSeanEkle.Location = new System.Drawing.Point(815, 149);
            this.linkSeanEkle.Name = "linkSeanEkle";
            this.linkSeanEkle.Size = new System.Drawing.Size(106, 16);
            this.linkSeanEkle.TabIndex = 31;
            this.linkSeanEkle.TabStop = true;
            this.linkSeanEkle.Text = "Yeni Seans Ekle";
            // 
            // linkSeansIptalEt
            // 
            this.linkSeansIptalEt.AutoSize = true;
            this.linkSeansIptalEt.Location = new System.Drawing.Point(793, 450);
            this.linkSeansIptalEt.Name = "linkSeansIptalEt";
            this.linkSeansIptalEt.Size = new System.Drawing.Size(128, 16);
            this.linkSeansIptalEt.TabIndex = 32;
            this.linkSeansIptalEt.TabStop = true;
            this.linkSeansIptalEt.Text = "Seçili Seansı İptal Et";
            // 
            // FormSeansYonetimii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 503);
            this.Controls.Add(this.linkSeansIptalEt);
            this.Controls.Add(this.linkSeanEkle);
            this.Controls.Add(this.lstSeanslar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAyrac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSeansYonetimii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seans Yönetimi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAyrac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSeanslar;
        private System.Windows.Forms.LinkLabel linkSeanEkle;
        private System.Windows.Forms.LinkLabel linkSeansIptalEt;
    }
}