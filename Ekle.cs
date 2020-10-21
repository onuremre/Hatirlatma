using System;
using System.Windows.Forms;

namespace Hatirlatma
{
    public partial class Ekle : Form
    {
        int kullanici_id;
        MSSQLVeritabani sql = new MSSQLVeritabani();
        Kontrol kontrol = new Kontrol();
        

        public Ekle(int kul_id)
        {
            InitializeComponent();
            kullanici_id = kul_id;
            t_konu.Enabled = false;
            t_icerik.Enabled = false;
        }
        private void c_mail_CheckedChanged(object sender, EventArgs e)
        {
            if(c_mail.Checked == true)
            {
                t_konu.Enabled = true;
                t_icerik.Enabled = true;
            }
            else
            {
                t_konu.Enabled = false;
                t_icerik.Enabled = false;
            }
        }
        private void b_ekle_Click(object sender, EventArgs e)
        {
            if (kontrol.saat_kontrol(t_bas_saat.Text) && kontrol.saat_kontrol(t_bit_saat.Text) && kontrol.saat_kontrol(t_al_saat.Text))
            {
                sql.etkinlik_ekle(d_bas_tar.Text, t_bas_saat.Text, d_bit_tar.Text, t_bit_saat.Text, d_al_tar.Text, t_al_saat.Text, t_etkinlik.Text, (int)c_mail.CheckState, t_konu.Text, t_icerik.Text, kullanici_id);
                this.Close();
            }
        }
    }
}
