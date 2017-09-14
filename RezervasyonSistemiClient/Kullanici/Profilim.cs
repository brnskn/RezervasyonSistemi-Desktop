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

namespace RezervasyonSistemiClient.Kullanici
{
    public partial class Profilim : Form
    {
        int ID;
        public Profilim()
        {
            InitializeComponent();
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/Kullanici", Method.GET);
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);

            IRestResponse<Kullanicilar> response = client.Execute<Kullanicilar>(request);

            ID = response.Data.ID;
            isimText.Text = response.Data.Isim;
            soyisimText.Text = response.Data.Soyisim;
            mailText.Text = response.Data.Mail;
            telefonNumarasiText.Text = response.Data.TelefonNumarasi;
            kullaniciAdiText.Text = response.Data.KullaniciAdi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanicilar = new Kullanicilar();
            kullanicilar.ID = ID;
            kullanicilar.Isim = isimText.Text;
            kullanicilar.Soyisim = soyisimText.Text;
            kullanicilar.Mail = mailText.Text;
            kullanicilar.TelefonNumarasi = telefonNumarasiText.Text;
            kullanicilar.KullaniciAdi = kullaniciAdiText.Text;

            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/Kullanici", Method.PUT);
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(kullanicilar);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Profiliniz Düzenlendi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bir hata oluştu!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
