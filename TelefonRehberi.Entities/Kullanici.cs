using System;
using System.Collections.Generic;
using System.Text;

namespace TelefonRehberi.Entities
{
    public class Kullanici
    {
        public Guid ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
