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
    public partial class CreateBankAccount : Form
    {
        SqlConnection connection; // this represents the connection to the database and is given the name connection.
        string connectionString; // decleration of the connection string.
        private string accNum;
        private string customerNum;
        public CreateBankAccount()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["BankApplication.Properties.Settings.BankServerConnectionString"].ConnectionString;
        }
        public static string RandomNum()
        {
            Random random = new Random();
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, 4).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void CreateBankAccount_Load(object sender, EventArgs e)
        {
            customerNum = (LoginPage.customerNum);
            accNum = RandomNum();
            CustomerLabel.Text = ("Customer Number: " + customerNum);
            AccountLabel.Text = ("Account Number: " + accNum);
            TypeCombo.SelectedIndex = 0;
            CreateButton.Enabled = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string query = ("INSERT INTO [Accounts] (AccountNum,[Customer Number],Balance,AccountType) VALUES ('" + accNum + "','" + customerNum + "','" + "£" + BalanceBox.Text + "','" + Convert.ToString(TypeCombo.SelectedValue) + "')");
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            string dateString = DateTime.Now.ToString("yyyy-MM-dd");
            string query1 = ("INSERT INTO [Transaction] (DateTime,AccountNum,Type,Ammount) VALUES ('" + dateString + "','" + accNum + "','Deposit','" + "£" + BalanceBox.Text + "')");
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query1, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            this.DialogResult = DialogResult.Yes;
        }
        private void SetAvalability()
        {
            if(BalanceBox.Text != String.Empty)
            {
                CreateButton.Enabled = true;
            }
            else
            {
                CreateButton.Enabled = false;
            }
        }

        private void BalanceBox_TextChanged(object sender, EventArgs e)
        {
            SetAvalability();
        }
    }
}
