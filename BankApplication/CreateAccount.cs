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
        private int customerNum;
        public CreateAccount()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["BankApplication.Properties.Settings.BankServerConnectionString"].ConnectionString;
        }
        private void CreateAccount_Load(object sender, EventArgs e)
        {
            int customerNum = Int32.Parse(RandomNum());
            label2.Text = customerNum.ToString();
        }
        public string RandomNum()
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
            this.Hide();
            new LoginPage().Show();
        }

        private void SaveCustomer()
        {
            string custNum = Convert.ToString(customerNum);
            string firstName = Convert.ToString(FirstBox.Text);
            string surname = Convert.ToString(SurBox.Text);
            string auth = Convert.ToString(authcode);
            string password = Convert.ToString(PassBox.Text);
            string email = Convert.ToString(EmailBox.Text);
            string address1 = Convert.ToString(AddressBox.Text);
            string address2 = Convert.ToString(AddressBox2.Text);
            string postcode = Convert.ToString(PostBox.Text);
            string phoneNum = Convert.ToString(PhoneBox.Text);
            string DoB = Convert.ToString(dateTimePicker1.Value.Date);
            string query = ("INSERT INTO Details ([Customer Number],Firstname,Surname,AuthCode,Password,Email,[Address 1],[Address 2],Postcode,PhoneNum,[D.O.B.]) VALUES ('" + custNum + "','" + firstName + "','" + surname + "','" + auth + "','" + password + "','" + email + "','" + address1 + "','" + address2 + "','" + postcode + "','" + phoneNum + "','" + DoB + "')");
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
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
    }
}
