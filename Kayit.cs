using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Hatirlatma
{
    public partial class Kayit : Form
    {
        int flag1 = 0;
        int flag2 = 0;
        public Kayit()
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
                throw new ArgumentNullException("Şifrelenecek Veri Yok");
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

        private void b_kayit_Click(object sender, EventArgs e)
        {
            flag1 = 0;
            flag2 = 0;
            if (t_sifre.Text == t_sifre_t.Text && t_ad.Text != "" && t_mail.Text != "")
            {
                foreach (DataGridViewRow dr in dgvKullanici.Rows)
                {
                    if (dr.Cells["ad"].Value.ToString() == t_ad.Text)
                    {
                        flag1 = 1;
                    }
                    if (dr.Cells["mail"].Value.ToString() == t_mail.Text)
                    {
                        flag2 = 1;
                    }
                }
                if (flag1 == 0 && flag2 == 0)
                {
                    MSSQLVeritabani sql = new MSSQLVeritabani();
                    sql.kullanici_ekle(t_ad.Text, SHA256(t_sifre.Text), t_mail.Text);
                    MessageBox.Show("Kayıt Başarılı");
                    this.Close();
                }
                else if (flag1 == 1 && flag2 == 1)
                {
                    MessageBox.Show("Bu kullanıcı adı ve mail adresi sistemimize kayıtlı");
                }
                else if (flag1 == 1 && flag2 == 0)
                {
                    MessageBox.Show("Bu kullanıcı adı sistemimize kayıtlı");
                }
                else
                {
                    MessageBox.Show("Bu mail adresi sistemimize kayıtlı");
                }
            }
            else
            {
                MessageBox.Show("Şifreler aynı değil veya bir giriş alanı boş bırakılmış");
            }
        }
        private void b_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kayit_Load(object sender, EventArgs e)
        {
            MSSQLVeritabani sql = new MSSQLVeritabani();
            dgvKullanici.DataSource = sql.kullanicilar_goster();
        }
    }
}
