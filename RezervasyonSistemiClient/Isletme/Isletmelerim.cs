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
    public partial class Isletmelerim : Form
    {
        IRestResponse<List<Isletmeler>> response;
        public Isletmelerim()
        {
            InitializeComponent();
            LoadIsletme();
        }

        private void LoadIsletme()
        {
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/Isletme", Method.GET);
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);

            response = client.Execute<List<Isletmeler>>(request);
            isletmeData.DataSource = response.Data;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/Isletme/{ID}", Method.DELETE);
            request.AddUrlSegment("ID", Convert.ToString(((Isletmeler)isletmeData.CurrentRow.DataBoundItem).ID));
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("İşletme Silindi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadIsletme();
            }
            else
            {
                MessageBox.Show("Bir hata oluştu!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            IsletmeDuzenle isletme = new IsletmeDuzenle(response.Data.First(x=>x.ID==Convert.ToInt32(((Isletmeler)isletmeData.CurrentRow.DataBoundItem).ID)));
            DialogResult dr = isletme.ShowDialog();
            if (dr == DialogResult.Abort || dr == DialogResult.Cancel || dr == DialogResult.OK || dr == DialogResult.None)
            {
                LoadIsletme();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsletmeEkle isletmeEkle = new IsletmeEkle();
            DialogResult dr = isletmeEkle.ShowDialog();
            if(dr == DialogResult.Abort || dr==DialogResult.Cancel || dr==DialogResult.OK || dr==DialogResult.None)
            {
                LoadIsletme();
            }
        }
    }
}
