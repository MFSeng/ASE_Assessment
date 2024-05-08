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
using System.Globalization;

namespace BankApplication
{
    public partial class Transfer : Form
    {
        SqlConnection connection; // this represents the connection to the database and is given the name connection.
        string connectionString; // decleration of the connection string.
        CultureInfo ukCulture = new CultureInfo("en-GB");
        private static string balance;
        public Transfer()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["BankApplication.Properties.Settings.BankServerConnectionString"].ConnectionString;
        }
        // Load Infomration
        private void Transfer_Load(object sender, EventArgs e)
        {
            TransferButtom.Enabled = false;
            AccountCombo.Visible = false;
            label2.Visible = false;
            TypeCombo.SelectedIndex = 0;
            CustomerLabel.Text = ("Customer Number: " + LoginPage.customerNum);
            AccountLabel.Text = ("Account Number: " + Home_Page.accountNum);
            LoadBalance();
            AccountComboFill();
        }
        private void LoadBalance()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = (@"SELECT Balance FROM Accounts WHERE [AccountNum] = @account");
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    string accNum = Home_Page.accountNum;
                    command.Parameters.AddWithValue("@account", accNum);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            balance = reader["Balance"].ToString();
                            BalanceLabel.Text = "Balance: " + balance;
                        }
                        else
                        {
                            BalanceLabel.Text = "Balance: £0.00";
                        }
                    }
                }
            }
        }
        private void AccountComboFill()
        {
            string query = (@"Select AccountNum FROM Accounts WHERE AccountNum<>@AccNum");
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@AccNum", Home_Page.accountNum);
                DataTable accountTable = new DataTable();
                adapter.Fill(accountTable);

                AccountCombo.DisplayMember = "AccountNum";
                AccountCombo.ValueMember = "AccountNum";
                AccountCombo.DataSource = accountTable;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TypeCombo.SelectedIndex == 2)
            {
                TransferButtom.Enabled = true;
                AccountCombo.Visible = true;
                label2.Visible = true;
            }
            else
            {
                TransferButtom.Enabled = false;
                AccountCombo.Visible = false;
                label2.Visible = false;
            }
        }

        private void Deposit(string acc)
        {
            float balfloat = float.Parse(balance, NumberStyles.Currency, ukCulture);
            float deposit = float.Parse(AmmountBox.Text);
            float newBal = balfloat + deposit;
            string query = (@"UPDATE Accounts SET Balance = @balance WHERE AccountNum = @AccNum");
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@AccNum", acc);
                command.Parameters.AddWithValue("@balance", Convert.ToString(newBal));
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private void Withdraw(string acc)
        {
            float balfloat = float.Parse(balance, NumberStyles.Currency, ukCulture);
            float withdraw = float.Parse(AmmountBox.Text);
            float newBal = balfloat - withdraw;
            string query = (@"UPDATE Accounts SET Balance = @balance WHERE AccountNum = @AccNum");
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@AccNum", acc);
                command.Parameters.AddWithValue("@balance", Convert.ToString(newBal));
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void Transfering(string accNum, string accnum2)
        {
            Deposit(accnum2);
            Withdraw(accNum);
        }
        private void TransactionSet()
        {
            if (TypeCombo.SelectedIndex == 2)
            {
                string deposit = AmmountBox.Text;
                string type = Convert.ToString(TypeCombo.SelectedValue);
                string recc = Convert.ToString(AccountCombo.SelectedValue);
                string accNum = Home_Page.accountNum;
                string dateString = DateTime.Now.ToString("yyyy-MM-dd");
                string query = ("INSERT INTO [Transaction] (DateTime,AccountNum,Type,Ammount,RecAccountNum) VALUES ('" + dateString + "','" + accNum + "','" + type + "','" + "£" + deposit + "','" + recc + "')");
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                string query2 = ("INSERT INTO [Transaction] (DateTime,AccountNum,Type,Ammount) VALUES ('" + dateString + "','" + recc + "','Deposit','" + "£" + deposit + "')");
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            else
            {
                string deposit = AmmountBox.Text;
                string type = Convert.ToString(TypeCombo.SelectedValue);
                string accNum = Convert.ToString(Home_Page.accountNum);
                string dateString = DateTime.Now.ToString("yyyy-MM-dd");
                string query = ("INSERT INTO [Transaction] (DateTime,AccountNum,Type,Ammount) VALUES ('" + dateString + "','" + accNum + "','" + type + "','" + "£" + deposit + "')");
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        private void AmmountBox_TextChanged(object sender, EventArgs e)
        {
            float amount = float.Parse(balance, NumberStyles.Currency, ukCulture);
            if (AmmountBox.Text != "" && float.Parse(AmmountBox.Text) > amount && (TypeCombo.SelectedIndex == 2 || TypeCombo.SelectedIndex == 1))
            {
                TransferButtom.Enabled = false;
                AmmountBox.BackColor = Color.Red;
            }
            else
            {
                TransferButtom.Enabled = true;
                AmmountBox.BackColor = Color.Green;
            }
        }

        private void TransferButtom_Click(object sender, EventArgs e)
        {
            if (TypeCombo.SelectedIndex == 0)
            {
                Deposit(Home_Page.accountNum);
                TransactionSet();
                this.Close();
            }
            else if (TypeCombo.SelectedIndex == 1)
            {
                Withdraw(Home_Page.accountNum);
                TransactionSet();
                this.Close();
            }
            else if (TypeCombo.SelectedIndex == 2)
            {
                Transfering(Home_Page.accountNum, Convert.ToString(AccountCombo.SelectedValue));
                TransactionSet();
                this.Close();
            }
        }
    }
}
