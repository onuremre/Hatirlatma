using System;
using System.Media;
using System.Windows.Forms;
using System.Net.Mail;
using Microsoft.Win32;
using System.Threading.Tasks;

namespace Hatirlatma
{
    public partial class Form1 : Form
    {
        int kullanici_id = 0;
        string ad;
        string mail = " ";
        string tarih = DateTime.Now.ToString("yyyy-MM-dd");
        string bugun = DateTime.Now.ToString("yyyy-MM-dd");
        SoundPlayer alarm = new SoundPlayer();
        MSSQLVeritabani sql = new MSSQLVeritabani();
        public Form1()
        {
            InitializeComponent();
            saatKac.Tick += async (sender, e) => { await saatKac_Tick(sender, e); };
        }
        void listeleme(int kul_id, string bas_tarih)
        {
            dgvVeri.DataSource = sql.etkinlikler_goster(kul_id,bas_tarih);
            if (dgvVeri.CurrentRow != null)
                foreach(DataGridViewRow dr in dgvVeri.Rows)
                {
                    dr.Cells["c_sil"].Value = "X";
                }
        }
        void alarm_saat(int kul_id, string alarm_tarih)
        {
            
            dgvAlSaat.DataSource = sql.alarmlar_goster(kul_id, alarm_tarih);

        }
        void sil(int id)
        {
            if (MessageBox.Show("Bu etkinliği silmek istediğinize emin misiniz", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql.etkinlik_sil(id);
            }
        }

        public void Gonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("hatirlatmauygulamasi@gmail.com");
            ePosta.To.Add(mail);
            ePosta.Subject = konu;
            ePosta.Body = icerik;
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("hatirlatmauygulamasi@gmail.com", "27.12.2018");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(ePosta);
            }
            catch (Exception)
            {
                MessageBox.Show("Mail gönderilemedi. Aktif bir internet bağlantınız olduğundan emin olun");
            }
        }


        void muzik()
        {
            alarm.SoundLocation = @"C:\Users\Çâker-i Cedd\Documents\Projeler\Hatirlatma\Hatirlatma\alarm2.wav";
            alarm.Play();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            /*RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            key.SetValue("Hatirlatma", "\"" + Application.ExecutablePath + "\"");*/
            Giris frm = new Giris();
            frm.ShowDialog();
            kullanici_id = frm.id_dondur();
            ad = frm.ad_dondur();
            mail = frm.mail_dondur();
            if (kullanici_id != 0)
            {
                listeleme(kullanici_id, tarih);
                //alarm_saat(kullanici_id, bugun);
            }
        }
        private void tkvm_DateChanged(object sender, DateRangeEventArgs e)
        {
            tarih = tkvm.SelectionStart.Date.ToString("yyyy-MM-dd");
            listeleme(kullanici_id, tarih);
            alarm_saat(kullanici_id, bugun);
        }
        private void dgvVeri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==1)
            {
                sil(Convert.ToInt32(dgvVeri.CurrentRow.Cells["c_id"].Value));
                listeleme(kullanici_id, tarih);
            }
            else if(e.ColumnIndex == 0)
            {
                Duzenle frm = new Duzenle(Convert.ToInt32(dgvVeri.CurrentRow.Cells["c_id"].Value));
                frm.ShowDialog();
                listeleme(kullanici_id, tarih);
                alarm_saat(kullanici_id, bugun);
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle frm = new Ekle(kullanici_id);
            frm.ShowDialog();
            listeleme(kullanici_id, tarih);
            alarm_saat(kullanici_id, bugun);
        }
        private async Task saatKac_Tick(object sender, EventArgs e)
        {
            alarm_saat(kullanici_id, bugun);
            foreach (DataGridViewRow dr in dgvAlSaat.Rows)
            {
                if (dr.Cells["al_saat"].Value.ToString() == DateTime.Now.ToLongTimeString())
                {
                    ni_sistem.ShowBalloonTip(60000, "Hatırlatma", dr.Cells["aciklama"].Value.ToString(), ToolTipIcon.Info);
                    muzik();
                    if (dr.Cells["mail_durum"].Value.ToString() == "1")
                    {
                        await Task.Run(() => Gonder(dr.Cells["mail_konu"].Value.ToString(), dr.Cells["mail_icerik"].Value.ToString()));
                    }

                }
            }
        }
        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }
        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ni_sistem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void ni_sistem_BalloonTipClicked_1(object sender, EventArgs e)
        {
            alarm.Stop();
            this.Show();
        }
        private void ni_sistem_BalloonTipClosed(object sender, EventArgs e)
        {
            alarm.Stop();
        }
    }
}