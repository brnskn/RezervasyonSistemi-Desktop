using System;
using System.Collections.Generic;

namespace RezervasyonSistemi.Models
{
    public partial class PlanDetaylari
    {
        public int ID { get; set; }
        public Nullable<int> HaftaninGunu { get; set; }
        public string BaslangicSaati { get; set; }
        public string BitisSaati { get; set; }
        public Nullable<int> PlanID { get; set; }
    }
}
