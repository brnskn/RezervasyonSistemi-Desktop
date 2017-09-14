using System;
using System.Collections.Generic;

namespace RezervasyonSistemiClient.Models
{
    public partial class KatBilgileri
    {

        public int ID { get; set; }
        public string KatIsmi { get; set; }
        public Nullable<int> IsletmeID { get; set; }
    }
}
