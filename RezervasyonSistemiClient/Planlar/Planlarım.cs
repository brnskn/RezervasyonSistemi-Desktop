using RestSharp;
using RezervasyonSistemi.Models;
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

namespace RezervasyonSistemiClient.Planlar
{
    public partial class Planlarım : Form
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
        List<PlanDetaylari> planDetaylari;
        List<RezervasyonSistemi.Models.Planlar> planlar;
        int CurrentIsletmeID;
        int CurrentPlanID;
        public Planlarım()
        {
            InitializeComponent();
            haftaninGunuCombo.DataSource = Enum.GetValues(typeof(HaftaninGunu));
            LoadIsletme();
        }
        private void LoadIsletme()
        {
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/Isletme", Method.GET);
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);

            IRestResponse<List<Isletmeler>> response = client.Execute<List<Isletmeler>>(request);
            LoadPlan(response.Data[0].ID);
            isletmeCombo.DataSource = response.Data;
            isletmeCombo.ValueMember = "ID";
            isletmeCombo.DisplayMember = "IsletmeIsmi";
        }
        private void LoadPlan(int IsletmeID)
        {
            CurrentIsletmeID = IsletmeID;
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/Plan?IsletmeID={IsletmeID}", Method.GET);
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);
            request.AddUrlSegment("IsletmeID", Convert.ToString(IsletmeID));

            IRestResponse<List<RezervasyonSistemi.Models.Planlar>> response = client.Execute<List<RezervasyonSistemi.Models.Planlar>>(request);
            planlar = response.Data;
            try
            {
                LoadPlanDetay(response.Data[0].ID);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                planDetaylariData.Rows.Clear();
            }
            planlarData.ColumnCount = 3;
            planlarData.Columns[0].Name = "ID";
            planlarData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            planlarData.Columns[1].Name = "Plan İsmi";
            planlarData.Columns[2].Name = "Plan Açıklaması";
            planlarData.Rows.Clear();
            foreach (RezervasyonSistemi.Models.Planlar plan in response.Data)
            {
                planlarData.Rows.Add(new string[]{ Convert.ToString(plan.ID), plan.PlanIsmi, plan.PlanAciklamasi});
            }
        }
        private void LoadPlanDetay(int PlanID)
        {
            CurrentPlanID = PlanID;
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/PlanDetaylari?PlanID={PlanID}", Method.GET);
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);
            request.AddUrlSegment("PlanID", Convert.ToString(PlanID));

            IRestResponse<List<PlanDetaylari>> response = client.Execute<List<RezervasyonSistemi.Models.PlanDetaylari>>(request);
            planDetaylari = response.Data;
            planDetaylariData.ColumnCount = 4;
            planDetaylariData.Columns[0].Name = "ID";
            planDetaylariData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            planDetaylariData.Columns[1].Name = "Haftanin Günü";
            planDetaylariData.Columns[2].Name = "Başlangıç Saati";
            planDetaylariData.Columns[3].Name = "Bitiş Saati";
            planDetaylariData.Rows.Clear();
            foreach (PlanDetaylari planDetay in response.Data)
            {
                HaftaninGunu enumDisplayStatus = (HaftaninGunu)planDetay.HaftaninGunu;
                planDetaylariData.Rows.Add(new string[] { Convert.ToString(planDetay.ID), enumDisplayStatus.ToString(), Convert.ToDateTime(planDetay.BaslangicSaati).ToString("HH:mm"), Convert.ToDateTime(planDetay.BitisSaati).ToString("HH:mm") });
            }
        }
        private void planlarData_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                LoadPlanDetay(Convert.ToInt32(planlarData.CurrentRow.Cells[0].Value));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void planDetaylariData_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                haftaninGunuCombo.SelectedIndex = (int)planDetaylari[planDetaylariData.CurrentRow.Index].HaftaninGunu;
                baslangicSaatiPicker.Value = Convert.ToDateTime(planDetaylari[planDetaylariData.CurrentRow.Index].BaslangicSaati);
                bitisSaatiPicker.Value = Convert.ToDateTime(planDetaylari[planDetaylariData.CurrentRow.Index].BitisSaati);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }

        private void isletmeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadPlan(Convert.ToInt32(isletmeCombo.SelectedValue));
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlanDetaylari planDetaylari = this.planDetaylari[planDetaylariData.CurrentRow.Index];
            planDetaylari.BaslangicSaati = baslangicSaatiPicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            planDetaylari.BitisSaati = bitisSaatiPicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            planDetaylari.HaftaninGunu = haftaninGunuCombo.SelectedIndex;
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/PlanDetaylari", Method.PUT);
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(planDetaylari);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Plan Detayı Düzenlendi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPlanDetay(CurrentPlanID);
            }
            else
            {
                MessageBox.Show("Bir hata oluştu!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlanDetaylari planDetaylari = new PlanDetaylari();
            planDetaylari.BaslangicSaati = baslangicSaatiPicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            planDetaylari.BitisSaati = bitisSaatiPicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            planDetaylari.HaftaninGunu = haftaninGunuCombo.SelectedIndex;
            planDetaylari.PlanID = Convert.ToInt32(planlarData.CurrentRow.Cells[0].Value);
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/PlanDetaylari", Method.POST);
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(planDetaylari);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Plan Detayı Eklendi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPlanDetay(CurrentPlanID);
            }
            else
            {
                MessageBox.Show("Bir hata oluştu!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlanEkle planEkle = new PlanEkle(Convert.ToInt32(isletmeCombo.SelectedValue));
            DialogResult dr = planEkle.ShowDialog();
            if (dr == DialogResult.Abort || dr == DialogResult.Cancel || dr == DialogResult.OK || dr == DialogResult.None)
            {
                LoadPlan(CurrentIsletmeID);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/PlanDetaylari/{ID}", Method.DELETE);
            request.AddUrlSegment("ID", Convert.ToString(planDetaylari[planDetaylariData.CurrentRow.Index].ID));
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Plan Detayı Silindi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPlanDetay(CurrentPlanID);
            }
            else
            {
                MessageBox.Show("Bir hata oluştu!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var client = new RestClient(Constants.URL);
            var request = new RestRequest("api/Plan/{ID}", Method.DELETE);
            request.AddUrlSegment("ID", Convert.ToString(planlar[planlarData.CurrentRow.Index].ID));
            request.AddHeader("Authorization", "Bearer " + Properties.Settings.Default.access_token);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Plan Silindi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPlan(CurrentIsletmeID);
            }
            else
            {
                MessageBox.Show("Bir hata oluştu!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlanDuzenle planDuzenle = new PlanDuzenle(planlar[planlarData.CurrentRow.Index]);
            DialogResult dr = planDuzenle.ShowDialog();
            if (dr == DialogResult.Abort || dr == DialogResult.Cancel || dr == DialogResult.OK || dr == DialogResult.None)
            {
                LoadPlan(CurrentIsletmeID);
            }
        }
    }
}
