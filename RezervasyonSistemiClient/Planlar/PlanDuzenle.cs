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
    public partial class PlanDuzenle : Form
    {
        RezervasyonSistemi.Models.Planlar planlar;
        public PlanDuzenle(RezervasyonSistemi.Models.Planlar planlar)
        {
            InitializeComponent();
            this.planlar = planlar;
            planIsmiText.Text = planlar.PlanIsmi;
            planAciklamasiText.Text = planlar.PlanAciklamasi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            planlar.PlanIsmi = planIsmiText.Text;
            planlar.PlanAciklamasi = planAciklamasiText.Text;
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/Plan", Method.PUT);
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(planlar);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Plan Düzenlendi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bir hata oluştu!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
