namespace Hatirlatma
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tkvm = new System.Windows.Forms.MonthCalendar();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgvVeri = new System.Windows.Forms.DataGridView();
            this.dgvAlSaat = new System.Windows.Forms.DataGridView();
            this.al_saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail_durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail_konu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail_icerik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saatKac = new System.Windows.Forms.Timer(this.components);
            this.ni_sistem = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms_ayar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.c_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_bas_saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_et = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_bit_tar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_bit_saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_al_tar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_al_saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_mail_durum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.c_mail_konu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_mail_icerik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_bas_tar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_kullanici_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_duzenle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.c_sil = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlSaat)).BeginInit();
            this.cms_ayar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tkvm
            // 
            this.tkvm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tkvm.Location = new System.Drawing.Point(638, 12);
            this.tkvm.Name = "tkvm";
            this.tkvm.TabIndex = 5;
            this.tkvm.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.tkvm_DateChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(638, 186);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(81, 23);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Etkinlik Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgvVeri
            // 
            this.dgvVeri.AllowUserToAddRows = false;
            this.dgvVeri.AllowUserToDeleteRows = false;
            this.dgvVeri.AllowUserToResizeColumns = false;
            this.dgvVeri.AllowUserToResizeRows = false;
            this.dgvVeri.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvVeri.ColumnHeadersHeight = 25;
            this.dgvVeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVeri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_id,
            this.c_bas_saat,
            this.c_et,
            this.c_bit_tar,
            this.c_bit_saat,
            this.c_al_tar,
            this.c_al_saat,
            this.c_mail_durum,
            this.c_mail_konu,
            this.c_mail_icerik,
            this.c_bas_tar,
            this.c_kullanici_id,
            this.c_duzenle,
            this.c_sil});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVeri.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVeri.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvVeri.Location = new System.Drawing.Point(12, 11);
            this.dgvVeri.Name = "dgvVeri";
            this.dgvVeri.ReadOnly = true;
            this.dgvVeri.RowHeadersWidth = 10;
            this.dgvVeri.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVeri.Size = new System.Drawing.Size(614, 198);
            this.dgvVeri.TabIndex = 15;
            this.dgvVeri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVeri_CellContentClick);
            // 
            // dgvAlSaat
            // 
            this.dgvAlSaat.AllowUserToAddRows = false;
            this.dgvAlSaat.AllowUserToDeleteRows = false;
            this.dgvAlSaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlSaat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.al_saat,
            this.mail_durum,
            this.mail_konu,
            this.mail_icerik});
            this.dgvAlSaat.Location = new System.Drawing.Point(12, 215);
            this.dgvAlSaat.Name = "dgvAlSaat";
            this.dgvAlSaat.ReadOnly = true;
            this.dgvAlSaat.Size = new System.Drawing.Size(13, 15);
            this.dgvAlSaat.TabIndex = 16;
            this.dgvAlSaat.Visible = false;
            // 
            // al_saat
            // 
            this.al_saat.DataPropertyName = "al_saat";
            this.al_saat.HeaderText = "al_saat";
            this.al_saat.Name = "al_saat";
            this.al_saat.ReadOnly = true;
            // 
            // mail_durum
            // 
            this.mail_durum.DataPropertyName = "mail_durum";
            this.mail_durum.HeaderText = "mail_durum";
            this.mail_durum.Name = "mail_durum";
            this.mail_durum.ReadOnly = true;
            // 
            // mail_konu
            // 
            this.mail_konu.DataPropertyName = "mail_konu";
            this.mail_konu.HeaderText = "mail_konu";
            this.mail_konu.Name = "mail_konu";
            this.mail_konu.ReadOnly = true;
            // 
            // mail_icerik
            // 
            this.mail_icerik.DataPropertyName = "mail_icerik";
            this.mail_icerik.HeaderText = "mail_icerik";
            this.mail_icerik.Name = "mail_icerik";
            this.mail_icerik.ReadOnly = true;
            // 
            // saatKac
            // 
            this.saatKac.Enabled = true;
            this.saatKac.Interval = 1000;
            // 
            // ni_sistem
            // 
            this.ni_sistem.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ni_sistem.BalloonTipText = "Şuan için ayarlanmış bir etkinliğiniz var";
            this.ni_sistem.BalloonTipTitle = "Hatırlatma";
            this.ni_sistem.ContextMenuStrip = this.cms_ayar;
            this.ni_sistem.Icon = ((System.Drawing.Icon)(resources.GetObject("ni_sistem.Icon")));
            this.ni_sistem.Text = "Etkinlik";
            this.ni_sistem.Visible = true;
            this.ni_sistem.BalloonTipClicked += new System.EventHandler(this.ni_sistem_BalloonTipClicked_1);
            this.ni_sistem.BalloonTipClosed += new System.EventHandler(this.ni_sistem_BalloonTipClosed);
            this.ni_sistem.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ni_sistem_MouseDoubleClick);
            // 
            // cms_ayar
            // 
            this.cms_ayar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem,
            this.gizleToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.cms_ayar.Name = "cms_ayar";
            this.cms_ayar.Size = new System.Drawing.Size(109, 70);
            // 
            // gösterToolStripMenuItem
            // 
            this.gösterToolStripMenuItem.Name = "gösterToolStripMenuItem";
            this.gösterToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.gösterToolStripMenuItem.Text = "Göster";
            this.gösterToolStripMenuItem.Click += new System.EventHandler(this.gösterToolStripMenuItem_Click);
            // 
            // gizleToolStripMenuItem
            // 
            this.gizleToolStripMenuItem.Name = "gizleToolStripMenuItem";
            this.gizleToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.gizleToolStripMenuItem.Text = "Gizle";
            this.gizleToolStripMenuItem.Click += new System.EventHandler(this.gizleToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "setting.ico");
            // 
            // c_id
            // 
            this.c_id.DataPropertyName = "id";
            this.c_id.HeaderText = "Id";
            this.c_id.Name = "c_id";
            this.c_id.ReadOnly = true;
            this.c_id.Visible = false;
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
            this.c_et.Width = 150;
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
            this.c_mail_durum.HeaderText = "Mail";
            this.c_mail_durum.Name = "c_mail_durum";
            this.c_mail_durum.ReadOnly = true;
            this.c_mail_durum.Width = 30;
            // 
            // c_mail_konu
            // 
            this.c_mail_konu.DataPropertyName = "mail_konu";
            this.c_mail_konu.HeaderText = "Mail Konusu";
            this.c_mail_konu.Name = "c_mail_konu";
            this.c_mail_konu.ReadOnly = true;
            this.c_mail_konu.Visible = false;
            // 
            // c_mail_icerik
            // 
            this.c_mail_icerik.DataPropertyName = "mail_icerik";
            this.c_mail_icerik.HeaderText = "Mail İçeriği";
            this.c_mail_icerik.Name = "c_mail_icerik";
            this.c_mail_icerik.ReadOnly = true;
            this.c_mail_icerik.Visible = false;
            // 
            // c_bas_tar
            // 
            this.c_bas_tar.DataPropertyName = "bas_tarih";
            this.c_bas_tar.HeaderText = "Başlangıç Tarihi";
            this.c_bas_tar.Name = "c_bas_tar";
            this.c_bas_tar.ReadOnly = true;
            this.c_bas_tar.Visible = false;
            // 
            // c_kullanici_id
            // 
            this.c_kullanici_id.DataPropertyName = "kullanici_id";
            this.c_kullanici_id.HeaderText = "Kullanıcı Id";
            this.c_kullanici_id.Name = "c_kullanici_id";
            this.c_kullanici_id.ReadOnly = true;
            this.c_kullanici_id.Visible = false;
            // 
            // c_duzenle
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.c_duzenle.DefaultCellStyle = dataGridViewCellStyle1;
            this.c_duzenle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.c_duzenle.HeaderText = "";
            this.c_duzenle.Name = "c_duzenle";
            this.c_duzenle.ReadOnly = true;
            this.c_duzenle.Width = 25;
            // 
            // c_sil
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            this.c_sil.DefaultCellStyle = dataGridViewCellStyle2;
            this.c_sil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.c_sil.HeaderText = "";
            this.c_sil.Name = "c_sil";
            this.c_sil.ReadOnly = true;
            this.c_sil.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_sil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.c_sil.Width = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(880, 235);
            this.Controls.Add(this.dgvAlSaat);
            this.Controls.Add(this.dgvVeri);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.tkvm);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etkinlik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlSaat)).EndInit();
            this.cms_ayar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void Ni_sistem_BalloonTipClicked(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.MonthCalendar tkvm;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgvVeri;
        private System.Windows.Forms.DataGridView dgvAlSaat;
        private System.Windows.Forms.Timer saatKac;
        private System.Windows.Forms.NotifyIcon ni_sistem;
        private System.Windows.Forms.ContextMenuStrip cms_ayar;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gizleToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn al_saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail_durum;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail_konu;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail_icerik;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_bas_saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_et;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_bit_tar;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_bit_saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_al_tar;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_al_saat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn c_mail_durum;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_mail_konu;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_mail_icerik;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_bas_tar;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_kullanici_id;
        private System.Windows.Forms.DataGridViewButtonColumn c_duzenle;
        private System.Windows.Forms.DataGridViewButtonColumn c_sil;
    }
}

