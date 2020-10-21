using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hatirlatma
{
    public class Kontrol
    {
        public bool saat_kontrol(string i)
        {
            string[] saat = i.Split(':');
            if (i.Length != 3 && Convert.ToInt32(saat[0]) < 24 && Convert.ToInt32(saat[0]) >=0 && Convert.ToInt32(saat[1]) < 60 && Convert.ToInt32(saat[1]) >= 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Saat değerleri hatalı veya boş");
                return false;
            }
        }
    }
}
