using System;
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
    public partial class CreateAccount : Form
    {
        SqlConnection connection;
        string connectionString;
        public static string authcode;
        private string customerNum;
        public CreateAccount()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["BankApplication.Properties.Settings.BankServerConnectionString"].ConnectionString;
        }
        private void CreateAccount_Load(object sender, EventArgs e)
        {
            CreateButton.Enabled = false;
            customerNum = RandomNum();
            label2.Text = customerNum;
        }
        private string RandomNum()
        {
            Random random = new Random();
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, 6).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void AuthGenButton_Click(object sender, EventArgs e)
        {
            CreateTwoFactor twoFactor = new CreateTwoFactor();
            DialogResult res = twoFactor.ShowDialog();

            if (res == DialogResult.Yes)
            {
                AuthGenButton.Text = authcode;
            }
            setButtonVisability();
        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            SaveCustomer();
            MessageBox.Show("Customer Account Created!");
            this.Close();
        }

        private void SaveCustomer()
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = (@"INSERT INTO [Details] ([Customer Number], [Firstname], [Surname], [AuthCode], [Password], [Email], [Address 1], [Address 2], [Postcode], [PhoneNum], [D.O.B.]) VALUES (@CustNum, @FirstName, @Surname, @Auth, @Password, @Email, @Address1, @Address2, @Postcode, @PhoneNum, @DoB)");

                    // Adding parameters to avoid SQL Injection
                    command.Parameters.AddWithValue("@CustNum", customerNum);
                    command.Parameters.AddWithValue("@FirstName", FirstBox.Text);
                    command.Parameters.AddWithValue("@Surname", SurBox.Text);
                    command.Parameters.AddWithValue("@Auth", authcode);
                    command.Parameters.AddWithValue("@Password", PassBox.Text);
                    command.Parameters.AddWithValue("@Email", EmailBox.Text);
                    command.Parameters.AddWithValue("@Address1", AddressBox.Text);
                    command.Parameters.AddWithValue("@Address2", AddressBox2.Text);
                    command.Parameters.AddWithValue("@Postcode", PostBox.Text);
                    command.Parameters.AddWithValue("@PhoneNum", PhoneBox.Text);
                    command.Parameters.AddWithValue("@DoB", dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add customer. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setButtonVisability()
        {
            if ((FirstBox.Text != String.Empty) && (SurBox.Text != String.Empty) && (EmailBox.Text != String.Empty) && (PhoneBox.Text != String.Empty) && (PassBox.Text != String.Empty) && (PassBox2.Text != String.Empty) && (AddressBox.Text != String.Empty) && (AddressBox2.Text != String.Empty) && (PostBox.Text != String.Empty))
            {
                CreateButton.Enabled = true;
            }
            else
            {
                CreateButton.Enabled= false;
            }
        }
        private void PassBox2_TextChanged(object sender, EventArgs e)
        {
            setButtonVisability();
            if (PassBox.Text == PassBox2.Text)
            {
                PassBox2.BackColor = Color.Green;
            }
            else
            {
                PassBox2.BackColor = Color.Red;
            }
        }

        private void FirstBox_TextChanged(object sender, EventArgs e)
        {
            setButtonVisability();
        }

        private void SurBox_TextChanged(object sender, EventArgs e)
        {
            setButtonVisability();
        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {
            setButtonVisability();
        }

        private void PhoneBox_TextChanged(object sender, EventArgs e)
        {
            setButtonVisability();
        }

        private void PassBox_TextChanged(object sender, EventArgs e)
        {
            setButtonVisability();
            if (PassBox.Text == PassBox2.Text)
            {
                PassBox2.BackColor = Color.Green;
            }
            else
            {
                PassBox2.BackColor = Color.Red;
            }
        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {
            setButtonVisability();
        }

        private void AddressBox2_TextChanged(object sender, EventArgs e)
        {
            setButtonVisability();
        }

        private void PostBox_TextChanged(object sender, EventArgs e)
        {
            setButtonVisability();
        }
    }
}
