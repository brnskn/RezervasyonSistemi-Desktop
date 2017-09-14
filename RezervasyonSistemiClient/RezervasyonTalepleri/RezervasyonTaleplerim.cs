using RestSharp;
using RezervasyonSistemiClient.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RezervasyonSistemiClient.RezervasyonTalepleri
{
    public partial class RezervasyonTaleplerim : Form
    {
        enum HaftaninGunu
        {
            Pazartesi,
            Salı,
            Çarşamba,
            Perşembe,
            Cuma,
            Cumartesi,
            Pazar,
        }
        int CurrentIsletmeID;
        MasaBilgileri Masa;
        List<RezervasyonSistemi.Models.RezervasyonTalepleri> talepler;
        public RezervasyonTaleplerim()
        {
            InitializeComponent();
            LoadIsletme();
        }
        public RezervasyonTaleplerim(int IsletmeID, MasaBilgileri Masa)
        {
            InitializeComponent();
            LoadIsletme(IsletmeID);
            LoadTalepler(IsletmeID, Masa.ID);
            Console.WriteLine(IsletmeID + "\n" + Masa.ID);
            Text = Masa.MasaIsmi + " Rezervasyon Talepleri";
            this.Masa = Masa;
        }
        private void LoadIsletme()
        {
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/Isletme", Method.GET);
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);

            IRestResponse<List<Isletmeler>> response = client.Execute<List<Isletmeler>>(request);
            try
            {
                LoadTalepler(response.Data[0].ID);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            isletmeCombo.DataSource = response.Data;
            isletmeCombo.ValueMember = "ID";
            isletmeCombo.DisplayMember = "IsletmeIsmi";
        }
        private void LoadIsletme(int IsletmeID)
        {
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/Isletme", Method.GET);
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);

            IRestResponse<List<Isletmeler>> response = client.Execute<List<Isletmeler>>(request);
            isletmeCombo.DataSource = response.Data;
            isletmeCombo.ValueMember = "ID";
            isletmeCombo.DisplayMember = "IsletmeIsmi";
            try
            {
                isletmeCombo.SelectedValue = IsletmeID;
                isletmeCombo.Enabled = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void LoadTalepler(int IsletmeID)
        {
            CurrentIsletmeID = IsletmeID;
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/RezervasyonTalepleri?IsletmeID={IsletmeID}", Method.GET);
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);
            request.AddUrlSegment("IsletmeID", Convert.ToString(IsletmeID));

            IRestResponse<List<RezervasyonSistemi.Models.RezervasyonTalepleri>> response = client.Execute<List<RezervasyonSistemi.Models.RezervasyonTalepleri>>(request);
            talepler = response.Data;

            taleplerData.ColumnCount = 6;
            taleplerData.Columns[0].Name = "ID";
            taleplerData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            taleplerData.Columns[1].Name = "İsim";
            taleplerData.Columns[2].Name = "Masa İsmi";
            taleplerData.Columns[3].Name = "Masa Numarası";
            taleplerData.Columns[4].Name = "Tarih";
            taleplerData.Columns[5].Name = "Onay Durumu";
            taleplerData.Rows.Clear();
            foreach (RezervasyonSistemi.Models.RezervasyonTalepleri talep in response.Data)
            {
                taleplerData.Rows.Add(new string[] { Convert.ToString(talep.ID), talep.Kullanicilar.Isim+" "+ talep.Kullanicilar.Soyisim, talep.MasaBilgileri.MasaIsmi, Convert.ToString(talep.MasaBilgileri.MasaNumarasi), Convert.ToString(talep.Tarih), (talep.OnayDurumu == true) ? "Onaylandı" : "Onaylanmadı"});
            }
        }
        private void LoadTalepler(int IsletmeID, int MasaID)
        {
            CurrentIsletmeID = IsletmeID;
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/RezervasyonTalepleri?IsletmeID={IsletmeID}&MasaID={MasaID}", Method.GET);
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);
            request.AddUrlSegment("IsletmeID", Convert.ToString(IsletmeID));
            request.AddUrlSegment("MasaID", Convert.ToString(MasaID));

            IRestResponse<List<RezervasyonSistemi.Models.RezervasyonTalepleri>> response = client.Execute<List<RezervasyonSistemi.Models.RezervasyonTalepleri>>(request);
            talepler = response.Data;

            taleplerData.ColumnCount = 6;
            taleplerData.Columns[0].Name = "ID";
            taleplerData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            taleplerData.Columns[1].Name = "İsim";
            taleplerData.Columns[2].Name = "Masa İsmi";
            taleplerData.Columns[3].Name = "Masa Numarası";
            taleplerData.Columns[4].Name = "Tarih";
            taleplerData.Columns[5].Name = "Onay Durumu";
            try
            {
                taleplerData.Rows.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            foreach (RezervasyonSistemi.Models.RezervasyonTalepleri talep in response.Data)
            {
                taleplerData.Rows.Add(new string[] { Convert.ToString(talep.ID), talep.Kullanicilar.Isim + " " + talep.Kullanicilar.Soyisim, talep.MasaBilgileri.MasaIsmi, Convert.ToString(talep.MasaBilgileri.MasaNumarasi), Convert.ToString(talep.Tarih), (talep.OnayDurumu == true) ? "Onaylandı" : "Onaylanmadı" });
            }
        }

        private void taleplerData_SelectionChanged(object sender, EventArgs e)
        {
            if (talepler.Count == 0 || talepler[taleplerData.CurrentRow.Index] == null)
            {
                taleplerData.Rows.Clear();
            }else
            {
                RezervasyonSistemi.Models.RezervasyonTalepleri talep = talepler[taleplerData.CurrentRow.Index];
                isim.Text = talep.Kullanicilar.Isim + " " + talep.Kullanicilar.Soyisim;
                mail.Text = talep.Kullanicilar.Mail;
                telefon.Text = talep.Kullanicilar.TelefonNumarasi;
                masa.Text = talep.MasaBilgileri.MasaIsmi + ", Masa Numarası: " + talep.MasaBilgileri.MasaNumarasi;
                onayDurumu.Text = (talep.OnayDurumu == true) ? "Onaylandı" : "Onaylanmadı";
                tarih.Text = talep.Tarih.ToString();
                HaftaninGunu enumDisplayStatus = (HaftaninGunu)talep.PlanDetaylari.HaftaninGunu;
                haftaninGunu.Text = enumDisplayStatus.ToString();
                baslangicSaati.Text = Convert.ToDateTime(talep.PlanDetaylari.BaslangicSaati).ToString("HH:mm");
                bitisSaati.Text = Convert.ToDateTime(talep.PlanDetaylari.BitisSaati).ToString("HH:mm");
                onaylaButton.Enabled = true;
                silButton.Enabled = true;
                if (talep.OnayDurumu == true)
                {
                    onaylaButton.Text = "Onayı geri çek";
                }else
                {
                    onaylaButton.Text = "Onayla";
                }
            }

        }

        private void onaylaButton_Click(object sender, EventArgs e)
        {
            RezervasyonSistemi.Models.RezervasyonTalepleri talep = talepler[taleplerData.CurrentRow.Index];
            if (talep.OnayDurumu==true)
            {
                talep.OnayDurumu = false;
            }else
            {
                talep.OnayDurumu = true;
            }
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/RezervasyonTalepleri", Method.PUT);
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(talep);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Talep Onaylandı!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (Masa==null)
                {
                    LoadTalepler(CurrentIsletmeID);
                }else
                {
                    LoadTalepler(CurrentIsletmeID, Masa.ID);
                }
            }
            else
            {
                MessageBox.Show("Bir hata oluştu!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            RezervasyonSistemi.Models.RezervasyonTalepleri talep = talepler[taleplerData.CurrentRow.Index];
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/RezervasyonTalepleri/{ID}", Method.DELETE);
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);
            request.AddUrlSegment("ID", talep.ID.ToString());
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Talep Silindi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (Masa == null)
                {
                    LoadTalepler(CurrentIsletmeID);
                }
                else
                {
                    LoadTalepler(CurrentIsletmeID, Masa.ID);
                }
            }
            else
            {
                MessageBox.Show("Bir hata oluştu!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
