using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatirlatma
{
    public class Etkinlik
    {
        public int id { get; set; }
        public string bas_tarih { get; set; }
        public string bas_saat { get; set; }
        public string bit_tarih { get; set; }
        public string bit_saat { get; set; }
        public string al_tarih { get; set; }
        public string al_saat { get; set; }
        public string aciklama { get; set; }
        public int mail_durum { get; set; }
        public string mail_konu { get; set; }
        public string mail_icerik { get; set; }
        public int kullanici_id { get; set; }
    }
}
