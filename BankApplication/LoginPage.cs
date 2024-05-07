using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Windows.Controls;
using System.Security.Cryptography;

namespace BankApplication
{
    public partial class LoginPage : Form
    {
        SqlConnection connection;
        string connectionString;
        public static string customerNum;
        public LoginPage()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["BankApplication.Properties.Settings.BankServerConnectionString"].ConnectionString;
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateTwoFactor twoFactor = new CreateTwoFactor();
            DialogResult res = twoFactor.ShowDialog();

            if (res == DialogResult.Yes)
            {
                Home_Page load = new Home_Page();
                load.Show();
            }
        }

        private void Login_Click(object sender, EventArgs e)
        { 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT AuthCode FROM Details WHERE [Customer Number]='" + usernameBox.Text + "' AND Password='" + passwordBox.Text + "'";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string authCode = reader["AuthCode"].ToString();
                            customerNum = usernameBox.Text;
                            this.Hide();
                            connection.Close();

                            new VerifyTwoFactor(authCode).Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
            }
        }
    }
}
