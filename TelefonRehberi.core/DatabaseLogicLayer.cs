using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Entities; // Entities Classı Bağlandı!

namespace TelefonRehberi.Core
{
    public class DataBaseLogicLayer
    {
        List<RehberKayit> Kayitlarim;
        public DataBaseLogicLayer()
        {
            Kayitlarim = new List<RehberKayit>();
            VeriTabaniKontrol();
        }

        private void VeriTabaniKontrol()
        {
            bool KlasorKontrol = Directory.Exists(@"c:\TelefonRehberiDB\"); // Klasör var mı diye kontrol edilir
            if(!KlasorKontrol) // Eğer oluşturulan klasör yok ise
            {
                Directory.CreateDirectory(@"c:\TelefonRehberiDB\"); // Klasör oluşturuldu.

                // Program ile ilgili hiç bir dosya ve kullanıcı yok ise yeni bir dosya ve
                // kullanıcı ataması program tarafından otomatik olarak yapılır.
                Kullanici Demo = new Kullanici();
                Demo.ID = Guid.NewGuid();
                Demo.KullaniciAdi = "Demo";
                Demo.Sifre = "Demo";

                // Program admin bilgileri json olarak çevrilir.
                string JsonKullaniciText = Newtonsoft.Json.JsonConvert.SerializeObject(Demo);
                File.WriteAllText(@"c:\TelefonRehberiDB\kullanici.json", JsonKullaniciText);
            }
        }

        public int YeniKayit(RehberKayit K)
        {
            int sonuc = 0;
            try
            {
                // Class seviyesinde oluşturulmuş olan koleksiyonun içerisine data doldurulur (varsa)
                // Yoksa eğer zaten bellekte hiç bir değeri yoktu o şekilde yeni değer eklenmek üzere bekler.
                RehberKayitlariGetir();

                // Koleksiyonumuza değerimizi ekledik.
                Kayitlarim.Add(K);
                // Var ise üzerine yazıldı, yoksa yeni json verisi oluşturuldu.
                JsonDBGuncelle();

                sonuc = 1;
                
            }
            catch (Exception)
            {
                // Log kayıtları
                sonuc = 0;
            }
            return sonuc;
        }

        public int KayitGuncelleme(RehberKayit K)
        {
            int Sonuc = 0;
            try
            {
                RehberKayitlariGetir();
                int Index = Kayitlarim.FindIndex(I => I.ID == K.ID);
                if(Index > -1)
                {
                    Kayitlarim[Index].Isim = K.Isim;
                    Kayitlarim[Index].Soyisim = K.Soyisim;
                    Kayitlarim[Index].TelefonI = K.TelefonI;
                    Kayitlarim[Index].TelefonII = K.TelefonII;
                    Kayitlarim[Index].EmailAdres = K.EmailAdres;
                    Kayitlarim[Index].Website = K.Website;
                    Kayitlarim[Index].Adres = K.Adres;
                    Kayitlarim[Index].Aciklama = K.Aciklama;
                }
                JsonDBGuncelle();
                Sonuc = 1;
            }
            catch (Exception)
            {

                throw;
            }

            return Sonuc;
        }

        public int KayitSil(Guid ID)
        {
            int Sonuc = 0;
            try
            {
                RehberKayitlariGetir();
                RehberKayit SilinecekDeger = Kayitlarim.Find(I => I.ID == ID);

                // Bulunan değeri null kontrolünden geçirelim.
                if(SilinecekDeger != null)
                {
                    Kayitlarim.Remove(SilinecekDeger);
                }
                // Koleksiyonumuz son haliyle serialize edildi.
                JsonDBGuncelle();
                Sonuc = -1;
            }
            catch (Exception)
            {

                throw;
            }


            return Sonuc;
        }


        public List<RehberKayit> RehberKayitlariGetir()
        {
            if(File.Exists(@"c:\TelefonRehberiDB\Rehber.json"))
            {
                string JsonDBText = File.ReadAllText(@"c:\TelefonRehberiDB\Rehber.json");
                Kayitlarim = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RehberKayit>>(JsonDBText);
            }
            return Kayitlarim;
        }

        public int KullaniciKontrol(Kullanici kullanici)
        {
            int KullaniciSonuc = 0;
            // Dosya var mı diye kontrol edildi
            if(File.Exists(@"c:\TelefonRehberiDB\kullanici.json"))
            {
                // Önce dosya içindeki datamız text dosyasına çevrildi.
                string JsonKullaniciText = File.ReadAllText(@"c:\TelefonRehberiDB\kullanici.json");
                // Text dosyasını ise List generic halindeki veri yapısına çevrildi.
                List<Kullanici> Kullanicilar = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Kullanici>>(JsonKullaniciText);
                // FindAll ile koleksiyon döndürür. Parametre olarak gelen kullanıcı adına eşitse toliste çevir ve list generice çevir.
                KullaniciSonuc = Kullanicilar.FindAll(I => I.KullaniciAdi == kullanici.KullaniciAdi && I.Sifre == kullanici.Sifre).ToList().Count();
            }

            return KullaniciSonuc;
        }

        #region Yardımcı Metotlar 
        // Yapılan insert delete update gibi işlemlerde json dosyasını güncellemek  için
        // bir fonksiyon yazalım.
        private void JsonDBGuncelle()
        {
            if(Kayitlarim != null && Kayitlarim.Count > 0)
            {
                string JsonDB = Newtonsoft.Json.JsonConvert.SerializeObject(Kayitlarim);
                File.WriteAllText(@"c:\TelefonRehberiDB\Rehber.json", JsonDB);
            }
        }
        #endregion
    }
}
