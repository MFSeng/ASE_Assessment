﻿using Google.Authenticator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        // <summary>
        // Create two factor using secret key. This is generated during account creation and stored
        // </summary>
        // <param name="secretKey">The authentication code from the database</param>
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
            // Get user id from database
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            bool isCorrectPIN = tfa.ValidateTwoFactorPIN(secretKey, userInput);
            if (isCorrectPIN)
            {
                lblOutput.Text = "Correct Verification";
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                lblOutput.Text = "Failed Verification";
            }
        }

        private void VerifyTwoFactor_Load(object sender, EventArgs e)
        {
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            var setupInfo = tfa.GenerateSetupCode("My app", "gibbotehgamer@gmail.com", secretKey, false, 3);

            string qrCodeImageUrl = setupInfo.QrCodeSetupImageUrl;

            var headerLength = "data:image/png;base64,".Length;
            var rawImageData = qrCodeImageUrl.Substring(headerLength, qrCodeImageUrl.Length - headerLength);
            var imageData = Convert.FromBase64String(rawImageData);
            var image = new ImageMagick.MagickImage(imageData);
            Bitmap bitmapImage;

            using (var memStream = new MemoryStream())
            {
                image.Write(memStream);
                bitmapImage = new System.Drawing.Bitmap(memStream);
            }

            pictureBox1.Image = bitmapImage;
        }
    }
}
