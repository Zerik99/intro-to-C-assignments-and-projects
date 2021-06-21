namespace A6_AB_Funds_Transfer_Application
{
    partial class AmericanBankFundsTransferApplicationForm
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
            this.transactionNumberLabel = new System.Windows.Forms.Label();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.transactionHistoryListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.transferFundsButton = new System.Windows.Forms.Button();
            this.transferAmountTextBox = new System.Windows.Forms.TextBox();
            this.currentBalanceInTransferToAccountLabel = new System.Windows.Forms.Label();
            this.currentBalanceInTransferFromAccountLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.transferToAccountComboBox = new System.Windows.Forms.ComboBox();
            this.transferFromAccountComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.programmedByLabel = new System.Windows.Forms.Label();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // transactionNumberLabel
            // 
            this.transactionNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.transactionNumberLabel.Location = new System.Drawing.Point(603, 204);
            this.transactionNumberLabel.Name = "transactionNumberLabel";
            this.transactionNumberLabel.Size = new System.Drawing.Size(70, 29);
            this.transactionNumberLabel.TabIndex = 111;
            this.transactionNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // makeTransferToolStripMenuItem
            // 
            this.makeTransferToolStripMenuItem.Name = "makeTransferToolStripMenuItem";
            this.makeTransferToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.makeTransferToolStripMenuItem.Text = "Make Transfer";
            this.makeTransferToolStripMenuItem.Click += new System.EventHandler(this.transferFundsButton_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeTransferToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(488, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 110;
            this.label8.Text = "Transaction #:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 108;
            this.label7.Text = "Transaction History:";
            // 
            // transactionHistoryListBox
            // 
            this.transactionHistoryListBox.FormattingEnabled = true;
            this.transactionHistoryListBox.ItemHeight = 20;
            this.transactionHistoryListBox.Location = new System.Drawing.Point(22, 263);
            this.transactionHistoryListBox.Name = "transactionHistoryListBox";
            this.transactionHistoryListBox.Size = new System.Drawing.Size(749, 104);
            this.transactionHistoryListBox.TabIndex = 107;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.PeachPuff;
            this.exitButton.Location = new System.Drawing.Point(22, 466);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(749, 50);
            this.exitButton.TabIndex = 106;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // transferFundsButton
            // 
            this.transferFundsButton.BackColor = System.Drawing.Color.PeachPuff;
            this.transferFundsButton.Enabled = false;
            this.transferFundsButton.Location = new System.Drawing.Point(22, 406);
            this.transferFundsButton.Name = "transferFundsButton";
            this.transferFundsButton.Size = new System.Drawing.Size(749, 50);
            this.transferFundsButton.TabIndex = 105;
            this.transferFundsButton.Text = "Transfer Funds";
            this.transferFundsButton.UseVisualStyleBackColor = false;
            this.transferFundsButton.Click += new System.EventHandler(this.transferFundsButton_Click);
            // 
            // transferAmountTextBox
            // 
            this.transferAmountTextBox.Location = new System.Drawing.Point(285, 205);
            this.transferAmountTextBox.Name = "transferAmountTextBox";
            this.transferAmountTextBox.Size = new System.Drawing.Size(70, 26);
            this.transferAmountTextBox.TabIndex = 104;
            // 
            // currentBalanceInTransferToAccountLabel
            // 
            this.currentBalanceInTransferToAccountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentBalanceInTransferToAccountLabel.Location = new System.Drawing.Point(603, 156);
            this.currentBalanceInTransferToAccountLabel.Name = "currentBalanceInTransferToAccountLabel";
            this.currentBalanceInTransferToAccountLabel.Size = new System.Drawing.Size(121, 29);
            this.currentBalanceInTransferToAccountLabel.TabIndex = 103;
            // 
            // currentBalanceInTransferFromAccountLabel
            // 
            this.currentBalanceInTransferFromAccountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentBalanceInTransferFromAccountLabel.Location = new System.Drawing.Point(234, 156);
            this.currentBalanceInTransferFromAccountLabel.Name = "currentBalanceInTransferFromAccountLabel";
            this.currentBalanceInTransferFromAccountLabel.Size = new System.Drawing.Size(121, 29);
            this.currentBalanceInTransferFromAccountLabel.TabIndex = 102;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 20);
            this.label6.TabIndex = 101;
            this.label6.Text = "Current Balance in Account:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 20);
            this.label5.TabIndex = 100;
            this.label5.Text = "Current Balance in Account:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 99;
            this.label4.Text = "Transfer Amount:";
            // 
            // transferToAccountComboBox
            // 
            this.transferToAccountComboBox.FormattingEnabled = true;
            this.transferToAccountComboBox.Items.AddRange(new object[] {
            "CHKG-2211",
            "SVNG-8080",
            "CARD-2323"});
            this.transferToAccountComboBox.Location = new System.Drawing.Point(603, 116);
            this.transferToAccountComboBox.Name = "transferToAccountComboBox";
            this.transferToAccountComboBox.Size = new System.Drawing.Size(121, 28);
            this.transferToAccountComboBox.TabIndex = 98;
            this.transferToAccountComboBox.SelectedIndexChanged += new System.EventHandler(this.transferToAccountComboBox_SelectedIndexChanged);
            // 
            // transferFromAccountComboBox
            // 
            this.transferFromAccountComboBox.FormattingEnabled = true;
            this.transferFromAccountComboBox.Items.AddRange(new object[] {
            "CHKG-2211",
            "SVNG-8080",
            "CARD-2323"});
            this.transferFromAccountComboBox.Location = new System.Drawing.Point(234, 116);
            this.transferFromAccountComboBox.Name = "transferFromAccountComboBox";
            this.transferFromAccountComboBox.Size = new System.Drawing.Size(121, 28);
            this.transferFromAccountComboBox.TabIndex = 97;
            this.transferFromAccountComboBox.SelectedIndexChanged += new System.EventHandler(this.transferFromAccountComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 96;
            this.label3.Text = "Transfer to Account:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 95;
            this.label2.Text = "Transfer from Account:";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerNameLabel.Location = new System.Drawing.Point(401, 77);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(139, 29);
            this.customerNameLabel.TabIndex = 94;
            this.customerNameLabel.Text = "David Newton";
            this.customerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "Customer Name:";
            // 
            // programmedByLabel
            // 
            this.programmedByLabel.AutoSize = true;
            this.programmedByLabel.Location = new System.Drawing.Point(301, 527);
            this.programmedByLabel.Name = "programmedByLabel";
            this.programmedByLabel.Size = new System.Drawing.Size(210, 20);
            this.programmedByLabel.TabIndex = 92;
            this.programmedByLabel.Text = "Programmed by: Erik Zander";
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.Location = new System.Drawing.Point(306, 32);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(197, 24);
            this.companyNameLabel.TabIndex = 91;
            this.companyNameLabel.Text = "American Bank, Inc.";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::A6_AB_Funds_Transfer_Application.Properties.Resources.AmericanBankLogo;
            this.logoPictureBox.Location = new System.Drawing.Point(22, 36);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(130, 54);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logoPictureBox.TabIndex = 90;
            this.logoPictureBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 109;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AmericanBankFundsTransferApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(793, 552);
            this.Controls.Add(this.transactionNumberLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.transactionHistoryListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.transferFundsButton);
            this.Controls.Add(this.transferAmountTextBox);
            this.Controls.Add(this.currentBalanceInTransferToAccountLabel);
            this.Controls.Add(this.currentBalanceInTransferFromAccountLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.transferToAccountComboBox);
            this.Controls.Add(this.transferFromAccountComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.programmedByLabel);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AmericanBankFundsTransferApplicationForm";
            this.Text = "American Bank Funds Transfer Application";
            this.Load += new System.EventHandler(this.AmericanBankFundsTransferApplicationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label transactionNumberLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeTransferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox transactionHistoryListBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button transferFundsButton;
        private System.Windows.Forms.TextBox transferAmountTextBox;
        private System.Windows.Forms.Label currentBalanceInTransferToAccountLabel;
        private System.Windows.Forms.Label currentBalanceInTransferFromAccountLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox transferToAccountComboBox;
        private System.Windows.Forms.ComboBox transferFromAccountComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label programmedByLabel;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

