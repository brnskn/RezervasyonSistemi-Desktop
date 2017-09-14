using System;
using System.Collections.Generic;

namespace RezervasyonSistemiClient.Models
{
    public partial class Isletmeler
    {
        public int ID { get; set; }
        public string IsletmeIsmi { get; set; }
        public string IsletmeAdresi { get; set; }
        public string IsletmeAciklamasi { get; set; }
        public string IsletmeNumarasi { get; set; }
        public string IsletmeKrokiResim { get; set; }
    }
}
