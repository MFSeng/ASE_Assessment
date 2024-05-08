namespace TestingGoogleAuth
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn2fa = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imgQrCode = new System.Windows.Forms.PictureBox();
            this.lblManualCode = new System.Windows.Forms.Label();
            this.btnVerify2fa = new System.Windows.Forms.Button();
            this.lblVerification = new System.Windows.Forms.Label();
            this.tbUser2faInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgQrCode)).BeginInit();
            this.SuspendLayout();
            // 
            // btn2fa
            // 
            this.btn2fa.Location = new System.Drawing.Point(589, 285);
            this.btn2fa.Name = "btn2fa";
            this.btn2fa.Size = new System.Drawing.Size(150, 70);
            this.btn2fa.TabIndex = 0;
            this.btn2fa.Text = "Setup 2FA";
            this.btn2fa.UseVisualStyleBackColor = true;
            this.btn2fa.Click += new System.EventHandler(this.btn2fa_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imgQrCode
            // 
            this.imgQrCode.Location = new System.Drawing.Point(247, 12);
            this.imgQrCode.Name = "imgQrCode";
            this.imgQrCode.Size = new System.Drawing.Size(492, 267);
            this.imgQrCode.TabIndex = 1;
            this.imgQrCode.TabStop = false;
            this.imgQrCode.Click += new System.EventHandler(this.imgQrCode_Click);
            // 
            // lblManualCode
            // 
            this.lblManualCode.AutoSize = true;
            this.lblManualCode.Location = new System.Drawing.Point(501, 385);
            this.lblManualCode.Name = "lblManualCode";
            this.lblManualCode.Size = new System.Drawing.Size(35, 13);
            this.lblManualCode.TabIndex = 2;
            this.lblManualCode.Text = "label1";
            // 
            // btnVerify2fa
            // 
            this.btnVerify2fa.Location = new System.Drawing.Point(91, 285);
            this.btnVerify2fa.Name = "btnVerify2fa";
            this.btnVerify2fa.Size = new System.Drawing.Size(150, 70);
            this.btnVerify2fa.TabIndex = 3;
            this.btnVerify2fa.Text = "Verify 2fa";
            this.btnVerify2fa.UseVisualStyleBackColor = true;
            this.btnVerify2fa.Click += new System.EventHandler(this.btnVerify2fa_Click);
            // 
            // lblVerification
            // 
            this.lblVerification.AutoSize = true;
            this.lblVerification.Location = new System.Drawing.Point(142, 47);
            this.lblVerification.Name = "lblVerification";
            this.lblVerification.Size = new System.Drawing.Size(0, 13);
            this.lblVerification.TabIndex = 4;
            // 
            // tbUser2faInput
            // 
            this.tbUser2faInput.Location = new System.Drawing.Point(91, 233);
            this.tbUser2faInput.Name = "tbUser2faInput";
            this.tbUser2faInput.Size = new System.Drawing.Size(150, 20);
            this.tbUser2faInput.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.tbUser2faInput);
            this.Controls.Add(this.lblVerification);
            this.Controls.Add(this.btnVerify2fa);
            this.Controls.Add(this.lblManualCode);
            this.Controls.Add(this.imgQrCode);
            this.Controls.Add(this.btn2fa);
            this.Name = "Login";
            this.Text = "Login Page";
            ((System.ComponentModel.ISupportInitialize)(this.imgQrCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn2fa;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox imgQrCode;
        private System.Windows.Forms.Label lblManualCode;
        private System.Windows.Forms.Button btnVerify2fa;
        private System.Windows.Forms.Label lblVerification;
        private System.Windows.Forms.TextBox tbUser2faInput;
    }
}

