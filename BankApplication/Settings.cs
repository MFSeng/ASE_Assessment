using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class Settings : Form
    {
        SqlConnection connection;
        string connectionString;
        public string custNum = LoginPage.customerNum;
        public Settings()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["BankApplication.Properties.Settings.BankServerConnectionString"].ConnectionString;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            label2.Text = custNum;
            LoadAuthCode();
            LoadFirstName();
            LoadSurname();
            LoadEmail();
            LoadAddress1();
            LoadAddress2();
            LoadPostcode();
            LoadPhone();
            LoadDate();
        }
        private void LoadAuthCode()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = (@"SELECT AuthCode FROM Details WHERE [Customer Number] = @Num");
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Num", custNum);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string balance = reader["AuthCode"].ToString();
                            label7.Text = balance;
                        }
                        else
                        {
                            label7.Text = "N/A";
                        }
                    }
                }
            }
        }
        private void LoadFirstName()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = (@"SELECT Firstname FROM Details WHERE [Customer Number] = @Num");
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Num", custNum);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string balance = reader["Firstname"].ToString();
                            FirstBox.Text = balance;
                        }
                        else
                        {
                            FirstBox.Text = "N/A";
                        }
                    }
                }
            }
        }
        private void LoadSurname()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = (@"SELECT Surname FROM Details WHERE [Customer Number] = @Num");
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Num", custNum);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string balance = reader["Surname"].ToString();
                            SurBox.Text = balance;
                        }
                        else
                        {
                            SurBox.Text = "N/A";
                        }
                    }
                }
            }
        }
        private void LoadEmail()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = (@"SELECT Email FROM Details WHERE [Customer Number] = @Num");
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Num", custNum);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string balance = reader["Email"].ToString();
                            EmailBox.Text = balance;
                        }
                        else
                        {
                            EmailBox.Text = "N/A";
                        }
                    }
                }
            }
        }
        private void LoadAddress1()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = (@"SELECT [Address 1] FROM Details WHERE [Customer Number] = @Num");
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Num", custNum);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string balance = reader["Address 1"].ToString();
                            AddressBox.Text = balance;
                        }
                        else
                        {
                            AddressBox.Text = "N/A";
                        }
                    }
                }
            }
        }
        private void LoadAddress2()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = (@"SELECT [Address 2] FROM Details WHERE [Customer Number] = @Num");
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Num", custNum);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string balance = reader["Address 2"].ToString();
                            AddressBox2.Text = balance;
                        }
                        else
                        {
                            AddressBox2.Text = "N/A";
                        }
                    }
                }
            }
        }
        private void LoadPostcode()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = (@"SELECT PostCode FROM Details WHERE [Customer Number] = @Num");
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Num", custNum);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string balance = reader["PostCode"].ToString();
                            PostBox.Text = balance;
                        }
                        else
                        {
                            PostBox.Text = "N/A";
                        }
                    }
                }
            }
        }
        private void LoadPhone()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = (@"SELECT PhoneNum FROM Details WHERE [Customer Number] = @Num");
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Num", custNum);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string balance = reader["PhoneNum"].ToString();
                            PhoneBox.Text = balance;
                        }
                        else
                        {
                            PhoneBox.Text = "N/A";
                        }
                    }
                }
            }
        }
        private void LoadDate()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = (@"SELECT [D.O.B.] FROM Details WHERE [Customer Number] = @Num");
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Num", custNum);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string balance = reader["D.O.B."].ToString();
                            dateTimePicker1.Text = balance;
                        }
                        else
                        {
                            dateTimePicker1.Text = "N/A";
                        }
                    }
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string query = (@"UPDATE Details SET Firstname = @FirstName,Surname = @Surname,Email = @Email,[Address 1] = @Address1,[Address 2] = @Address2,PostCode = @Postcode,PhoneNum = @PhoneNum,[D.O.B.] = @DoB  WHERE [Customer Number] = @CustNum");
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CustNum", custNum);
                command.Parameters.AddWithValue("@FirstName", FirstBox.Text);
                command.Parameters.AddWithValue("@Surname", SurBox.Text);
                command.Parameters.AddWithValue("@Email", EmailBox.Text);
                command.Parameters.AddWithValue("@Address1", AddressBox.Text);
                command.Parameters.AddWithValue("@Address2", AddressBox2.Text);
                command.Parameters.AddWithValue("@Postcode", PostBox.Text);
                command.Parameters.AddWithValue("@PhoneNum", PhoneBox.Text);
                command.Parameters.AddWithValue("@DoB", dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            this.Close();
        }
    }
}
