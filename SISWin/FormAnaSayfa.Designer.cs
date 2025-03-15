namespace SISWin
{
    partial class FormAnaSayfa
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mniParolaaDegistir = new System.Windows.Forms.ToolStripMenuItem();
            this.mniParolaSifirla = new System.Windows.Forms.ToolStripMenuItem();
            this.mniUzmanKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSekreterKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCalisanAra = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRandevuYonet = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSeansYonetSekreter = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSeansYonetUzman = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAyrac = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mniParolaDegistir = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsiKullanici = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsiTarih = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsiSaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniMenu,
            this.mniParolaDegistir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1203, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mniMenu
            // 
            this.mniMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniParolaaDegistir,
            this.mniParolaSifirla,
            this.mniUzmanKaydet,
            this.mniSekreterKaydet,
            this.mniCalisanAra,
            this.mniRandevuYonet,
            this.mniSeansYonetSekreter,
            this.mniSeansYonetUzman,
            this.mniAyrac,
            this.mniCikis});
            this.mniMenu.Name = "mniMenu";
            this.mniMenu.Size = new System.Drawing.Size(60, 24);
            this.mniMenu.Text = "&Menü";
            this.mniMenu.Click += new System.EventHandler(this.menüToolStripMenuItem_Click);
            // 
            // mniParolaaDegistir
            // 
            this.mniParolaaDegistir.Name = "mniParolaaDegistir";
            this.mniParolaaDegistir.Size = new System.Drawing.Size(272, 26);
            this.mniParolaaDegistir.Text = "Parola&Değiştir";
            // 
            // mniParolaSifirla
            // 
            this.mniParolaSifirla.Name = "mniParolaSifirla";
            this.mniParolaSifirla.Size = new System.Drawing.Size(272, 26);
            this.mniParolaSifirla.Text = "Par&ola Sıfırla";
            // 
            // mniUzmanKaydet
            // 
            this.mniUzmanKaydet.Name = "mniUzmanKaydet";
            this.mniUzmanKaydet.Size = new System.Drawing.Size(272, 26);
            this.mniUzmanKaydet.Text = "&Uzman Kaydet";
            // 
            // mniSekreterKaydet
            // 
            this.mniSekreterKaydet.Name = "mniSekreterKaydet";
            this.mniSekreterKaydet.Size = new System.Drawing.Size(272, 26);
            this.mniSekreterKaydet.Text = "&Sekreter Kaydet";
            // 
            // mniCalisanAra
            // 
            this.mniCalisanAra.Name = "mniCalisanAra";
            this.mniCalisanAra.Size = new System.Drawing.Size(272, 26);
            this.mniCalisanAra.Text = "Calisan &Ara";
            // 
            // mniRandevuYonet
            // 
            this.mniRandevuYonet.Name = "mniRandevuYonet";
            this.mniRandevuYonet.Size = new System.Drawing.Size(272, 26);
            this.mniRandevuYonet.Text = "&Randevu Yönet";
            // 
            // mniSeansYonetSekreter
            // 
            this.mniSeansYonetSekreter.Name = "mniSeansYonetSekreter";
            this.mniSeansYonetSekreter.Size = new System.Drawing.Size(272, 26);
            this.mniSeansYonetSekreter.Text = "&Seans Yönet";
            // 
            // mniSeansYonetUzman
            // 
            this.mniSeansYonetUzman.Name = "mniSeansYonetUzman";
            this.mniSeansYonetUzman.Size = new System.Drawing.Size(272, 26);
            this.mniSeansYonetUzman.Text = "&Seans Yönet";
            // 
            // mniAyrac
            // 
            this.mniAyrac.Name = "mniAyrac";
            this.mniAyrac.Size = new System.Drawing.Size(272, 26);
            this.mniAyrac.Text = "------------------------------";
            // 
            // mniCikis
            // 
            this.mniCikis.Name = "mniCikis";
            this.mniCikis.Size = new System.Drawing.Size(272, 26);
            this.mniCikis.Text = "&Çıkış";
            // 
            // mniParolaDegistir
            // 
            this.mniParolaDegistir.Name = "mniParolaDegistir";
            this.mniParolaDegistir.Size = new System.Drawing.Size(14, 24);
            this.mniParolaDegistir.Click += new System.EventHandler(this.mniParolaDegistir_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiKullanici,
            this.tsiTarih,
            this.tsiSaat});
            this.statusStrip1.Location = new System.Drawing.Point(0, 435);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1203, 26);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsiKullanici
            // 
            this.tsiKullanici.Name = "tsiKullanici";
            this.tsiKullanici.Size = new System.Drawing.Size(1007, 20);
            this.tsiKullanici.Spring = true;
            this.tsiKullanici.Text = "Tarık Buğra Karakauya(Sistem Yöneticisi)";
            this.tsiKullanici.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // tsiTarih
            // 
            this.tsiTarih.Name = "tsiTarih";
            this.tsiTarih.Size = new System.Drawing.Size(137, 20);
            this.tsiTarih.Text = "14 Mart 2025,Cuma";
            // 
            // tsiSaat
            // 
            this.tsiSaat.Name = "tsiSaat";
            this.tsiSaat.Size = new System.Drawing.Size(44, 20);
            this.tsiSaat.Text = "10.48";
            // 
            // FormAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SISWin.Properties.Resources.unnamed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1203, 461);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAnaSayfa";
            this.Text = "FormAnaSayfa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniMenu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniParolaaDegistir;
        private System.Windows.Forms.ToolStripMenuItem mniParolaDegistir;
        private System.Windows.Forms.ToolStripMenuItem mniParolaSifirla;
        private System.Windows.Forms.ToolStripMenuItem mniUzmanKaydet;
        private System.Windows.Forms.ToolStripMenuItem mniSekreterKaydet;
        private System.Windows.Forms.ToolStripMenuItem mniCalisanAra;
        private System.Windows.Forms.ToolStripMenuItem mniRandevuYonet;
        private System.Windows.Forms.ToolStripMenuItem mniSeansYonetSekreter;
        private System.Windows.Forms.ToolStripMenuItem mniSeansYonetUzman;
        private System.Windows.Forms.ToolStripMenuItem mniAyrac;
        private System.Windows.Forms.ToolStripMenuItem mniCikis;
        private System.Windows.Forms.ToolStripStatusLabel tsiKullanici;
        private System.Windows.Forms.ToolStripStatusLabel tsiTarih;
        private System.Windows.Forms.ToolStripStatusLabel tsiSaat;
    }
}