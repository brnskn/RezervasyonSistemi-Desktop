using System;
using System.Collections.Generic;

namespace RezervasyonSistemiClient.Models
{
    public partial class MasaBilgileri
    {
        public int ID { get; set; }
        public string MasaIsmi { get; set; }
        public Nullable<int> MasaNumarasi { get; set; }
        public Nullable<int> KatID { get; set; }
    }
}
