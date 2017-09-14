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

namespace RezervasyonSistemiClient.Kat
{
    public partial class KatListesi : Form
    {
        int SonIsletmeID;
        public KatListesi()
        {
            InitializeComponent();
            LoadIsletme();
        }
        private void LoadIsletme()
        {
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/Isletme", Method.GET);
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);
            var response = client.Execute<List<Isletmeler>>(request);

            LoadKatBilgileri(response.Data[0].ID);
            isletmeCombo.DataSource = response.Data;
            isletmeCombo.ValueMember = "ID";
            isletmeCombo.DisplayMember = "IsletmeIsmi";
        }
        private void LoadKatBilgileri(int IsletmeID)
        {
            SonIsletmeID = IsletmeID;
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/KatBilgileri?IsletmeID={IsletmeID}", Method.GET);
            request.AddUrlSegment("IsletmeID", Convert.ToString(IsletmeID));
            request.AddHeader("Authorization", "Bearer " + Settings.Default.access_token);
            Console.WriteLine(Settings.Default.access_token);
            IRestResponse<List<KatBilgileri>> response = client.Execute<List<KatBilgileri>>(request);

            katData.DataSource = response.Data;
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

        private void button1_Click(object sender, EventArgs e)
        {
            KatEkle katEkle = new KatEkle();
            DialogResult dr = katEkle.ShowDialog();
            if (dr == DialogResult.Abort || dr == DialogResult.Cancel || dr == DialogResult.OK || dr == DialogResult.None)
            {
                LoadKatBilgileri(SonIsletmeID);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/KatBilgileri/{ID}", Method.DELETE);
            request.AddUrlSegment("ID", Convert.ToString(((KatBilgileri)katData.CurrentRow.DataBoundItem).ID));
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Kat Bilgisi Silindi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKatBilgileri(SonIsletmeID);
            }
            else
            {
                MessageBox.Show("Bir hata oluştu!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            KatDuzenle katDuzenle = new KatDuzenle((KatBilgileri)katData.CurrentRow.DataBoundItem);
            DialogResult dr = katDuzenle.ShowDialog();
            if (dr == DialogResult.Abort || dr == DialogResult.Cancel || dr == DialogResult.OK || dr == DialogResult.None)
            {
                LoadKatBilgileri(SonIsletmeID);
            }
        }
    }
}
