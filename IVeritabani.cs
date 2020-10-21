using System.Collections;
using System.Collections.Generic;

namespace Hatirlatma
{
    public interface IVeritabani
    {
        List<Kullanici> kullanicilar_goster();
        void kullanici_ekle(string ad, string sifre, string mail);
        ArrayList kullanici_goster(string ad, string sifre);

        List<Etkinlik> etkinlikler_goster(int kullanici_id, string bas_tarih);
        List<Etkinlik> alarmlar_goster(int kullanici_id, string al_tarih);
        List<Etkinlik> etkinlik_goster(int id);
        void etkinlik_ekle(string bas_tarih, string bas_saat, string bit_tarih, string bit_saat, string al_tarih, string al_saat, string aciklama, int mail_durum, string mail_konu, string mail_icerik, int kullanici_id);
        void etkinlik_guncelle(string bas_tarih, string bas_saat, string bit_tarih, string bit_saat, string al_tarih, string al_saat, string aciklama, int mail_durum, string mail_konu, string mail_icerik, int id);
        void etkinlik_sil(int id);
    }
}
