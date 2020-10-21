namespace Hatirlatma
{
    partial class Kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayit));
            this.l_sifre = new System.Windows.Forms.Label();
            this.l_k_ad = new System.Windows.Forms.Label();
            this.b_cikis = new System.Windows.Forms.Button();
            this.b_kayit = new System.Windows.Forms.Button();
            this.l_mail = new System.Windows.Forms.Label();
            this.l_sifre_t = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.t_ad = new System.Windows.Forms.TextBox();
            this.t_sifre = new System.Windows.Forms.TextBox();
            this.t_sifre_t = new System.Windows.Forms.TextBox();
            this.t_mail = new System.Windows.Forms.TextBox();
            this.dgvKullanici = new System.Windows.Forms.DataGridView();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // l_sifre
            // 
            this.l_sifre.AutoSize = true;
            this.l_sifre.Location = new System.Drawing.Point(25, 50);
            this.l_sifre.Name = "l_sifre";
            this.l_sifre.Size = new System.Drawing.Size(28, 13);
            this.l_sifre.TabIndex = 11;
            this.l_sifre.Text = "Şifre";
            // 
            // l_k_ad
            // 
            this.l_k_ad.AutoSize = true;
            this.l_k_ad.Location = new System.Drawing.Point(9, 24);
            this.l_k_ad.Name = "l_k_ad";
            this.l_k_ad.Size = new System.Drawing.Size(64, 13);
            this.l_k_ad.TabIndex = 10;
            this.l_k_ad.Text = "Kullanıcı Adı";
            // 
            // b_cikis
            // 
            this.b_cikis.Location = new System.Drawing.Point(78, 152);
            this.b_cikis.Name = "b_cikis";
            this.b_cikis.Size = new System.Drawing.Size(75, 23);
            this.b_cikis.TabIndex = 5;
            this.b_cikis.Text = "Kapat";
            this.b_cikis.UseVisualStyleBackColor = true;
            this.b_cikis.Click += new System.EventHandler(this.b_cikis_Click);
            // 
            // b_kayit
            // 
            this.b_kayit.Location = new System.Drawing.Point(77, 123);
            this.b_kayit.Name = "b_kayit";
            this.b_kayit.Size = new System.Drawing.Size(76, 23);
            this.b_kayit.TabIndex = 4;
            this.b_kayit.Text = "Kayıt Ol";
            this.b_kayit.UseVisualStyleBackColor = true;
            this.b_kayit.Click += new System.EventHandler(this.b_kayit_Click);
            // 
            // l_mail
            // 
            this.l_mail.AutoSize = true;
            this.l_mail.Location = new System.Drawing.Point(19, 101);
            this.l_mail.Name = "l_mail";
            this.l_mail.Size = new System.Drawing.Size(36, 13);
            this.l_mail.TabIndex = 13;
            this.l_mail.Text = "E-Mail";
            // 
            // l_sifre_t
            // 
            this.l_sifre_t.AutoSize = true;
            this.l_sifre_t.Location = new System.Drawing.Point(5, 76);
            this.l_sifre_t.Name = "l_sifre_t";
            this.l_sifre_t.Size = new System.Drawing.Size(68, 13);
            this.l_sifre_t.TabIndex = 16;
            this.l_sifre_t.Text = "Şifre - Tekrar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Hatirlatma.Properties.Resources.img_451619;
            this.pictureBox1.Image = global::Hatirlatma.Properties.Resources.img_451619;
            this.pictureBox1.Location = new System.Drawing.Point(8, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // t_ad
            // 
            this.t_ad.Location = new System.Drawing.Point(79, 21);
            this.t_ad.MaxLength = 20;
            this.t_ad.Name = "t_ad";
            this.t_ad.Size = new System.Drawing.Size(75, 20);
            this.t_ad.TabIndex = 19;
            // 
            // t_sifre
            // 
            this.t_sifre.Location = new System.Drawing.Point(79, 46);
            this.t_sifre.MaxLength = 100;
            this.t_sifre.Name = "t_sifre";
            this.t_sifre.PasswordChar = '*';
            this.t_sifre.Size = new System.Drawing.Size(75, 20);
            this.t_sifre.TabIndex = 20;
            // 
            // t_sifre_t
            // 
            this.t_sifre_t.Location = new System.Drawing.Point(79, 72);
            this.t_sifre_t.MaxLength = 100;
            this.t_sifre_t.Name = "t_sifre_t";
            this.t_sifre_t.PasswordChar = '*';
            this.t_sifre_t.Size = new System.Drawing.Size(75, 20);
            this.t_sifre_t.TabIndex = 21;
            // 
            // t_mail
            // 
            this.t_mail.Location = new System.Drawing.Point(79, 98);
            this.t_mail.MaxLength = 100;
            this.t_mail.Name = "t_mail";
            this.t_mail.Size = new System.Drawing.Size(75, 20);
            this.t_mail.TabIndex = 22;
            // 
            // dgvKullanici
            // 
            this.dgvKullanici.AllowUserToAddRows = false;
            this.dgvKullanici.AllowUserToDeleteRows = false;
            this.dgvKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mail,
            this.ad});
            this.dgvKullanici.Location = new System.Drawing.Point(159, 156);
            this.dgvKullanici.Name = "dgvKullanici";
            this.dgvKullanici.ReadOnly = true;
            this.dgvKullanici.Size = new System.Drawing.Size(18, 13);
            this.dgvKullanici.TabIndex = 23;
            this.dgvKullanici.Visible = false;
            // 
            // Mail
            // 
            this.Mail.DataPropertyName = "mail";
            this.Mail.HeaderText = "mail";
            this.Mail.Name = "Mail";
            // 
            // ad
            // 
            this.ad.DataPropertyName = "ad";
            this.ad.HeaderText = "ad";
            this.ad.Name = "ad";
            // 
            // Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(179, 181);
            this.ControlBox = false;
            this.Controls.Add(this.dgvKullanici);
            this.Controls.Add(this.t_mail);
            this.Controls.Add(this.t_sifre_t);
            this.Controls.Add(this.t_sifre);
            this.Controls.Add(this.t_ad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.l_sifre_t);
            this.Controls.Add(this.l_mail);
            this.Controls.Add(this.l_sifre);
            this.Controls.Add(this.l_k_ad);
            this.Controls.Add(this.b_cikis);
            this.Controls.Add(this.b_kayit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kayıt Ol";
            this.Load += new System.EventHandler(this.Kayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_sifre;
        private System.Windows.Forms.Label l_k_ad;
        private System.Windows.Forms.Button b_cikis;
        private System.Windows.Forms.Button b_kayit;
        private System.Windows.Forms.Label l_mail;
        private System.Windows.Forms.Label l_sifre_t;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox t_ad;
        private System.Windows.Forms.TextBox t_sifre;
        private System.Windows.Forms.TextBox t_sifre_t;
        private System.Windows.Forms.TextBox t_mail;
        private System.Windows.Forms.DataGridView dgvKullanici;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad;
    }
}