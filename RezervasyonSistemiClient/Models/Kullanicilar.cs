using System;
using System.Collections.Generic;

namespace RezervasyonSistemiClient.Models
{
    public partial class Kullanicilar
    {
  
        public int ID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Mail { get; set; }
        public string TelefonNumarasi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public Nullable<System.DateTime> OlusturmaTarihi { get; set; }
        public Nullable<bool> KullaniciTipi { get; set; }
    }
}
