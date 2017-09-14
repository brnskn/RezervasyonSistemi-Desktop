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
    public partial class IsletmeDuzenle : Form
    {
        Isletmeler isletme;
        public IsletmeDuzenle(Isletmeler isletme)
        {
            InitializeComponent();
            this.isletme = isletme;
            isletmeIsmiText.Text = isletme.IsletmeIsmi;
            isletmeNumarasiText.Text = isletme.IsletmeNumarasi;
            isletmeAciklamasiText.Text = isletme.IsletmeAciklamasi;
            isletmeAdresiText.Text = isletme.IsletmeAdresi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isletme.IsletmeAciklamasi = isletmeAciklamasiText.Text;
            isletme.IsletmeAdresi = isletmeAdresiText.Text;
            isletme.IsletmeIsmi = isletmeIsmiText.Text;
            isletme.IsletmeNumarasi = isletmeNumarasiText.Text;

            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/Isletme", Method.PUT);
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(isletme);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("İşletme Düzenlendi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bir hata oluştu!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
