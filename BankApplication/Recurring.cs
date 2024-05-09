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
    public partial class Recurring : Form
    {
        public Recurring()
        {
            InitializeComponent();
        }

        private void Recurring_Load(object sender, EventArgs e)
        {
            CustomerLabel.Text = ("Customer Number: " + LoginPage.customerNum);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reccuring payment for £" + Amount.Text + " Has been set up to be deliverd on " + dateTimePicker1.Value.Date.ToString("MM-dd") + " to " + Destination.Text);
            this.Close();
        }
    }
}
