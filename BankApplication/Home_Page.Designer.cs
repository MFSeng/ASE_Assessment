namespace BankApplication
{
    partial class Home_Page
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
            this.AccountBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TransactionBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.ListBox();
            this.TypeBox = new System.Windows.Forms.ListBox();
            this.AccRecBox = new System.Windows.Forms.ListBox();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.AccTypeBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateAccButton = new System.Windows.Forms.Button();
            this.TransferButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.LogoffButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ReccuringButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccountBox
            // 
            this.AccountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountBox.FormattingEnabled = true;
            this.AccountBox.ItemHeight = 17;
            this.AccountBox.Location = new System.Drawing.Point(13, 49);
            this.AccountBox.Name = "AccountBox";
            this.AccountBox.Size = new System.Drawing.Size(87, 157);
            this.AccountBox.TabIndex = 0;
            this.AccountBox.SelectedIndexChanged += new System.EventHandler(this.AccountBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Number:";
            // 
            // TransactionBox
            // 
            this.TransactionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionBox.FormattingEnabled = true;
            this.TransactionBox.ItemHeight = 17;
            this.TransactionBox.Location = new System.Drawing.Point(107, 49);
            this.TransactionBox.Name = "TransactionBox";
            this.TransactionBox.Size = new System.Drawing.Size(118, 157);
            this.TransactionBox.TabIndex = 2;
            this.TransactionBox.SelectedIndexChanged += new System.EventHandler(this.TransactionBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Transaction History:";
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLabel.Location = new System.Drawing.Point(12, 9);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(235, 24);
            this.CustomerLabel.TabIndex = 4;
            this.CustomerLabel.Text = "Customer Number: 123456";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Transaction Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(233, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Transaction Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(272, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Account To:";
            // 
            // DateBox
            // 
            this.DateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBox.FormattingEnabled = true;
            this.DateBox.ItemHeight = 15;
            this.DateBox.Location = new System.Drawing.Point(362, 74);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(120, 19);
            this.DateBox.TabIndex = 10;
            // 
            // TypeBox
            // 
            this.TypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.ItemHeight = 15;
            this.TypeBox.Location = new System.Drawing.Point(362, 99);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(120, 19);
            this.TypeBox.TabIndex = 11;
            // 
            // AccRecBox
            // 
            this.AccRecBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccRecBox.FormattingEnabled = true;
            this.AccRecBox.ItemHeight = 15;
            this.AccRecBox.Location = new System.Drawing.Point(362, 124);
            this.AccRecBox.Name = "AccRecBox";
            this.AccRecBox.Size = new System.Drawing.Size(120, 19);
            this.AccRecBox.TabIndex = 12;
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.Location = new System.Drawing.Point(267, 9);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(153, 24);
            this.BalanceLabel.TabIndex = 13;
            this.BalanceLabel.Text = "Balance: £100.00";
            // 
            // AccTypeBox
            // 
            this.AccTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccTypeBox.FormattingEnabled = true;
            this.AccTypeBox.ItemHeight = 15;
            this.AccTypeBox.Location = new System.Drawing.Point(362, 49);
            this.AccTypeBox.Name = "AccTypeBox";
            this.AccTypeBox.Size = new System.Drawing.Size(120, 19);
            this.AccTypeBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Account Type:";
            // 
            // CreateAccButton
            // 
            this.CreateAccButton.Location = new System.Drawing.Point(13, 235);
            this.CreateAccButton.Name = "CreateAccButton";
            this.CreateAccButton.Size = new System.Drawing.Size(87, 23);
            this.CreateAccButton.TabIndex = 16;
            this.CreateAccButton.Text = "New Account";
            this.CreateAccButton.UseVisualStyleBackColor = true;
            this.CreateAccButton.Click += new System.EventHandler(this.CreateAccButton_Click);
            // 
            // TransferButton
            // 
            this.TransferButton.Location = new System.Drawing.Point(106, 235);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(87, 23);
            this.TransferButton.TabIndex = 17;
            this.TransferButton.Text = "Move Money";
            this.TransferButton.UseVisualStyleBackColor = true;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(281, 235);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(120, 23);
            this.DeleteButton.TabIndex = 18;
            this.DeleteButton.Text = "Delete Account";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // LogoffButton
            // 
            this.LogoffButton.Location = new System.Drawing.Point(407, 235);
            this.LogoffButton.Name = "LogoffButton";
            this.LogoffButton.Size = new System.Drawing.Size(75, 23);
            this.LogoffButton.TabIndex = 19;
            this.LogoffButton.Text = "Log Off";
            this.LogoffButton.UseVisualStyleBackColor = true;
            this.LogoffButton.Click += new System.EventHandler(this.LogoffButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(407, 206);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 20;
            this.EditButton.Text = "Settings";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ReccuringButton
            // 
            this.ReccuringButton.Location = new System.Drawing.Point(281, 206);
            this.ReccuringButton.Name = "ReccuringButton";
            this.ReccuringButton.Size = new System.Drawing.Size(120, 23);
            this.ReccuringButton.TabIndex = 21;
            this.ReccuringButton.Text = "Dirrect Debit";
            this.ReccuringButton.UseVisualStyleBackColor = true;
            this.ReccuringButton.Click += new System.EventHandler(this.ReccuringButton_Click);
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 270);
            this.Controls.Add(this.ReccuringButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.LogoffButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.TransferButton);
            this.Controls.Add(this.CreateAccButton);
            this.Controls.Add(this.AccTypeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.AccRecBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TransactionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccountBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Home_Page";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AccountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox TransactionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox DateBox;
        private System.Windows.Forms.ListBox TypeBox;
        private System.Windows.Forms.ListBox AccRecBox;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.ListBox AccTypeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreateAccButton;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button LogoffButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button ReccuringButton;
    }
}