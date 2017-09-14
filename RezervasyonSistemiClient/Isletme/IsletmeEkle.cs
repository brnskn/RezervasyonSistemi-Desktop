using RestSharp;
using RezervasyonSistemiClient.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezervasyonSistemiClient.Isletme
{
    public partial class IsletmeEkle : Form
    {
        public IsletmeEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Isletmeler newIsletme = new Isletmeler();
            newIsletme.IsletmeAciklamasi = isletmeAciklamasiText.Text;
            newIsletme.IsletmeAdresi = isletmeAdresiText.Text;
            newIsletme.IsletmeIsmi = isletmeIsmiText.Text;
            newIsletme.IsletmeNumarasi = isletmeNumarasiText.Text;

            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/Isletme", Method.POST);
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(newIsletme);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("İşletme Eklendi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bir hata oluştu!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
