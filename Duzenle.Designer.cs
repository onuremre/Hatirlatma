namespace Hatirlatma
{
    partial class Duzenle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Duzenle));
            this.l_etkinlik = new System.Windows.Forms.Label();
            this.t_etkinlik = new System.Windows.Forms.RichTextBox();
            this.c_mail = new System.Windows.Forms.CheckBox();
            this.b_duzenle = new System.Windows.Forms.Button();
            this.l_al = new System.Windows.Forms.Label();
            this.l_bit = new System.Windows.Forms.Label();
            this.l_bas = new System.Windows.Forms.Label();
            this.l_saat = new System.Windows.Forms.Label();
            this.l_tarih = new System.Windows.Forms.Label();
            this.dgvDuzenle = new System.Windows.Forms.DataGridView();
            this.c_bas_tar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_bas_saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_et = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_bit_tar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_bit_saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_al_tar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_al_saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_mail_durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_mail_konu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_mail_icerik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_al_tar = new System.Windows.Forms.DateTimePicker();
            this.d_bit_tar = new System.Windows.Forms.DateTimePicker();
            this.d_bas_tar = new System.Windows.Forms.DateTimePicker();
            this.l_mail_icerik = new System.Windows.Forms.Label();
            this.l_mail_konu = new System.Windows.Forms.Label();
            this.t_icerik = new System.Windows.Forms.RichTextBox();
            this.t_konu = new System.Windows.Forms.TextBox();
            this.t_bas_saat = new System.Windows.Forms.MaskedTextBox();
            this.t_bit_saat = new System.Windows.Forms.MaskedTextBox();
            this.t_al_saat = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuzenle)).BeginInit();
            this.SuspendLayout();
            // 
            // l_etkinlik
            // 
            this.l_etkinlik.AutoSize = true;
            this.l_etkinlik.Location = new System.Drawing.Point(13, 132);
            this.l_etkinlik.Name = "l_etkinlik";
            this.l_etkinlik.Size = new System.Drawing.Size(41, 13);
            this.l_etkinlik.TabIndex = 29;
            this.l_etkinlik.Text = "Etkinlik";
            // 
            // t_etkinlik
            // 
            this.t_etkinlik.Location = new System.Drawing.Point(55, 79);
            this.t_etkinlik.Name = "t_etkinlik";
            this.t_etkinlik.Size = new System.Drawing.Size(259, 96);
            this.t_etkinlik.TabIndex = 3;
            this.t_etkinlik.Text = "";
            // 
            // c_mail
            // 
            this.c_mail.AutoSize = true;
            this.c_mail.Location = new System.Drawing.Point(84, 260);
            this.c_mail.Name = "c_mail";
            this.c_mail.Size = new System.Drawing.Size(118, 17);
            this.c_mail.TabIndex = 4;
            this.c_mail.Text = "Mail Almak İstiyoum";
            this.c_mail.UseVisualStyleBackColor = true;
            this.c_mail.CheckedChanged += new System.EventHandler(this.c_mail_CheckedChanged);
            // 
            // b_duzenle
            // 
            this.b_duzenle.Location = new System.Drawing.Point(254, 257);
            this.b_duzenle.Name = "b_duzenle";
            this.b_duzenle.Size = new System.Drawing.Size(60, 23);
            this.b_duzenle.TabIndex = 5;
            this.b_duzenle.Text = "Düzenle";
            this.b_duzenle.UseVisualStyleBackColor = true;
            this.b_duzenle.Click += new System.EventHandler(this.b_duzenle_Click);
            // 
            // l_al
            // 
            this.l_al.AutoSize = true;
            this.l_al.Location = new System.Drawing.Point(258, 8);
            this.l_al.Name = "l_al";
            this.l_al.Size = new System.Drawing.Size(33, 13);
            this.l_al.TabIndex = 25;
            this.l_al.Text = "Alarm";
            // 
            // l_bit
            // 
            this.l_bit.AutoSize = true;
            this.l_bit.Location = new System.Drawing.Point(166, 8);
            this.l_bit.Name = "l_bit";
            this.l_bit.Size = new System.Drawing.Size(26, 13);
            this.l_bit.TabIndex = 24;
            this.l_bit.Text = "Bitiş";
            // 
            // l_bas
            // 
            this.l_bas.AutoSize = true;
            this.l_bas.Location = new System.Drawing.Point(68, 8);
            this.l_bas.Name = "l_bas";
            this.l_bas.Size = new System.Drawing.Size(53, 13);
            this.l_bas.TabIndex = 23;
            this.l_bas.Text = "Başlangıç";
            // 
            // l_saat
            // 
            this.l_saat.AutoSize = true;
            this.l_saat.Location = new System.Drawing.Point(18, 62);
            this.l_saat.Name = "l_saat";
            this.l_saat.Size = new System.Drawing.Size(29, 13);
            this.l_saat.TabIndex = 19;
            this.l_saat.Text = "Saat";
            // 
            // l_tarih
            // 
            this.l_tarih.AutoSize = true;
            this.l_tarih.Location = new System.Drawing.Point(16, 30);
            this.l_tarih.Name = "l_tarih";
            this.l_tarih.Size = new System.Drawing.Size(31, 13);
            this.l_tarih.TabIndex = 18;
            this.l_tarih.Text = "Tarih";
            // 
            // dgvDuzenle
            // 
            this.dgvDuzenle.AllowUserToAddRows = false;
            this.dgvDuzenle.AllowUserToDeleteRows = false;
            this.dgvDuzenle.AllowUserToResizeColumns = false;
            this.dgvDuzenle.AllowUserToResizeRows = false;
            this.dgvDuzenle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDuzenle.ColumnHeadersHeight = 25;
            this.dgvDuzenle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDuzenle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_bas_tar,
            this.c_bas_saat,
            this.c_et,
            this.c_bit_tar,
            this.c_bit_saat,
            this.c_al_tar,
            this.c_al_saat,
            this.c_mail_durum,
            this.c_mail_konu,
            this.c_mail_icerik});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDuzenle.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDuzenle.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDuzenle.Location = new System.Drawing.Point(12, 161);
            this.dgvDuzenle.Name = "dgvDuzenle";
            this.dgvDuzenle.ReadOnly = true;
            this.dgvDuzenle.RowHeadersWidth = 10;
            this.dgvDuzenle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDuzenle.Size = new System.Drawing.Size(13, 14);
            this.dgvDuzenle.TabIndex = 31;
            this.dgvDuzenle.Visible = false;
            // 
            // c_bas_tar
            // 
            this.c_bas_tar.DataPropertyName = "bas_tarih";
            this.c_bas_tar.HeaderText = "Başlangıç Tarihi";
            this.c_bas_tar.Name = "c_bas_tar";
            this.c_bas_tar.ReadOnly = true;
            // 
            // c_bas_saat
            // 
            this.c_bas_saat.DataPropertyName = "bas_saat";
            this.c_bas_saat.HeaderText = "Başlangıç Saati";
            this.c_bas_saat.Name = "c_bas_saat";
            this.c_bas_saat.ReadOnly = true;
            this.c_bas_saat.Width = 90;
            // 
            // c_et
            // 
            this.c_et.DataPropertyName = "aciklama";
            this.c_et.HeaderText = "                     Etkinlik";
            this.c_et.Name = "c_et";
            this.c_et.ReadOnly = true;
            this.c_et.Width = 180;
            // 
            // c_bit_tar
            // 
            this.c_bit_tar.DataPropertyName = "bit_tarih";
            this.c_bit_tar.HeaderText = "Bitiş Tarihi";
            this.c_bit_tar.Name = "c_bit_tar";
            this.c_bit_tar.ReadOnly = true;
            this.c_bit_tar.Width = 70;
            // 
            // c_bit_saat
            // 
            this.c_bit_saat.DataPropertyName = "bit_saat";
            this.c_bit_saat.HeaderText = "Bitiş Saati";
            this.c_bit_saat.Name = "c_bit_saat";
            this.c_bit_saat.ReadOnly = true;
            this.c_bit_saat.Width = 70;
            // 
            // c_al_tar
            // 
            this.c_al_tar.DataPropertyName = "al_tarih";
            this.c_al_tar.HeaderText = "Alarm Tarihi";
            this.c_al_tar.Name = "c_al_tar";
            this.c_al_tar.ReadOnly = true;
            this.c_al_tar.Width = 70;
            // 
            // c_al_saat
            // 
            this.c_al_saat.DataPropertyName = "al_saat";
            this.c_al_saat.HeaderText = "Alarm Saati";
            this.c_al_saat.Name = "c_al_saat";
            this.c_al_saat.ReadOnly = true;
            this.c_al_saat.Width = 70;
            // 
            // c_mail_durum
            // 
            this.c_mail_durum.DataPropertyName = "mail_durum";
            this.c_mail_durum.HeaderText = "Mail Durum";
            this.c_mail_durum.Name = "c_mail_durum";
            this.c_mail_durum.ReadOnly = true;
            this.c_mail_durum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_mail_durum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // c_mail_konu
            // 
            this.c_mail_konu.DataPropertyName = "mail_konu";
            this.c_mail_konu.HeaderText = "Mail Konu";
            this.c_mail_konu.Name = "c_mail_konu";
            this.c_mail_konu.ReadOnly = true;
            // 
            // c_mail_icerik
            // 
            this.c_mail_icerik.DataPropertyName = "mail_icerik";
            this.c_mail_icerik.HeaderText = "Mail İçerik";
            this.c_mail_icerik.Name = "c_mail_icerik";
            this.c_mail_icerik.ReadOnly = true;
            // 
            // d_al_tar
            // 
            this.d_al_tar.CustomFormat = "yyyy-MM-dd";
            this.d_al_tar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.d_al_tar.Location = new System.Drawing.Point(231, 27);
            this.d_al_tar.Name = "d_al_tar";
            this.d_al_tar.Size = new System.Drawing.Size(83, 20);
            this.d_al_tar.TabIndex = 9;
            // 
            // d_bit_tar
            // 
            this.d_bit_tar.CustomFormat = "yyyy-MM-dd";
            this.d_bit_tar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.d_bit_tar.Location = new System.Drawing.Point(142, 27);
            this.d_bit_tar.Name = "d_bit_tar";
            this.d_bit_tar.Size = new System.Drawing.Size(83, 20);
            this.d_bit_tar.TabIndex = 8;
            // 
            // d_bas_tar
            // 
            this.d_bas_tar.CustomFormat = "yyyy-MM-dd";
            this.d_bas_tar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.d_bas_tar.Location = new System.Drawing.Point(55, 27);
            this.d_bas_tar.Name = "d_bas_tar";
            this.d_bas_tar.Size = new System.Drawing.Size(81, 20);
            this.d_bas_tar.TabIndex = 7;
            // 
            // l_mail_icerik
            // 
            this.l_mail_icerik.AutoSize = true;
            this.l_mail_icerik.Location = new System.Drawing.Point(13, 219);
            this.l_mail_icerik.Name = "l_mail_icerik";
            this.l_mail_icerik.Size = new System.Drawing.Size(57, 13);
            this.l_mail_icerik.TabIndex = 35;
            this.l_mail_icerik.Text = "Mail İçeriği";
            // 
            // l_mail_konu
            // 
            this.l_mail_konu.AutoSize = true;
            this.l_mail_konu.Location = new System.Drawing.Point(13, 184);
            this.l_mail_konu.Name = "l_mail_konu";
            this.l_mail_konu.Size = new System.Drawing.Size(65, 13);
            this.l_mail_konu.TabIndex = 34;
            this.l_mail_konu.Text = "Mail Konusu";
            // 
            // t_icerik
            // 
            this.t_icerik.Location = new System.Drawing.Point(84, 204);
            this.t_icerik.Name = "t_icerik";
            this.t_icerik.Size = new System.Drawing.Size(230, 45);
            this.t_icerik.TabIndex = 33;
            this.t_icerik.Text = "";
            // 
            // t_konu
            // 
            this.t_konu.Location = new System.Drawing.Point(84, 181);
            this.t_konu.Name = "t_konu";
            this.t_konu.Size = new System.Drawing.Size(230, 20);
            this.t_konu.TabIndex = 32;
            // 
            // t_bas_saat
            // 
            this.t_bas_saat.Location = new System.Drawing.Point(55, 53);
            this.t_bas_saat.Mask = "00:00";
            this.t_bas_saat.Name = "t_bas_saat";
            this.t_bas_saat.Size = new System.Drawing.Size(81, 20);
            this.t_bas_saat.TabIndex = 36;
            this.t_bas_saat.ValidatingType = typeof(System.DateTime);
            // 
            // t_bit_saat
            // 
            this.t_bit_saat.Location = new System.Drawing.Point(142, 53);
            this.t_bit_saat.Mask = "00:00";
            this.t_bit_saat.Name = "t_bit_saat";
            this.t_bit_saat.Size = new System.Drawing.Size(83, 20);
            this.t_bit_saat.TabIndex = 37;
            this.t_bit_saat.ValidatingType = typeof(System.DateTime);
            // 
            // t_al_saat
            // 
            this.t_al_saat.Location = new System.Drawing.Point(231, 53);
            this.t_al_saat.Mask = "00:00";
            this.t_al_saat.Name = "t_al_saat";
            this.t_al_saat.Size = new System.Drawing.Size(83, 20);
            this.t_al_saat.TabIndex = 38;
            this.t_al_saat.ValidatingType = typeof(System.DateTime);
            // 
            // Duzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(326, 288);
            this.Controls.Add(this.t_al_saat);
            this.Controls.Add(this.t_bit_saat);
            this.Controls.Add(this.t_bas_saat);
            this.Controls.Add(this.l_mail_icerik);
            this.Controls.Add(this.l_mail_konu);
            this.Controls.Add(this.t_icerik);
            this.Controls.Add(this.t_konu);
            this.Controls.Add(this.d_al_tar);
            this.Controls.Add(this.d_bit_tar);
            this.Controls.Add(this.d_bas_tar);
            this.Controls.Add(this.dgvDuzenle);
            this.Controls.Add(this.l_etkinlik);
            this.Controls.Add(this.t_etkinlik);
            this.Controls.Add(this.c_mail);
            this.Controls.Add(this.b_duzenle);
            this.Controls.Add(this.l_al);
            this.Controls.Add(this.l_bit);
            this.Controls.Add(this.l_bas);
            this.Controls.Add(this.l_saat);
            this.Controls.Add(this.l_tarih);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Duzenle";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Duzenle";
            this.Load += new System.EventHandler(this.Duzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuzenle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_etkinlik;
        private System.Windows.Forms.RichTextBox t_etkinlik;
        private System.Windows.Forms.CheckBox c_mail;
        private System.Windows.Forms.Button b_duzenle;
        private System.Windows.Forms.Label l_al;
        private System.Windows.Forms.Label l_bit;
        private System.Windows.Forms.Label l_bas;
        private System.Windows.Forms.Label l_saat;
        private System.Windows.Forms.Label l_tarih;
        private System.Windows.Forms.DataGridView dgvDuzenle;
        private System.Windows.Forms.DateTimePicker d_al_tar;
        private System.Windows.Forms.DateTimePicker d_bit_tar;
        private System.Windows.Forms.DateTimePicker d_bas_tar;
        private System.Windows.Forms.Label l_mail_icerik;
        private System.Windows.Forms.Label l_mail_konu;
        private System.Windows.Forms.RichTextBox t_icerik;
        private System.Windows.Forms.TextBox t_konu;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_bas_tar;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_bas_saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_et;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_bit_tar;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_bit_saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_al_tar;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_al_saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_mail_durum;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_mail_konu;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_mail_icerik;
        private System.Windows.Forms.MaskedTextBox t_bas_saat;
        private System.Windows.Forms.MaskedTextBox t_bit_saat;
        private System.Windows.Forms.MaskedTextBox t_al_saat;
    }
}