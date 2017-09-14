using RestSharp;
using RezervasyonSistemiClient.Models;
using RezervasyonSistemiClient.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezervasyonSistemiClient.Masa
{
    public partial class MasaDuzenle : Form
    {
        MasaBilgileri masaBilgileri;
        int IsletmeID;
        public MasaDuzenle(MasaBilgileri masaBilgileri, int IsletmeID)
        {
            InitializeComponent();
            this.masaBilgileri = masaBilgileri;
            this.IsletmeID = IsletmeID;
            LoadIsletme();
            isletmeCombo.SelectedValue = IsletmeID;
            masaIsmiText.Text = masaBilgileri.MasaIsmi;
            masaNumarasiText.Value = Convert.ToDecimal(masaBilgileri.MasaNumarasi);
        }
        private void LoadIsletme()
        {
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/Isletme", Method.GET);
            request.AddHeader("Authorization", "Bearer " + Settings.Default.access_token);
            Console.WriteLine(Settings.Default.access_token);
            IRestResponse<List<Isletmeler>> response = client.Execute<List<Isletmeler>>(request);

            LoadKatBilgileri(IsletmeID);
            isletmeCombo.DataSource = response.Data;
            isletmeCombo.ValueMember = "ID";
            isletmeCombo.DisplayMember = "IsletmeIsmi";
        }
        private void LoadKatBilgileri(int IsletmeID)
        {
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/KatBilgileri?IsletmeID={IsletmeID}", Method.GET);
            request.AddUrlSegment("IsletmeID", Convert.ToString(IsletmeID));
            request.AddHeader("Authorization", "Bearer " + Settings.Default.access_token);
            Console.WriteLine(Settings.Default.access_token);


            IRestResponse<List<KatBilgileri>> response = client.Execute<List<KatBilgileri>>(request);
            katCombo.DataSource = response.Data;
            katCombo.ValueMember = "ID";
            katCombo.DisplayMember = "KatIsmi";
            katCombo.SelectedValue = masaBilgileri.KatID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            masaBilgileri.MasaIsmi = masaIsmiText.Text;
            masaBilgileri.MasaNumarasi = Convert.ToInt32(masaNumarasiText.Text);

            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/MasaBilgileri", Method.PUT);
            request.AddHeader("Authorization", "Bearer " + Settings.Default.access_token);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(masaBilgileri);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Masa Bilgisi Düzenlendi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bir hata oluştu!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
