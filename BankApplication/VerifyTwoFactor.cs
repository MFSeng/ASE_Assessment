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
        private string secretKey;

        /// <summary>
        /// Create two factor using secret key. This is generated during account creation and stored
        /// </summary>
        /// <param name="secretKey">The authentication code from the database</param>
        public VerifyTwoFactor(string secretKey)
        {
            InitializeComponent();
            this.secretKey = secretKey;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string userInput = txtUserInput.Text;
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            // Get user id from database
            bool isCorrectPIN = tfa.ValidateTwoFactorPIN(secretKey, userInput);
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
    }
}
