using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateTwoFactor twoFactor = new CreateTwoFactor("userid");
            DialogResult res = twoFactor.ShowDialog();

            if (res == DialogResult.Yes)
            {
                Home_Page load = new Home_Page();
                load.Show();
            }
        }
    }
}
