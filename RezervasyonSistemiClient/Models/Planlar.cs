using System;
using RestSharp;

namespace RezervasyonSistemi.Models
{
    public partial class Planlar
    {
        public int ID { get; set; }
        public string PlanIsmi { get; set; }
        public string PlanAciklamasi { get; set; }
        public Nullable<int> IsletmeID { get; set; }
    }
}
