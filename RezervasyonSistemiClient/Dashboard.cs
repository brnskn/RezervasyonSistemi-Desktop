using System;
using System.Windows.Forms;
using RestSharp;
using RezervasyonSistemiClient.Models;
using System.Collections.Generic;
using RezervasyonSistemiClient.Isletme;
using RezervasyonSistemiClient.Kullanici;
using RezervasyonSistemiClient.Properties;
using RezervasyonSistemiClient.Kat;
using RezervasyonSistemiClient.Masa;
using RezervasyonSistemiClient.Planlar;
using RezervasyonSistemiClient.RezervasyonTalepleri;

namespace RezervasyonSistemiClient
{
    public partial class Dashboard : Form
    {
        bool exitAccess = true;
        List<MasaBilgileri> masalar;
        public Dashboard()
        {
            InitializeComponent();
            LoadIsletme();
            imageList1.Images.Add(Resources.cafe);
            imageList1.Images.SetKeyName(0, "cafe");
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
            katBilgileriCombo.DataSource = response.Data;
            katBilgileriCombo.ValueMember = "ID";
            katBilgileriCombo.DisplayMember = "KatIsmi";
        }
        private void LoadMasaBilgileri(int KatID)
        {
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/MasaBilgileri?KatID={KatID}", Method.GET);
            request.AddUrlSegment("KatID", Convert.ToString(KatID));
            request.AddHeader("Authorization", "Bearer " + Settings.Default.access_token);
            Console.WriteLine(Settings.Default.access_token);
            IRestResponse<List<MasaBilgileri>> response = client.Execute<List<MasaBilgileri>>(request);
            masalar = response.Data;
            masaBilgileriList.Clear();
            int i = 0;
            foreach (MasaBilgileri masa in response.Data)
            {
                masaBilgileriList.Items.Add(masa.MasaIsmi);
                masaBilgileriList.Items[i].ImageIndex = 0;
                i++;
            }
        }
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.access_token = "";
            Settings.Default.Save();
            Login login = new Login();
            login.Show();
            exitAccess = false;
            this.Close();
        }

        private void işletmelerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Isletmelerim isletmelerim = new Isletmelerim();
            isletmelerim.ShowDialog();
            LoadIsletme();
        }

        private void işletmeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsletmeEkle isletmeEkle = new IsletmeEkle();
            isletmeEkle.ShowDialog();
            LoadIsletme();
        }

        private void profilimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profilim profilim = new Profilim();
            profilim.ShowDialog();
            LoadIsletme();
        }

        private void isletmeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadKatBilgileri(Convert.ToInt32(isletmeCombo.SelectedValue));
            }catch(InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void katBilgileriCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadMasaBilgileri(Convert.ToInt32(katBilgileriCombo.SelectedValue));
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void katListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KatListesi katListesi = new KatListesi();
            katListesi.ShowDialog();
            LoadIsletme();
        }

        private void katBilgisiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KatEkle katEkle = new KatEkle();
            katEkle.ShowDialog();
            LoadIsletme();
        }

        private void masaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasaListesi masaListesi = new MasaListesi();
            masaListesi.ShowDialog();
            LoadIsletme();
        }

        private void masaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasaEkle masaEkle = new MasaEkle();
            masaEkle.ShowDialog();
            LoadIsletme();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(exitAccess==true)
                Application.Exit();
        }

        private void uygunSaatlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planlarım planlarım = new Planlarım();
            planlarım.ShowDialog();
        }

        private void taleplerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RezervasyonTaleplerim rezervasyonTaleplerim = new RezervasyonTaleplerim();
            rezervasyonTaleplerim.ShowDialog();
        }

        private void masaBilgileriList_DoubleClick(object sender, EventArgs e)
        {
            if (masaBilgileriList.SelectedItems.Count>0)
            {
                for (int i=0;i<masaBilgileriList.SelectedItems.Count;i++)
                {
                    MasaBilgileri masa = masalar[masaBilgileriList.SelectedItems[i].Index];
                    RezervasyonTaleplerim talep = new RezervasyonTaleplerim(Convert.ToInt32(isletmeCombo.SelectedValue), masa);
                    talep.Show();
                }
            }
        }

        private void masaBilgileriList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                masaBilgileriList_DoubleClick(sender,e);
            }
        }
    }
}
