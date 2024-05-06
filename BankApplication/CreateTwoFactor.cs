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
using Google.Authenticator;
using QRCoder;


namespace BankApplication
{
    public partial class CreateTwoFactor : Form
    {
        /// <summary>
        /// Creates a two factor form that the user has to follow
        /// </summary>
        /// <param name="userID">The ID of the user so that it can be used to store the authentication code once created and working</param>
        public CreateTwoFactor(string userID)
        {
            InitializeComponent();
            this.userId = userID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = txtUserInput.Text;
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            // userKey = database.get(authCode) from userId
            bool isCorrectPIN = tfa.ValidateTwoFactorPIN(userKey, userInput);
            if (isCorrectPIN)
            {
                //lblVerification.Text = "Correct Verification";
                // Correct result means we can move on
                // Store key in database here: Database @ userId.authCode = userKey
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                //lblVerification.Text = "Failed Verification";
            }
        }

        private string userKey;

        private string userId;

        private void CreateTwoFactor_Load(object sender, EventArgs e)
        {
            // Generate Random String as Key
            // This needs to be stored in the database if the user does good
            // Is stored locally but will be accessed and stored
            userKey = RandomString(20);
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            var setupInfo = tfa.GenerateSetupCode("My app", "gibbotehgamer@gmail.com", userKey, false, 3);

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

            picQRCode.Image = bitmapImage;

            lblManualCode.Text = manualEntrySetupCode;

        }

        private Random random = new Random();
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
        .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Sets the user id locally so that this form can save their auth code
        /// </summary>
        /// <param name="id">The user ID</param>
        public void SetUserID(string id)
        {
            userId = id;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
