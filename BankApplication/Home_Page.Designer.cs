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
            this.components = new System.ComponentModel.Container();
            this.AccountBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bankServerDataSet = new BankApplication.BankServerDataSet();
            this.bankServerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankServerDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TransactionBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.ListBox();
            this.TypeBox = new System.Windows.Forms.ListBox();
            this.AccRecBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bankServerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankServerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankServerDataSetBindingSource1)).BeginInit();
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
            // bankServerDataSet
            // 
            this.bankServerDataSet.DataSetName = "BankServerDataSet";
            this.bankServerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankServerDataSetBindingSource
            // 
            this.bankServerDataSetBindingSource.DataSource = this.bankServerDataSet;
            this.bankServerDataSetBindingSource.Position = 0;
            // 
            // bankServerDataSetBindingSource1
            // 
            this.bankServerDataSetBindingSource1.DataSource = this.bankServerDataSet;
            this.bankServerDataSetBindingSource1.Position = 0;
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
            this.CustomerLabel.Size = new System.Drawing.Size(165, 24);
            this.CustomerLabel.TabIndex = 4;
            this.CustomerLabel.Text = "Customer Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Transaction Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Transaction Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(268, 101);
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
            this.DateBox.Location = new System.Drawing.Point(358, 51);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(120, 19);
            this.DateBox.TabIndex = 10;
            // 
            // TypeBox
            // 
            this.TypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.ItemHeight = 15;
            this.TypeBox.Location = new System.Drawing.Point(358, 76);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(120, 19);
            this.TypeBox.TabIndex = 11;
            // 
            // AccRecBox
            // 
            this.AccRecBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccRecBox.FormattingEnabled = true;
            this.AccRecBox.ItemHeight = 15;
            this.AccRecBox.Location = new System.Drawing.Point(358, 101);
            this.AccRecBox.Name = "AccRecBox";
            this.AccRecBox.Size = new System.Drawing.Size(120, 19);
            this.AccRecBox.TabIndex = 12;
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 439);
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
            ((System.ComponentModel.ISupportInitialize)(this.bankServerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankServerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankServerDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AccountBox;
        private System.Windows.Forms.Label label1;
        private BankServerDataSet bankServerDataSet;
        private System.Windows.Forms.BindingSource bankServerDataSetBindingSource;
        private System.Windows.Forms.BindingSource bankServerDataSetBindingSource1;
        private System.Windows.Forms.ListBox TransactionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox DateBox;
        private System.Windows.Forms.ListBox TypeBox;
        private System.Windows.Forms.ListBox AccRecBox;
    }
}