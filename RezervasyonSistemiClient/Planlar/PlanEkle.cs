using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezervasyonSistemiClient.Planlar
{
    public partial class PlanEkle : Form
    {
        int IsletmeID;
        public PlanEkle(int IsletmeID)
        {
            InitializeComponent();
            this.IsletmeID = IsletmeID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RezervasyonSistemi.Models.Planlar Planlar = new RezervasyonSistemi.Models.Planlar();
            Planlar.IsletmeID = IsletmeID;
            Planlar.PlanIsmi = planIsmiText.Text;
            Planlar.PlanAciklamasi = planAciklamasiText.Text;
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/Plan", Method.POST);
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(Planlar);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Plan Eklendi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bir hata oluştu!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
