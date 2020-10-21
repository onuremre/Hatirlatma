namespace Hatirlatma
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.b_giris = new System.Windows.Forms.Button();
            this.t_ad = new System.Windows.Forms.TextBox();
            this.t_sifre = new System.Windows.Forms.TextBox();
            this.b_cikis = new System.Windows.Forms.Button();
            this.l_k_ad = new System.Windows.Forms.Label();
            this.l_sifre = new System.Windows.Forms.Label();
            this.l_kayit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_giris
            // 
            this.b_giris.Location = new System.Drawing.Point(175, 53);
            this.b_giris.Name = "b_giris";
            this.b_giris.Size = new System.Drawing.Size(76, 23);
            this.b_giris.TabIndex = 2;
            this.b_giris.Text = "Giriş";
            this.b_giris.UseVisualStyleBackColor = true;
            this.b_giris.Click += new System.EventHandler(this.b_giris_Click);
            // 
            // t_ad
            // 
            this.t_ad.Location = new System.Drawing.Point(94, 32);
            this.t_ad.MaxLength = 20;
            this.t_ad.Name = "t_ad";
            this.t_ad.Size = new System.Drawing.Size(75, 20);
            this.t_ad.TabIndex = 0;
            // 
            // t_sifre
            // 
            this.t_sifre.Location = new System.Drawing.Point(176, 32);
            this.t_sifre.MaxLength = 100;
            this.t_sifre.Name = "t_sifre";
            this.t_sifre.PasswordChar = '*';
            this.t_sifre.Size = new System.Drawing.Size(75, 20);
            this.t_sifre.TabIndex = 1;
            // 
            // b_cikis
            // 
            this.b_cikis.Location = new System.Drawing.Point(94, 53);
            this.b_cikis.Name = "b_cikis";
            this.b_cikis.Size = new System.Drawing.Size(75, 23);
            this.b_cikis.TabIndex = 4;
            this.b_cikis.Text = "Kapat";
            this.b_cikis.UseVisualStyleBackColor = true;
            this.b_cikis.Click += new System.EventHandler(this.b_cikis_Click);
            // 
            // l_k_ad
            // 
            this.l_k_ad.AutoSize = true;
            this.l_k_ad.Location = new System.Drawing.Point(99, 17);
            this.l_k_ad.Name = "l_k_ad";
            this.l_k_ad.Size = new System.Drawing.Size(64, 13);
            this.l_k_ad.TabIndex = 5;
            this.l_k_ad.Text = "Kullanıcı Adı";
            // 
            // l_sifre
            // 
            this.l_sifre.AutoSize = true;
            this.l_sifre.Location = new System.Drawing.Point(199, 17);
            this.l_sifre.Name = "l_sifre";
            this.l_sifre.Size = new System.Drawing.Size(28, 13);
            this.l_sifre.TabIndex = 6;
            this.l_sifre.Text = "Şifre";
            // 
            // l_kayit
            // 
            this.l_kayit.AutoSize = true;
            this.l_kayit.Location = new System.Drawing.Point(212, 79);
            this.l_kayit.Name = "l_kayit";
            this.l_kayit.Size = new System.Drawing.Size(39, 13);
            this.l_kayit.TabIndex = 5;
            this.l_kayit.Text = "Kaydol";
            this.l_kayit.Click += new System.EventHandler(this.l_kayit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Hatirlatma.Properties.Resources.img_451619;
            this.pictureBox1.Image = global::Hatirlatma.Properties.Resources.img_451619;
            this.pictureBox1.Location = new System.Drawing.Point(4, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(255, 104);
            this.ControlBox = false;
            this.Controls.Add(this.l_kayit);
            this.Controls.Add(this.l_sifre);
            this.Controls.Add(this.l_k_ad);
            this.Controls.Add(this.b_cikis);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.t_sifre);
            this.Controls.Add(this.t_ad);
            this.Controls.Add(this.b_giris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Giris";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Giris_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_giris;
        private System.Windows.Forms.TextBox t_ad;
        private System.Windows.Forms.TextBox t_sifre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b_cikis;
        private System.Windows.Forms.Label l_k_ad;
        private System.Windows.Forms.Label l_sifre;
        private System.Windows.Forms.Label l_kayit;
    }
}