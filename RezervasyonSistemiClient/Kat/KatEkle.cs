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

namespace RezervasyonSistemiClient.Kat
{
    public partial class KatEkle : Form
    {
        public KatEkle()
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

            isletmeCombo.DataSource = response.Data;
            isletmeCombo.ValueMember = "ID";
            isletmeCombo.DisplayMember = "IsletmeIsmi";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            KatBilgileri newKat = new KatBilgileri();
            newKat.IsletmeID = Convert.ToInt32(isletmeCombo.SelectedValue);
            newKat.KatIsmi = katIsmiText.Text;

            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/KatBilgileri", Method.POST);
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(newKat);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Kat Bilgisi Eklendi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bir hata oluştu!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
