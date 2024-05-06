namespace BankApplication
{
    partial class VerifyTwoFactor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Two Factor Authentication Code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(263, 177);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(203, 20);
            this.txtUserInput.TabIndex = 1;
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(329, 241);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 23);
            this.btnVerify.TabIndex = 2;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(329, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(260, 386);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 4;
            // 
            // VerifyTwoFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.label1);
            this.Name = "VerifyTwoFactor";
            this.Text = "VerifyTwoFactor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblOutput;
    }
}