using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using TelefonRehberi.Entities; // RehberKayit fonksiyonu için çağırdık

namespace TelefonRehberi.BLL
{
    public class BusinessLogicLayer
    {
        // Üzerinde işlemler yapacağı data alıp data işleyeceği ilgili sınıf eklenir.
        TelefonRehberi.Core.DataBaseLogicLayer DLL;

        public BusinessLogicLayer()
        {
            DLL = new Core.DataBaseLogicLayer();
        }

        public int KullaniciKontrol(string KullaniciAdi, string Sifre)
        {
            int Sonuc = 0;

            if(!string.IsNullOrEmpty(KullaniciAdi) && !string.IsNullOrEmpty(Sifre))
            {
                Kullanici kullanici = new Kullanici();
                kullanici.KullaniciAdi = KullaniciAdi;
                kullanici.Sifre = Sifre;
                Sonuc = DLL.KullaniciKontrol(kullanici);
            }
            else
            {
                Sonuc = -100; // Eksik parametre hatası
            }

            return Sonuc;
        }

        public int YeniKayit(Guid ID, string Isim, string Soyisim, string TelefonI, string TelefonII, string Adres, string EmailAdres, string Website, string Aciklama)
        {
            int Sonuc = 0;
            if(ID != Guid.Empty && !string.IsNullOrEmpty(Isim) && !string.IsNullOrEmpty(Soyisim) && !string.IsNullOrEmpty(TelefonI))
            {
                RehberKayit Kayit = new RehberKayit();
                Kayit.ID = ID;
                Kayit.Isim = Isim;
                Kayit.Soyisim = Soyisim;
                Kayit.TelefonI = TelefonI;
                Kayit.TelefonII = TelefonII;
                Kayit.Adres = Adres;
                Kayit.EmailAdres = EmailAdres;
                Kayit.Website = Website;
                Kayit.Aciklama = Aciklama;

                Sonuc = DLL.YeniKayit(Kayit);
            }
            else
            {
                Sonuc = -100; // Eksik parametre hata kodu olarak ele alalım.
            }
            return Sonuc;
        }

        public int KayitGuncelle(Guid ID, string Isim, string Soyisim, string TelefonI, string TelefonII, string Adres, string EmailAdres, string Website, string Aciklama)
        {
            int Sonuc = 0;
            if(ID != Guid.Empty && !string.IsNullOrEmpty(Isim) && !string.IsNullOrEmpty(Soyisim) && !string.IsNullOrEmpty(TelefonI))
            {
                RehberKayit Kayit = new RehberKayit();
                Kayit.ID = ID;
                Kayit.Isim = Isim;
                Kayit.Soyisim = Soyisim;
                Kayit.TelefonI = TelefonI;
                Kayit.TelefonII = TelefonII;
                Kayit.Adres = Adres;
                Kayit.EmailAdres = EmailAdres;
                Kayit.Website = Website;
                Kayit.Aciklama = Aciklama;

                Sonuc = DLL.KayitGuncelleme(Kayit);
            }
            else
            {
                Sonuc = -100;
            }

            return Sonuc;
        }

        public int KayitSil(Guid ID)
        {
            return DLL.KayitSil(ID);
        }

        public List<RehberKayit> RehberKayitlariGetir()
        {
            return DLL.RehberKayitlariGetir();
        }

        public int XMLDataVer()
        {
            int Sonuc = 0;
            try
            {
                List<RehberKayit> Kayitlarim = DLL.RehberKayitlariGetir();

                XDocument Doc = new XDocument(new XDeclaration("1.0.0.1", "UTF-8", "yes"), 
                    new XElement("RehberKayitlar", Kayitlarim.Select(I => new XElement("Kayit", new XElement("ID", I.ID), 
                    new XElement("Isim", I.Isim), 
                    new XElement("Soyisim", I.Soyisim), 
                    new XElement("TelefonI", I.TelefonI), 
                    new XElement("TelefonII", I.TelefonII), 
                    new XElement("EmailAdres", I.EmailAdres), 
                    new XElement("Adres", I.Adres), 
                    new XElement("WebSite", I.Website), 
                    new XElement("Aciklama", I.Aciklama)))));
                Doc.Save(@"c:\TelefonRehberiDB\DataVerXML.xml");
                Sonuc = 1;

            }
            catch (Exception)
            {
                Sonuc = 0;
            }
            return Sonuc;
        }

        public int CSVDataVer()
        {
            int Sonuc = 0;
            try
            {
                List<RehberKayit> Kayitlar = DLL.RehberKayitlariGetir();
                StreamWriter SW = new StreamWriter(@"c:\TelefonRehberiDB\DataVerCSV.csv");
                CsvHelper.CsvWriter Write = new CsvHelper.CsvWriter(SW);
                Write.WriteHeader(typeof(RehberKayit));
                foreach (var item in Kayitlar)
                {
                    Write.WriteRecord(item);
                }
                SW.Close();
                Sonuc = 1;
            }
            catch (Exception)
            {
                Sonuc = 0;
            }
            return Sonuc;
        }

        public int JsonDataVer()
        {
            int Sonuc = 0;
            try
            {
                List<RehberKayit> Kayitlar = DLL.RehberKayitlariGetir();
                string JsonText = Newtonsoft.Json.JsonConvert.SerializeObject(Kayitlar);
                File.WriteAllText(@"c:\TelefonRehberiDB\DataVerJSON.json", JsonText);
                Sonuc = 1;
            }
            catch (Exception ex)
            {
                Sonuc = 0;
            }
            return Sonuc;
        }
    }
}
