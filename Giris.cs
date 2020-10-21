using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Hatirlatma
{
    public partial class Giris : Form
    {
        ArrayList arraylist = new ArrayList();
        int id=0;
        string ad;
        string mail;
        public Giris()
        {
            InitializeComponent();
        }

        //Şifreleme Başlangıç
        public static byte[] ByteDonustur(string deger)
        {

            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            return ByteConverter.GetBytes(deger);

        }
        public static byte[] Byte8(string deger)
        {
            char[] arrayChar = deger.ToCharArray();
            byte[] arrayByte = new byte[arrayChar.Length];
            for (int i = 0; i < arrayByte.Length; i++)
            {
                arrayByte[i] = Convert.ToByte(arrayChar[i]);
            }
            return arrayByte;
        }
        public string SHA256(string strGiris)
        {
            if (strGiris == "" || strGiris == null)
            {
                return "Hata";
            }
            else
            {
                SHA256Managed sifre = new SHA256Managed();
                byte[] arySifre = ByteDonustur(strGiris);
                byte[] aryHash = sifre.ComputeHash(arySifre);
                return BitConverter.ToString(aryHash);
            }
        }
        //Şifreleme Bitiş

        private void b_giris_Click(object sender, EventArgs e)
        {
            MSSQLVeritabani sql = new MSSQLVeritabani();
            arraylist=sql.kullanici_goster(t_ad.Text, SHA256(t_sifre.Text));
            id = Convert.ToInt32(arraylist[0]);
            if(id != 0){
                ad = arraylist[1].ToString();
                mail = arraylist[2].ToString();
                id_dondur();
                ad_dondur();
                mail_dondur();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }
            
        }
        public int id_dondur()
        {
            return id;
        }
        public string ad_dondur()
        {
            return ad;
        }
        public string mail_dondur()
        {
            return mail;
        }
        private void b_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void l_kayit_Click(object sender, EventArgs e)
        {
            Kayit frm = new Kayit();
            frm.ShowDialog();
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Giris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {

                Application.Exit();

            }
        }
    }
}