using System;


using Google.Authenticator;

using System.Drawing;

using System.Windows.Forms;

using System.IO;

namespace TestingGoogleAuth
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn2fa_Click(object sender, EventArgs e)
        {
            string key = "GamingKeyForJameEpic";
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            var setupInfo = tfa.GenerateSetupCode("My app", "gibbotehgamer@gmail.com", key, false, 3);

            string qrCodeImageUrl = setupInfo.QrCodeSetupImageUrl;
            string manualEntrySetupCode = setupInfo.ManualEntryKey;

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

            imgQrCode.Image = bitmapImage;            
            
            lblManualCode.Text = manualEntrySetupCode;
        }

        private void btnVerify2fa_Click(object sender, EventArgs e)
        {
            string userInput = tbUser2faInput.Text;
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            bool isCorrectPIN = tfa.ValidateTwoFactorPIN("GamingKeyForJameEpic", userInput);
            if (isCorrectPIN)
            {
                lblVerification.Text = "Correct Verification";
            }
            else
            {
                lblVerification.Text = "Failed Verification";
            }
        }

        private void imgQrCode_Click(object sender, EventArgs e)
        {

        }
    }
}
