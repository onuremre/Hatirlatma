using System;
using System.Windows.Forms;

namespace Hatirlatma
{
    public partial class Duzenle : Form
    {
        int id;
        int mail;
        MSSQLVeritabani sql = new MSSQLVeritabani();
        Kontrol kontrol = new Kontrol();
        public Duzenle(int etkinlik_id)
        {
            InitializeComponent();
            id = etkinlik_id;
        }

        private void Duzenle_Load(object sender, EventArgs e)
        {
            dgvDuzenle.DataSource = sql.etkinlik_goster(id);
            d_bas_tar.Text = dgvDuzenle.CurrentRow.Cells["c_bas_tar"].Value.ToString();
            t_bas_saat.Text = dgvDuzenle.CurrentRow.Cells["c_bas_saat"].Value.ToString();
            d_bit_tar.Text = dgvDuzenle.CurrentRow.Cells["c_bit_tar"].Value.ToString();
            t_bit_saat.Text = dgvDuzenle.CurrentRow.Cells["c_bit_saat"].Value.ToString();
            d_al_tar.Text = dgvDuzenle.CurrentRow.Cells["c_al_tar"].Value.ToString();
            t_al_saat.Text = dgvDuzenle.CurrentRow.Cells["c_al_saat"].Value.ToString();
            t_etkinlik.Text = dgvDuzenle.CurrentRow.Cells["c_et"].Value.ToString();
            t_konu.Text = dgvDuzenle.CurrentRow.Cells["c_mail_konu"].Value.ToString();
            t_icerik.Text = dgvDuzenle.CurrentRow.Cells["c_mail_icerik"].Value.ToString();
            if (dgvDuzenle.CurrentRow.Cells["c_mail_durum"].Value.ToString() == "1")
            {
                c_mail.Checked = true;
                t_icerik.Enabled = true;
                t_konu.Enabled = true;
            }
            else
            {
                c_mail.Checked = false;
                t_icerik.Enabled = false;
                t_konu.Enabled = false;
            }
        }
        private void c_mail_CheckedChanged(object sender, EventArgs e)
        {
            if (c_mail.Checked == true)
            {
                t_konu.Enabled = true;
                t_icerik.Enabled = true;
            }
            else
            {
                t_konu.Enabled = false;
                t_konu.Text = "";
                t_icerik.Enabled = false;
                t_icerik.Text = "";
            }
        }
        private void b_duzenle_Click(object sender, EventArgs e)
        {
            if (c_mail.Checked == true)
            {
                mail = 1;
            }
            else
            {
                mail = 0;
            }
            if (kontrol.saat_kontrol(t_bas_saat.Text) && kontrol.saat_kontrol(t_bit_saat.Text) && kontrol.saat_kontrol(t_al_saat.Text))
            {
                sql.etkinlik_guncelle(d_bas_tar.Text,t_bas_saat.Text,d_bit_tar.Text,t_bit_saat.Text,d_al_tar.Text,t_al_saat.Text,t_etkinlik.Text,mail,t_konu.Text,t_icerik.Text,id);
                this.Close();
            }
        }
    }
}
