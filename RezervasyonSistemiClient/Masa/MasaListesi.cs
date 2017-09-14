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
    public partial class MasaListesi : Form
    {
        int SonKatID;
        public MasaListesi()
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
            LoadMasaBilgileri(response.Data[0].ID);
            katCombo.DataSource = response.Data;
            katCombo.ValueMember = "ID";
            katCombo.DisplayMember = "KatIsmi";
        }
        private void LoadMasaBilgileri(int KatID)
        {
            SonKatID = KatID;
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/MasaBilgileri?KatID={KatID}", Method.GET);
            request.AddUrlSegment("KatID", Convert.ToString(KatID));
            request.AddHeader("Authorization", "Bearer " + Settings.Default.access_token);
            Console.WriteLine(Settings.Default.access_token);
            IRestResponse<List<MasaBilgileri>> response = client.Execute<List<MasaBilgileri>>(request);

            masaData.DataSource = response.Data;
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

        private void katCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadMasaBilgileri(Convert.ToInt32(katCombo.SelectedValue));
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MasaEkle masaEkle = new MasaEkle();
            DialogResult dr = masaEkle.ShowDialog();
            if (dr == DialogResult.Abort || dr == DialogResult.Cancel || dr == DialogResult.OK || dr == DialogResult.None)
            {
                LoadMasaBilgileri(SonKatID);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/MasaBilgileri/{ID}", Method.DELETE);
            request.AddUrlSegment("ID", Convert.ToString(((MasaBilgileri)masaData.CurrentRow.DataBoundItem).ID));
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Masa Bilgisi Silindi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMasaBilgileri(SonKatID);
            }
            else
            {
                MessageBox.Show("Bir hata oluştu!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            MasaDuzenle masaDuzenle = new MasaDuzenle((MasaBilgileri)masaData.CurrentRow.DataBoundItem, Convert.ToInt32(isletmeCombo.SelectedValue));
            DialogResult dr = masaDuzenle.ShowDialog();
            if (dr == DialogResult.Abort || dr == DialogResult.Cancel || dr == DialogResult.OK || dr == DialogResult.None)
            {
                LoadMasaBilgileri(SonKatID);
            }
        }
    }
}
