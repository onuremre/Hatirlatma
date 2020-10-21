using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;

namespace Hatirlatma
{
    public class MSSQLVeritabani : IVeritabani
    {
        SqlConnection baglanti = new SqlConnection("Data Source = ASUS\\SQLEXPRESS; Initial Catalog = Etkinlik; Integrated Security = True");

        public List<Etkinlik> alarmlar_goster(int kullanici_id, string al_tarih)
        {
            List<Etkinlik> liste = new List<Etkinlik>();
            liste.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("exec sp_alarmlar_goster " + kullanici_id + ",'" + al_tarih + "'", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Etkinlik etkinlik = new Etkinlik();
                etkinlik.al_saat = dr[0].ToString();
                etkinlik.mail_durum = Convert.ToInt32(dr[1]);
                etkinlik.mail_konu = dr[2].ToString();
                etkinlik.mail_icerik = dr[3].ToString();
                etkinlik.aciklama = dr[4].ToString();
                liste.Add(etkinlik);
            }
            baglanti.Close();
            return liste;
        }

        public List<Etkinlik> etkinlikler_goster(int kullanici_id, string bas_tarih)
        {
            List<Etkinlik> liste = new List<Etkinlik>();
            liste.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("exec sp_etkinlikler_goster " + kullanici_id + ",'" + bas_tarih + "'", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Etkinlik etkinlik = new Etkinlik();
                etkinlik.id = Convert.ToInt32(dr[0]);
                etkinlik.bas_saat = dr[1].ToString();
                etkinlik.aciklama = dr[2].ToString();
                etkinlik.bit_tarih = dr[3].ToString();
                etkinlik.bit_saat = dr[4].ToString();
                etkinlik.al_tarih = dr[5].ToString();
                etkinlik.al_saat = dr[6].ToString();
                etkinlik.mail_durum = Convert.ToInt32(dr[7]);
                etkinlik.mail_konu = dr[8].ToString();
                etkinlik.mail_icerik = dr[9].ToString();

                liste.Add(etkinlik);
            }
            baglanti.Close();
            return liste;
        }

        public void etkinlik_ekle(string bas_tarih, string bas_saat, string bit_tarih, string bit_saat, string al_tarih, string al_saat, string aciklama, int mail_durum, string mail_konu, string mail_icerik, int kullanici_id)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("exec sp_etkinlik_ekle '" + bas_tarih + "','" + bas_saat + "','" + bit_tarih + "','" + bit_saat + "','" + al_tarih + "','" + al_saat + "','" + aciklama + "',"+mail_durum+",'" + mail_konu + "','" + mail_icerik + "'," + kullanici_id, baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        public List<Etkinlik> etkinlik_goster(int id)
        {
            List<Etkinlik> liste = new List<Etkinlik>();
            liste.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("exec sp_etkinlik_goster " + id, baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Etkinlik etkinlik = new Etkinlik();
                etkinlik.bas_tarih = dr[0].ToString();
                etkinlik.bas_saat = dr[1].ToString();
                etkinlik.aciklama = dr[2].ToString();
                etkinlik.bit_tarih = dr[3].ToString();
                etkinlik.bit_saat = dr[4].ToString();
                etkinlik.al_tarih = dr[5].ToString();
                etkinlik.al_saat = dr[6].ToString();
                etkinlik.mail_durum = Convert.ToInt32(dr[7]);
                etkinlik.mail_konu = dr[8].ToString();
                etkinlik.mail_icerik = dr[9].ToString();

                liste.Add(etkinlik);
            }
            baglanti.Close();
            return liste;
        }

        public void etkinlik_guncelle(string bas_tarih, string bas_saat, string bit_tarih, string bit_saat, string al_tarih, string al_saat, string aciklama, int mail_durum, string mail_konu, string mail_icerik, int id)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("exec sp_etkinlik_guncelle '" + bas_tarih + "','" + bas_saat + "','" + bit_tarih + "','" + bit_saat + "','" + al_tarih + "','" + al_saat + "','" + aciklama + "'," + mail_durum + ",'" + mail_konu + "','" + mail_icerik + "'," + id, baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        public void etkinlik_sil(int id)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("exec sp_etkinlik_sil " + id, baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        public List<Kullanici> kullanicilar_goster()
        {
            List<Kullanici> liste = new List<Kullanici>();
            liste.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("exec sp_kullanicilar_goster ", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Kullanici kullanici = new Kullanici();
                kullanici.ad = dr[0].ToString();
                kullanici.mail = dr[1].ToString();

                liste.Add(kullanici);
            }
            baglanti.Close();
            return liste;
        }

        public void kullanici_ekle(string ad, string sifre, string mail)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("exec sp_kullanici_ekle '" + ad + "','" + sifre + "','" + mail + "'", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        public ArrayList kullanici_goster(string ad, string sifre)
        {
            ArrayList arraylist = new ArrayList();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("exec sp_kullanici_goster '" + ad + "','" + sifre + "'", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Kullanici kullanici = new Kullanici();
                kullanici.id = Convert.ToInt32(dr[0]);
                kullanici.ad = dr[1].ToString();
                kullanici.mail = dr[2].ToString();
                arraylist.Add(kullanici.id);
                arraylist.Add(kullanici.ad);
                arraylist.Add(kullanici.mail);
            }
            baglanti.Close();
            if (arraylist.Capacity.ToString() == "0")
            {
                arraylist.Add(0);
            }
            return arraylist;
        }
    }
}
