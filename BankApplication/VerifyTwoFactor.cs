using Google.Authenticator;
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
    public partial class VerifyTwoFactor : Form
    {
        private string userId;

        public VerifyTwoFactor(string userID)
        {
            InitializeComponent();
            this.userId = userID;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Get user input from database
            string userInput = txtUserInput.Text;
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            // Get user id from database
            bool isCorrectPIN = tfa.ValidateTwoFactorPIN("UserIdKey", userInput);
            if (isCorrectPIN)
            {
                lblOutput.Text = "Correct Verification";
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                lblOutput.Text = "Failed Verification";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
