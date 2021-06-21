namespace A5_AB_CLIR_Methods_Functions
{
    partial class AmericanBankCreditLimitIncreaseRequestForm
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
            this.creditLimitIncreaseRequestsApprovedLabel = new System.Windows.Forms.Label();
            this.creditLimitIncreaseRequestsDeniedLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.customerNumberTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.loadCustomerAndAccountInformationButton = new System.Windows.Forms.Button();
            this.customerInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.monthlyIncomeLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fICOCreditScoreLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.preferredCustomerCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customerSinceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paymentsMissedCheckBox = new System.Windows.Forms.CheckBox();
            this.currentCreditLimitLabel = new System.Windows.Forms.Label();
            this.accountBalanceLabel = new System.Windows.Forms.Label();
            this.programmedByLabel = new System.Windows.Forms.Label();
            this.requestCreditLimitIncreaseButton = new System.Windows.Forms.Button();
            this.accountInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.companyLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.customerInformationGroupBox.SuspendLayout();
            this.accountInformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // creditLimitIncreaseRequestsApprovedLabel
            // 
            this.creditLimitIncreaseRequestsApprovedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.creditLimitIncreaseRequestsApprovedLabel.Location = new System.Drawing.Point(397, 373);
            this.creditLimitIncreaseRequestsApprovedLabel.Name = "creditLimitIncreaseRequestsApprovedLabel";
            this.creditLimitIncreaseRequestsApprovedLabel.Size = new System.Drawing.Size(52, 30);
            this.creditLimitIncreaseRequestsApprovedLabel.TabIndex = 131;
            // 
            // creditLimitIncreaseRequestsDeniedLabel
            // 
            this.creditLimitIncreaseRequestsDeniedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.creditLimitIncreaseRequestsDeniedLabel.Location = new System.Drawing.Point(843, 368);
            this.creditLimitIncreaseRequestsDeniedLabel.Name = "creditLimitIncreaseRequestsDeniedLabel";
            this.creditLimitIncreaseRequestsDeniedLabel.Size = new System.Drawing.Size(51, 30);
            this.creditLimitIncreaseRequestsDeniedLabel.TabIndex = 133;
            // 
            // customerNumberTextBox
            // 
            this.customerNumberTextBox.Location = new System.Drawing.Point(449, 34);
            this.customerNumberTextBox.Name = "customerNumberTextBox";
            this.customerNumberTextBox.Size = new System.Drawing.Size(299, 29);
            this.customerNumberTextBox.TabIndex = 128;
            this.toolTip1.SetToolTip(this.customerNumberTextBox, "Valid Customer Numbers are 417102 and 732050. Anything else should result in an E" +
        "xception which should be caught using the Try/Catch block.");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(489, 374);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(334, 24);
            this.label12.TabIndex = 132;
            this.label12.Text = "Credit Limit Increase Requests Denied:";
            // 
            // loadCustomerAndAccountInformationButton
            // 
            this.loadCustomerAndAccountInformationButton.BackColor = System.Drawing.Color.PeachPuff;
            this.loadCustomerAndAccountInformationButton.Location = new System.Drawing.Point(21, 415);
            this.loadCustomerAndAccountInformationButton.Name = "loadCustomerAndAccountInformationButton";
            this.loadCustomerAndAccountInformationButton.Size = new System.Drawing.Size(878, 45);
            this.loadCustomerAndAccountInformationButton.TabIndex = 129;
            this.loadCustomerAndAccountInformationButton.Text = "Load Customer and Account Information";
            this.loadCustomerAndAccountInformationButton.UseVisualStyleBackColor = false;
            this.loadCustomerAndAccountInformationButton.Click += new System.EventHandler(this.loadCustomerAndAccountInformationButton_Click);
            // 
            // customerInformationGroupBox
            // 
            this.customerInformationGroupBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.customerInformationGroupBox.Controls.Add(this.monthlyIncomeLabel);
            this.customerInformationGroupBox.Controls.Add(this.label8);
            this.customerInformationGroupBox.Controls.Add(this.fICOCreditScoreLabel);
            this.customerInformationGroupBox.Controls.Add(this.label6);
            this.customerInformationGroupBox.Controls.Add(this.customerNameLabel);
            this.customerInformationGroupBox.Controls.Add(this.preferredCustomerCheckBox);
            this.customerInformationGroupBox.Controls.Add(this.label4);
            this.customerInformationGroupBox.Controls.Add(this.customerSinceLabel);
            this.customerInformationGroupBox.Controls.Add(this.label1);
            this.customerInformationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInformationGroupBox.Location = new System.Drawing.Point(21, 103);
            this.customerInformationGroupBox.Name = "customerInformationGroupBox";
            this.customerInformationGroupBox.Size = new System.Drawing.Size(428, 239);
            this.customerInformationGroupBox.TabIndex = 125;
            this.customerInformationGroupBox.TabStop = false;
            this.customerInformationGroupBox.Text = "CUSTOMER INFORMATION:";
            // 
            // monthlyIncomeLabel
            // 
            this.monthlyIncomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.monthlyIncomeLabel.Location = new System.Drawing.Point(207, 184);
            this.monthlyIncomeLabel.Name = "monthlyIncomeLabel";
            this.monthlyIncomeLabel.Size = new System.Drawing.Size(104, 29);
            this.monthlyIncomeLabel.TabIndex = 57;
            this.monthlyIncomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 24);
            this.label8.TabIndex = 55;
            this.label8.Text = "Monthly Income:";
            // 
            // fICOCreditScoreLabel
            // 
            this.fICOCreditScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fICOCreditScoreLabel.Location = new System.Drawing.Point(207, 147);
            this.fICOCreditScoreLabel.Name = "fICOCreditScoreLabel";
            this.fICOCreditScoreLabel.Size = new System.Drawing.Size(104, 29);
            this.fICOCreditScoreLabel.TabIndex = 55;
            this.fICOCreditScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 24);
            this.label6.TabIndex = 54;
            this.label6.Text = "FICO Credit Score:";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerNameLabel.Location = new System.Drawing.Point(207, 32);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(186, 29);
            this.customerNameLabel.TabIndex = 43;
            this.customerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // preferredCustomerCheckBox
            // 
            this.preferredCustomerCheckBox.AutoSize = true;
            this.preferredCustomerCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.preferredCustomerCheckBox.Location = new System.Drawing.Point(19, 114);
            this.preferredCustomerCheckBox.Name = "preferredCustomerCheckBox";
            this.preferredCustomerCheckBox.Size = new System.Drawing.Size(198, 28);
            this.preferredCustomerCheckBox.TabIndex = 51;
            this.preferredCustomerCheckBox.Text = "Preferred Customer:";
            this.preferredCustomerCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 24);
            this.label4.TabIndex = 49;
            this.label4.Text = "Customer Since:";
            // 
            // customerSinceLabel
            // 
            this.customerSinceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerSinceLabel.Location = new System.Drawing.Point(207, 71);
            this.customerSinceLabel.Name = "customerSinceLabel";
            this.customerSinceLabel.Size = new System.Drawing.Size(104, 29);
            this.customerSinceLabel.TabIndex = 50;
            this.customerSinceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Customer Name:";
            // 
            // paymentsMissedCheckBox
            // 
            this.paymentsMissedCheckBox.AutoSize = true;
            this.paymentsMissedCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.paymentsMissedCheckBox.Location = new System.Drawing.Point(26, 184);
            this.paymentsMissedCheckBox.Name = "paymentsMissedCheckBox";
            this.paymentsMissedCheckBox.Size = new System.Drawing.Size(186, 28);
            this.paymentsMissedCheckBox.TabIndex = 54;
            this.paymentsMissedCheckBox.Text = "Payments Missed?";
            this.paymentsMissedCheckBox.UseVisualStyleBackColor = true;
            // 
            // currentCreditLimitLabel
            // 
            this.currentCreditLimitLabel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.currentCreditLimitLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentCreditLimitLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.currentCreditLimitLabel.Location = new System.Drawing.Point(199, 147);
            this.currentCreditLimitLabel.Name = "currentCreditLimitLabel";
            this.currentCreditLimitLabel.Size = new System.Drawing.Size(152, 29);
            this.currentCreditLimitLabel.TabIndex = 57;
            this.currentCreditLimitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountBalanceLabel
            // 
            this.accountBalanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.accountBalanceLabel.Location = new System.Drawing.Point(199, 109);
            this.accountBalanceLabel.Name = "accountBalanceLabel";
            this.accountBalanceLabel.Size = new System.Drawing.Size(152, 29);
            this.accountBalanceLabel.TabIndex = 55;
            this.accountBalanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // programmedByLabel
            // 
            this.programmedByLabel.AutoSize = true;
            this.programmedByLabel.Location = new System.Drawing.Point(350, 573);
            this.programmedByLabel.Name = "programmedByLabel";
            this.programmedByLabel.Size = new System.Drawing.Size(253, 24);
            this.programmedByLabel.TabIndex = 121;
            this.programmedByLabel.Text = "Programmed by: Erik Zander";
            // 
            // requestCreditLimitIncreaseButton
            // 
            this.requestCreditLimitIncreaseButton.BackColor = System.Drawing.Color.PeachPuff;
            this.requestCreditLimitIncreaseButton.Location = new System.Drawing.Point(23, 470);
            this.requestCreditLimitIncreaseButton.Name = "requestCreditLimitIncreaseButton";
            this.requestCreditLimitIncreaseButton.Size = new System.Drawing.Size(878, 45);
            this.requestCreditLimitIncreaseButton.TabIndex = 127;
            this.requestCreditLimitIncreaseButton.Text = "Request Credit Limit Increase";
            this.requestCreditLimitIncreaseButton.UseVisualStyleBackColor = false;
            this.requestCreditLimitIncreaseButton.Click += new System.EventHandler(this.requestCreditLimitIncreaseButton_Click);
            // 
            // accountInformationGroupBox
            // 
            this.accountInformationGroupBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.accountInformationGroupBox.Controls.Add(this.paymentsMissedCheckBox);
            this.accountInformationGroupBox.Controls.Add(this.currentCreditLimitLabel);
            this.accountInformationGroupBox.Controls.Add(this.accountBalanceLabel);
            this.accountInformationGroupBox.Controls.Add(this.label9);
            this.accountInformationGroupBox.Controls.Add(this.accountTypeLabel);
            this.accountInformationGroupBox.Controls.Add(this.label7);
            this.accountInformationGroupBox.Controls.Add(this.label5);
            this.accountInformationGroupBox.Controls.Add(this.accountNumberLabel);
            this.accountInformationGroupBox.Controls.Add(this.label3);
            this.accountInformationGroupBox.Location = new System.Drawing.Point(493, 103);
            this.accountInformationGroupBox.Name = "accountInformationGroupBox";
            this.accountInformationGroupBox.Size = new System.Drawing.Size(401, 239);
            this.accountInformationGroupBox.TabIndex = 126;
            this.accountInformationGroupBox.TabStop = false;
            this.accountInformationGroupBox.Text = "ACCOUNT INFORMATION:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 24);
            this.label9.TabIndex = 56;
            this.label9.Text = "Current Credit Limit:";
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.accountTypeLabel.Location = new System.Drawing.Point(199, 71);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(152, 29);
            this.accountTypeLabel.TabIndex = 55;
            this.accountTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 24);
            this.label7.TabIndex = 54;
            this.label7.Text = "Account Balance:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 24);
            this.label5.TabIndex = 54;
            this.label5.Text = "Account Type:";
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.accountNumberLabel.Location = new System.Drawing.Point(199, 32);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(152, 29);
            this.accountNumberLabel.TabIndex = 45;
            this.accountNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "Account Number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(356, 24);
            this.label10.TabIndex = 130;
            this.label10.Text = "Credit Limit Increase Requests Approved:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 24);
            this.label2.TabIndex = 124;
            this.label2.Text = "Enter Customer Number:";
            // 
            // companyLogoPictureBox
            // 
            this.companyLogoPictureBox.Image = global::A5_AB_CLIR_Methods_Functions.Properties.Resources.AmericanBankLogo;
            this.companyLogoPictureBox.Location = new System.Drawing.Point(21, 7);
            this.companyLogoPictureBox.Name = "companyLogoPictureBox";
            this.companyLogoPictureBox.Size = new System.Drawing.Size(130, 54);
            this.companyLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.companyLogoPictureBox.TabIndex = 122;
            this.companyLogoPictureBox.TabStop = false;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.Location = new System.Drawing.Point(373, 4);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(197, 24);
            this.companyNameLabel.TabIndex = 120;
            this.companyNameLabel.Text = "American Bank, Inc.";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.PeachPuff;
            this.exitButton.Location = new System.Drawing.Point(23, 525);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(878, 45);
            this.exitButton.TabIndex = 123;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // AmericanBankCreditLimitIncreaseRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(936, 607);
            this.Controls.Add(this.creditLimitIncreaseRequestsApprovedLabel);
            this.Controls.Add(this.creditLimitIncreaseRequestsDeniedLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.loadCustomerAndAccountInformationButton);
            this.Controls.Add(this.customerInformationGroupBox);
            this.Controls.Add(this.customerNumberTextBox);
            this.Controls.Add(this.programmedByLabel);
            this.Controls.Add(this.requestCreditLimitIncreaseButton);
            this.Controls.Add(this.accountInformationGroupBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.companyLogoPictureBox);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.exitButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AmericanBankCreditLimitIncreaseRequestForm";
            this.Text = "American Bank Credit Limit Increase Request Form";
            this.customerInformationGroupBox.ResumeLayout(false);
            this.customerInformationGroupBox.PerformLayout();
            this.accountInformationGroupBox.ResumeLayout(false);
            this.accountInformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creditLimitIncreaseRequestsApprovedLabel;
        private System.Windows.Forms.Label creditLimitIncreaseRequestsDeniedLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox customerNumberTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button loadCustomerAndAccountInformationButton;
        private System.Windows.Forms.GroupBox customerInformationGroupBox;
        private System.Windows.Forms.Label monthlyIncomeLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label fICOCreditScoreLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.CheckBox preferredCustomerCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label customerSinceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox paymentsMissedCheckBox;
        private System.Windows.Forms.Label currentCreditLimitLabel;
        private System.Windows.Forms.Label accountBalanceLabel;
        private System.Windows.Forms.Label programmedByLabel;
        private System.Windows.Forms.Button requestCreditLimitIncreaseButton;
        private System.Windows.Forms.GroupBox accountInformationGroupBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox companyLogoPictureBox;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

