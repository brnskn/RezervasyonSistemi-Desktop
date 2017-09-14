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

namespace RezervasyonSistemiClient
{
    public partial class Login : Form
    {
        bool exitAccess = true;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new RestClient(Constants.URL);
            var loginRequest = new RestRequest("api/Login", Method.POST);
            loginRequest.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            loginRequest.AddParameter("grant_type", "password");
            loginRequest.AddParameter("username", username.Text);
            loginRequest.AddParameter("password", password.Text);

            IRestResponse<OAuth> response = client.Execute<OAuth>(loginRequest);
            if (response.Data.access_token == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
            }
            else
            {
                Properties.Settings.Default.access_token = response.Data.access_token;
                Properties.Settings.Default.Save();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                exitAccess = false;
                this.Close();
            }
            
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.access_token != "")
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                exitAccess = false;
                this.Close();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(exitAccess==true)
                Application.Exit();
        }
    }
}
