namespace SISWin
{
    partial class Parola_Değiştirme
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
            this.txtEski = new System.Windows.Forms.TextBox();
            this.txtYeni = new System.Windows.Forms.TextBox();
            this.txtYeni2 = new System.Windows.Forms.TextBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SISWin.Properties.Resources.kilit;
            this.pictureBox1.Location = new System.Drawing.Point(53, 122);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eski Parola:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yeni Parola:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(437, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yeni Parola(Tekrar):";
            // 
            // lblAyrac
            // 
            this.lblAyrac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAyrac.Location = new System.Drawing.Point(388, 294);
            this.lblAyrac.Name = "lblAyrac";
            this.lblAyrac.Size = new System.Drawing.Size(500, 2);
            this.lblAyrac.TabIndex = 4;
            // 
            // txtEski
            // 
            this.txtEski.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEski.Location = new System.Drawing.Point(643, 96);
            this.txtEski.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEski.Name = "txtEski";
            this.txtEski.PasswordChar = '*';
            this.txtEski.Size = new System.Drawing.Size(124, 30);
            this.txtEski.TabIndex = 5;
            // 
            // txtYeni
            // 
            this.txtYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYeni.Location = new System.Drawing.Point(643, 150);
            this.txtYeni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYeni.Name = "txtYeni";
            this.txtYeni.PasswordChar = '*';
            this.txtYeni.Size = new System.Drawing.Size(124, 30);
            this.txtYeni.TabIndex = 6;
            // 
            // txtYeni2
            // 
            this.txtYeni2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYeni2.Location = new System.Drawing.Point(643, 207);
            this.txtYeni2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYeni2.Name = "txtYeni2";
            this.txtYeni2.PasswordChar = '*';
            this.txtYeni2.Size = new System.Drawing.Size(124, 30);
            this.txtYeni2.TabIndex = 7;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(643, 340);
            this.btnDegistir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(153, 54);
            this.btnDegistir.TabIndex = 8;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            // 
            // Parola_Değiştirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.txtYeni2);
            this.Controls.Add(this.txtYeni);
            this.Controls.Add(this.txtEski);
            this.Controls.Add(this.lblAyrac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Parola_Değiştirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parola Değiştirme";
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
        private System.Windows.Forms.TextBox txtEski;
        private System.Windows.Forms.TextBox txtYeni;
        private System.Windows.Forms.TextBox txtYeni2;
        private System.Windows.Forms.Button btnDegistir;
    }
}