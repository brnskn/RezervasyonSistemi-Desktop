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
    public partial class MasaEkle : Form
    {
        public MasaEkle()
        {
            InitializeComponent();
            LoadIsletme();
        }
        private void LoadIsletme()
        {
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/Isletme", Method.GET);
            request.AddHeader("Authorization", "Bearer " + Settings.Default.access_token);
            Console.WriteLine(Settings.Default.access_token);
            IRestResponse<List<Isletmeler>> response = client.Execute<List<Isletmeler>>(request);

            LoadKatBilgileri(response.Data[0].ID);
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MasaBilgileri newMasa = new MasaBilgileri();
            newMasa.KatID = Convert.ToInt32(katCombo.SelectedValue);
            newMasa.MasaIsmi = masaIsmiText.Text;
            newMasa.MasaNumarasi = Convert.ToInt32(masaNumarasiText.Text);

            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/MasaBilgileri", Method.POST);
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(newMasa);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Masa Bilgisi Eklendi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bir hata oluştu!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void isletmeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadKatBilgileri(Convert.ToInt32(isletmeCombo.SelectedValue));
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
