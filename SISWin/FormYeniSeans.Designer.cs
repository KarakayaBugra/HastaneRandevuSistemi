namespace SISWin
{
    partial class FormYeniSeans
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAyrac = new System.Windows.Forms.Label();
            this.lblUzman = new System.Windows.Forms.Label();
            this.dptTaih = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangicSaati = new System.Windows.Forms.DateTimePicker();
            this.dtpBitisSaati = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SISWin.Properties.Resources.istockphoto_865588942_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(55, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uzman:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 66);
            this.label3.TabIndex = 3;
            this.label3.Text = "Başlangıç Saati:\r\n\r\nBitiş Saati:";
            // 
            // lblAyrac
            // 
            this.lblAyrac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAyrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyrac.Location = new System.Drawing.Point(329, 257);
            this.lblAyrac.Name = "lblAyrac";
            this.lblAyrac.Size = new System.Drawing.Size(444, 2);
            this.lblAyrac.TabIndex = 4;
            // 
            // lblUzman
            // 
            this.lblUzman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUzman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUzman.Location = new System.Drawing.Point(485, 58);
            this.lblUzman.Name = "lblUzman";
            this.lblUzman.Size = new System.Drawing.Size(235, 23);
            this.lblUzman.TabIndex = 5;
            // 
            // dptTaih
            // 
            this.dptTaih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptTaih.Location = new System.Drawing.Point(494, 104);
            this.dptTaih.Name = "dptTaih";
            this.dptTaih.Size = new System.Drawing.Size(200, 22);
            this.dptTaih.TabIndex = 6;
            // 
            // dtpBaslangicSaati
            // 
            this.dtpBaslangicSaati.CustomFormat = "HH:mm";
            this.dtpBaslangicSaati.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBaslangicSaati.Location = new System.Drawing.Point(543, 152);
            this.dtpBaslangicSaati.Name = "dtpBaslangicSaati";
            this.dtpBaslangicSaati.Size = new System.Drawing.Size(200, 22);
            this.dtpBaslangicSaati.TabIndex = 7;
            // 
            // dtpBitisSaati
            // 
            this.dtpBitisSaati.CustomFormat = "HH:mm";
            this.dtpBitisSaati.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBitisSaati.Location = new System.Drawing.Point(543, 196);
            this.dtpBitisSaati.Name = "dtpBitisSaati";
            this.dtpBitisSaati.Size = new System.Drawing.Size(200, 22);
            this.dtpBitisSaati.TabIndex = 8;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(526, 314);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(115, 38);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // FormYeniSeans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dtpBitisSaati);
            this.Controls.Add(this.dtpBaslangicSaati);
            this.Controls.Add(this.dptTaih);
            this.Controls.Add(this.lblUzman);
            this.Controls.Add(this.lblAyrac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormYeniSeans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Kaydet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAyrac;
        private System.Windows.Forms.Label lblUzman;
        private System.Windows.Forms.DateTimePicker dptTaih;
        private System.Windows.Forms.DateTimePicker dtpBaslangicSaati;
        private System.Windows.Forms.DateTimePicker dtpBitisSaati;
        private System.Windows.Forms.Button btnKaydet;
    }
}