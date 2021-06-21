namespace Note13_Monthly_Payment_Calculator
{
    partial class Note13MonthlyPaymentCalculatorForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.principleTextBox = new System.Windows.Forms.TextBox();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.numberOfMonthsTextBox = new System.Windows.Forms.TextBox();
            this.outPutLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter The Principle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter The Interest Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter the Number of Months";
            // 
            // principleTextBox
            // 
            this.principleTextBox.Location = new System.Drawing.Point(333, 117);
            this.principleTextBox.Name = "principleTextBox";
            this.principleTextBox.Size = new System.Drawing.Size(100, 29);
            this.principleTextBox.TabIndex = 3;
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Location = new System.Drawing.Point(333, 188);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(100, 29);
            this.interestRateTextBox.TabIndex = 4;
            // 
            // numberOfMonthsTextBox
            // 
            this.numberOfMonthsTextBox.Location = new System.Drawing.Point(333, 269);
            this.numberOfMonthsTextBox.Name = "numberOfMonthsTextBox";
            this.numberOfMonthsTextBox.Size = new System.Drawing.Size(100, 29);
            this.numberOfMonthsTextBox.TabIndex = 5;
            // 
            // outPutLabel
            // 
            this.outPutLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outPutLabel.Location = new System.Drawing.Point(84, 397);
            this.outPutLabel.Name = "outPutLabel";
            this.outPutLabel.Size = new System.Drawing.Size(569, 99);
            this.outPutLabel.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(84, 322);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(569, 61);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate Monthly Payment";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Note13MonthlyPaymentCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 696);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outPutLabel);
            this.Controls.Add(this.numberOfMonthsTextBox);
            this.Controls.Add(this.interestRateTextBox);
            this.Controls.Add(this.principleTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Note13MonthlyPaymentCalculatorForm";
            this.Text = "Note12 Monthly Payment Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox principleTextBox;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.TextBox numberOfMonthsTextBox;
        private System.Windows.Forms.Label outPutLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

