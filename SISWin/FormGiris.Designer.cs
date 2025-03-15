namespace SISWin
{
    partial class FormGiris
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnGir = new System.Windows.Forms.Button();
            this.lblAyrac = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SISWin.Properties.Resources.kilit2;
            this.pictureBox1.Location = new System.Drawing.Point(58, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtKullanici
            // 
            this.txtKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKullanici.Location = new System.Drawing.Point(527, 85);
            this.txtKullanici.Multiline = true;
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(166, 31);
            this.txtKullanici.TabIndex = 3;
            this.txtKullanici.Text = "abc";
            // 
            // txtParola
            // 
            this.txtParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParola.Location = new System.Drawing.Point(527, 142);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(166, 30);
            this.txtParola.TabIndex = 4;
            this.txtParola.Text = "111";
            this.txtParola.TextChanged += new System.EventHandler(this.txtParola_TextChanged);
            // 
            // btnGir
            // 
            this.btnGir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGir.Location = new System.Drawing.Point(558, 287);
            this.btnGir.Name = "btnGir";
            this.btnGir.Size = new System.Drawing.Size(135, 40);
            this.btnGir.TabIndex = 5;
            this.btnGir.Text = "Gir";
            this.btnGir.UseVisualStyleBackColor = true;
            // 
            // lblAyrac
            // 
            this.lblAyrac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAyrac.Location = new System.Drawing.Point(406, 239);
            this.lblAyrac.Name = "lblAyrac";
            this.lblAyrac.Size = new System.Drawing.Size(626, 2);
            this.lblAyrac.TabIndex = 6;
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 500);
            this.Controls.Add(this.lblAyrac);
            this.Controls.Add(this.btnGir);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnGir;
        private System.Windows.Forms.Label lblAyrac;
    }
}

