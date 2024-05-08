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

namespace BankApplication
{
    public partial class Home_Page : Form
    {
        SqlConnection connection; // this represents the connection to the database and is given the name connection.
        string connectionString; // decleration of the connection string.
        public static string accountNum;
        public Home_Page()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["BankApplication.Properties.Settings.BankServerConnectionString"].ConnectionString;
        }
        //Loading stuff
        private void Home_Page_Load(object sender, EventArgs e)
        {
            CustomerLabel.Text = ("Customer Number: " + LoginPage.customerNum);
            AccountLoad();
            LoadBalance();
        }
        private void LoadBalance()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = (@"SELECT Balance FROM Accounts WHERE [AccountNum] = @account");
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    string accNum = Convert.ToString(AccountBox.SelectedValue);
                    command.Parameters.AddWithValue("@account", accNum);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string balance = reader["Balance"].ToString();
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
        private void AccountLoad()
        {
            string query = (@"SELECT * FROM Accounts WHERE [Customer Number] = @customerNum");
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                string customerNum = LoginPage.customerNum;
                command.Parameters.AddWithValue("@customerNum", customerNum);
                DataTable account = new DataTable();
                adapter.Fill(account);

                AccountBox.DisplayMember = "AccountNum";
                AccountBox.ValueMember = "AccountNum";
                AccountBox.DataSource = account;
            }
        }
        private void AccountBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TransactionLoad();
            LoadBalance();
        }
        private void TransactionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccTypeLoad();
            DateLoad();
            TypeLoad();
            RecAccountLoad();
        }
        private void TransactionLoad()
        {
            string query = (@"SELECT * FROM [Transaction] WHERE [AccountNum] = @account ORDER BY DateTime");
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                string accNum = Convert.ToString(AccountBox.SelectedValue);
                command.Parameters.AddWithValue("@account", accNum);
                DataTable transaction = new DataTable();
                adapter.Fill(transaction);

                TransactionBox.DisplayMember = "Ammount";
                TransactionBox.ValueMember = "Ammount";
                TransactionBox.DataSource = transaction;
            }
        }
        private void AccTypeLoad()
        {
            string query = (@"SELECT AccountType FROM [Accounts] WHERE [AccountNum] = @account");
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                string accNum = Convert.ToString(AccountBox.SelectedValue);
                command.Parameters.AddWithValue("@account", accNum);
                DataTable acctype = new DataTable();
                adapter.Fill(acctype);

                AccTypeBox.DisplayMember = "AccountType";
                AccTypeBox.ValueMember = "AccountType";
                AccTypeBox.DataSource = acctype;
            }
        }
        private void DateLoad()
        {
            string query = (@"SELECT DateTime FROM [Transaction] WHERE [Ammount] = @ammount AND [AccountNum] = @account");
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                string accNum = Convert.ToString(AccountBox.SelectedValue);
                string transAmount = Convert.ToString(TransactionBox.SelectedValue);
                command.Parameters.AddWithValue("@ammount", transAmount);
                command.Parameters.AddWithValue("@account", accNum);
                DataTable date = new DataTable();
                adapter.Fill(date);

                DateBox.DisplayMember = "DateTime";
                DateBox.ValueMember = "DateTime";
                DateBox.DataSource = date;
            }
        }
        private void TypeLoad()
        {
            string query = (@"SELECT Type FROM [Transaction] WHERE [Ammount] = @ammount AND [AccountNum] = @account");
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                string accNum = Convert.ToString(AccountBox.SelectedValue);
                string transAmount = Convert.ToString(TransactionBox.SelectedValue);
                command.Parameters.AddWithValue("@ammount", transAmount);
                command.Parameters.AddWithValue("@account", accNum);
                DataTable type = new DataTable();
                adapter.Fill(type);

                TypeBox.DisplayMember = "Type";
                TypeBox.ValueMember = "Type";
                TypeBox.DataSource = type;
            }
        }
        private void RecAccountLoad()
        {
            string query = (@"SELECT RecAccountNum FROM [Transaction] WHERE [Ammount] = @ammount AND [AccountNum] = @account");
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                string accNum = Convert.ToString(AccountBox.SelectedValue);
                string transAmount = Convert.ToString(TransactionBox.SelectedValue);
                command.Parameters.AddWithValue("@ammount", transAmount);
                command.Parameters.AddWithValue("@account", accNum);
                DataTable RecAcc = new DataTable();
                adapter.Fill(RecAcc);

                AccRecBox.DisplayMember = "RecAccountNum";
                AccRecBox.ValueMember = "RecAccountNum";
                AccRecBox.DataSource = RecAcc;
            }
        }
        // Delete button stuff
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteAccount();
            AccountLoad();
        }
        private void DeleteAccount()
        {
            string query = (@"DELETE FROM Accounts WHERE AccountNum = @AccNumber");
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@AccNumber", AccountBox.SelectedValue);
                command.ExecuteScalar();
                connection.Close();
            }
        }
        // Log off button stuff
        private void LogoffButton_Click(object sender, EventArgs e)
        {
            connection.Close();
            Environment.Exit(0);
        }
        // Money Moving
        private void TransferButton_Click(object sender, EventArgs e)
        {
            accountNum = Convert.ToString(AccountBox.SelectedValue);
            Transfer transfer = new Transfer();
            transfer.ShowDialog();
        }

        private void CreateAccButton_Click(object sender, EventArgs e)
        {
            CreateBankAccount bank = new CreateBankAccount();
            DialogResult res = bank.ShowDialog();

            if (res == DialogResult.Yes)
            {
                AccountLoad();
            }
        }
    }
}
