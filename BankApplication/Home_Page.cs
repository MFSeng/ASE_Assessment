using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class Home_Page : Form
    {
        SqlConnection connection; // this represents the connection to the database and is given the name connection.
        string connectionString; // decleration of the connection string.
        public Home_Page()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["BankApplication.Properties.Settings.BankServerConnectionString"].ConnectionString;
        }

        private void Home_Page_Load(object sender, EventArgs e)
        {
            AccountLoad();
        }

        private void AccountLoad()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Accounts", connection))
            {
                DataTable account = new DataTable();
                adapter.Fill(account);

                AccountBox.DisplayMember = "Balance";
                AccountBox.ValueMember = "AccountNum";
                AccountBox.DataSource = account;
            }
        }
    }
}
