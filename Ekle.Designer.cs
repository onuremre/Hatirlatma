namespace Hatirlatma
{
    partial class Ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ekle));
            this.d_bas_tar = new System.Windows.Forms.DateTimePicker();
            this.d_bit_tar = new System.Windows.Forms.DateTimePicker();
            this.d_al_tar = new System.Windows.Forms.DateTimePicker();
            this.l_tarih = new System.Windows.Forms.Label();
            this.l_saat = new System.Windows.Forms.Label();
            this.l_bas = new System.Windows.Forms.Label();
            this.l_bit = new System.Windows.Forms.Label();
            this.l_al = new System.Windows.Forms.Label();
            this.b_ekle = new System.Windows.Forms.Button();
            this.c_mail = new System.Windows.Forms.CheckBox();
            this.t_etkinlik = new System.Windows.Forms.RichTextBox();
            this.l_etkinlik = new System.Windows.Forms.Label();
            this.t_icerik = new System.Windows.Forms.RichTextBox();
            this.t_konu = new System.Windows.Forms.TextBox();
            this.l_mail_konu = new System.Windows.Forms.Label();
            this.l_mail_icerik = new System.Windows.Forms.Label();
            this.t_bas_saat = new System.Windows.Forms.MaskedTextBox();
            this.t_bit_saat = new System.Windows.Forms.MaskedTextBox();
            this.t_al_saat = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // d_bas_tar
            // 
            this.d_bas_tar.CustomFormat = "yyyy-MM-dd";
            this.d_bas_tar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.d_bas_tar.Location = new System.Drawing.Point(51, 28);
            this.d_bas_tar.Name = "d_bas_tar";
            this.d_bas_tar.Size = new System.Drawing.Size(81, 20);
            this.d_bas_tar.TabIndex = 6;
            // 
            // d_bit_tar
            // 
            this.d_bit_tar.CustomFormat = "yyyy-MM-dd";
            this.d_bit_tar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.d_bit_tar.Location = new System.Drawing.Point(138, 28);
            this.d_bit_tar.Name = "d_bit_tar";
            this.d_bit_tar.Size = new System.Drawing.Size(83, 20);
            this.d_bit_tar.TabIndex = 7;
            // 
            // d_al_tar
            // 
            this.d_al_tar.CustomFormat = "yyyy-MM-dd";
            this.d_al_tar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.d_al_tar.Location = new System.Drawing.Point(227, 28);
            this.d_al_tar.Name = "d_al_tar";
            this.d_al_tar.Size = new System.Drawing.Size(83, 20);
            this.d_al_tar.TabIndex = 8;
            // 
            // l_tarih
            // 
            this.l_tarih.AutoSize = true;
            this.l_tarih.Location = new System.Drawing.Point(12, 31);
            this.l_tarih.Name = "l_tarih";
            this.l_tarih.Size = new System.Drawing.Size(31, 13);
            this.l_tarih.TabIndex = 3;
            this.l_tarih.Text = "Tarih";
            // 
            // l_saat
            // 
            this.l_saat.AutoSize = true;
            this.l_saat.Location = new System.Drawing.Point(14, 58);
            this.l_saat.Name = "l_saat";
            this.l_saat.Size = new System.Drawing.Size(29, 13);
            this.l_saat.TabIndex = 4;
            this.l_saat.Text = "Saat";
            // 
            // l_bas
            // 
            this.l_bas.AutoSize = true;
            this.l_bas.Location = new System.Drawing.Point(64, 9);
            this.l_bas.Name = "l_bas";
            this.l_bas.Size = new System.Drawing.Size(53, 13);
            this.l_bas.TabIndex = 8;
            this.l_bas.Text = "Başlangıç";
            // 
            // l_bit
            // 
            this.l_bit.AutoSize = true;
            this.l_bit.Location = new System.Drawing.Point(162, 9);
            this.l_bit.Name = "l_bit";
            this.l_bit.Size = new System.Drawing.Size(26, 13);
            this.l_bit.TabIndex = 9;
            this.l_bit.Text = "Bitiş";
            // 
            // l_al
            // 
            this.l_al.AutoSize = true;
            this.l_al.Location = new System.Drawing.Point(254, 9);
            this.l_al.Name = "l_al";
            this.l_al.Size = new System.Drawing.Size(33, 13);
            this.l_al.TabIndex = 10;
            this.l_al.Text = "Alarm";
            // 
            // b_ekle
            // 
            this.b_ekle.Location = new System.Drawing.Point(235, 261);
            this.b_ekle.Name = "b_ekle";
            this.b_ekle.Size = new System.Drawing.Size(75, 23);
            this.b_ekle.TabIndex = 5;
            this.b_ekle.Text = "Ekle";
            this.b_ekle.UseVisualStyleBackColor = true;
            this.b_ekle.Click += new System.EventHandler(this.b_ekle_Click);
            // 
            // c_mail
            // 
            this.c_mail.AutoSize = true;
            this.c_mail.Location = new System.Drawing.Point(80, 264);
            this.c_mail.Name = "c_mail";
            this.c_mail.Size = new System.Drawing.Size(121, 17);
            this.c_mail.TabIndex = 4;
            this.c_mail.Text = "Mail Almak İstiyorum";
            this.c_mail.UseVisualStyleBackColor = true;
            this.c_mail.CheckedChanged += new System.EventHandler(this.c_mail_CheckedChanged);
            // 
            // t_etkinlik
            // 
            this.t_etkinlik.Location = new System.Drawing.Point(51, 84);
            this.t_etkinlik.Name = "t_etkinlik";
            this.t_etkinlik.Size = new System.Drawing.Size(259, 96);
            this.t_etkinlik.TabIndex = 3;
            this.t_etkinlik.Text = "";
            // 
            // l_etkinlik
            // 
            this.l_etkinlik.AutoSize = true;
            this.l_etkinlik.Location = new System.Drawing.Point(9, 127);
            this.l_etkinlik.Name = "l_etkinlik";
            this.l_etkinlik.Size = new System.Drawing.Size(41, 13);
            this.l_etkinlik.TabIndex = 14;
            this.l_etkinlik.Text = "Etkinlik";
            // 
            // t_icerik
            // 
            this.t_icerik.Location = new System.Drawing.Point(80, 209);
            this.t_icerik.Name = "t_icerik";
            this.t_icerik.Size = new System.Drawing.Size(230, 45);
            this.t_icerik.TabIndex = 16;
            this.t_icerik.Text = "";
            // 
            // t_konu
            // 
            this.t_konu.Location = new System.Drawing.Point(80, 186);
            this.t_konu.Name = "t_konu";
            this.t_konu.Size = new System.Drawing.Size(230, 20);
            this.t_konu.TabIndex = 15;
            // 
            // l_mail_konu
            // 
            this.l_mail_konu.AutoSize = true;
            this.l_mail_konu.Location = new System.Drawing.Point(9, 189);
            this.l_mail_konu.Name = "l_mail_konu";
            this.l_mail_konu.Size = new System.Drawing.Size(65, 13);
            this.l_mail_konu.TabIndex = 17;
            this.l_mail_konu.Text = "Mail Konusu";
            // 
            // l_mail_icerik
            // 
            this.l_mail_icerik.AutoSize = true;
            this.l_mail_icerik.Location = new System.Drawing.Point(9, 224);
            this.l_mail_icerik.Name = "l_mail_icerik";
            this.l_mail_icerik.Size = new System.Drawing.Size(57, 13);
            this.l_mail_icerik.TabIndex = 18;
            this.l_mail_icerik.Text = "Mail İçeriği";
            // 
            // t_bas_saat
            // 
            this.t_bas_saat.Location = new System.Drawing.Point(51, 54);
            this.t_bas_saat.Mask = "00:00";
            this.t_bas_saat.Name = "t_bas_saat";
            this.t_bas_saat.Size = new System.Drawing.Size(83, 20);
            this.t_bas_saat.TabIndex = 20;
            this.t_bas_saat.ValidatingType = typeof(System.DateTime);
            // 
            // t_bit_saat
            // 
            this.t_bit_saat.Location = new System.Drawing.Point(138, 54);
            this.t_bit_saat.Mask = "00:00";
            this.t_bit_saat.Name = "t_bit_saat";
            this.t_bit_saat.Size = new System.Drawing.Size(83, 20);
            this.t_bit_saat.TabIndex = 21;
            this.t_bit_saat.ValidatingType = typeof(System.DateTime);
            // 
            // t_al_saat
            // 
            this.t_al_saat.Location = new System.Drawing.Point(227, 54);
            this.t_al_saat.Mask = "00:00";
            this.t_al_saat.Name = "t_al_saat";
            this.t_al_saat.Size = new System.Drawing.Size(83, 20);
            this.t_al_saat.TabIndex = 22;
            this.t_al_saat.ValidatingType = typeof(System.DateTime);
            // 
            // Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(326, 296);
            this.Controls.Add(this.t_al_saat);
            this.Controls.Add(this.t_bit_saat);
            this.Controls.Add(this.t_bas_saat);
            this.Controls.Add(this.l_mail_icerik);
            this.Controls.Add(this.l_mail_konu);
            this.Controls.Add(this.t_icerik);
            this.Controls.Add(this.t_konu);
            this.Controls.Add(this.l_etkinlik);
            this.Controls.Add(this.t_etkinlik);
            this.Controls.Add(this.c_mail);
            this.Controls.Add(this.b_ekle);
            this.Controls.Add(this.l_al);
            this.Controls.Add(this.l_bit);
            this.Controls.Add(this.l_bas);
            this.Controls.Add(this.l_saat);
            this.Controls.Add(this.l_tarih);
            this.Controls.Add(this.d_al_tar);
            this.Controls.Add(this.d_bit_tar);
            this.Controls.Add(this.d_bas_tar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker d_bas_tar;
        private System.Windows.Forms.DateTimePicker d_bit_tar;
        private System.Windows.Forms.DateTimePicker d_al_tar;
        private System.Windows.Forms.Label l_tarih;
        private System.Windows.Forms.Label l_saat;
        private System.Windows.Forms.Label l_bas;
        private System.Windows.Forms.Label l_bit;
        private System.Windows.Forms.Label l_al;
        private System.Windows.Forms.Button b_ekle;
        private System.Windows.Forms.CheckBox c_mail;
        private System.Windows.Forms.RichTextBox t_etkinlik;
        private System.Windows.Forms.Label l_etkinlik;
        private System.Windows.Forms.RichTextBox t_icerik;
        private System.Windows.Forms.TextBox t_konu;
        private System.Windows.Forms.Label l_mail_konu;
        private System.Windows.Forms.Label l_mail_icerik;
        private System.Windows.Forms.MaskedTextBox t_bas_saat;
        private System.Windows.Forms.MaskedTextBox t_bit_saat;
        private System.Windows.Forms.MaskedTextBox t_al_saat;
    }
}