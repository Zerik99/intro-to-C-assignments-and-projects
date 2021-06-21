// TO DO: Enter the following information
// Class Name: AmericanBankFundsTransferApplicationForm
// Namespace Name: A6_AB_Funds_Transfer_Application
// Program Purpose: transfer funds between multiple accounts that the user holds with the bank.
// Programmer Name: Erik Zander
// Date: 11/12/2020
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A6_AB_Funds_Transfer_Application
{
    public partial class AmericanBankFundsTransferApplicationForm : Form
    {
        // TO DO: FIND AND FIX THE RUNTIME ERRORS AND LOGICAL ERRORS IN THE APPLICATION
        // NOTE: I have intentionally planted runtime and logical errors in the program.
        // You will need to find and fix both runtime errors and logical errors in the
        // application in order to get it to work the same as the completed application
        // (exe) file that I have provided.  Compare each line of C# code to its matching
        // psedocode to ensure that the C# code is doing exactly what is stated in the
        // pseudocode.  Use the table I have provided on page 2 in Note 13 to complete 
        // this task.  Extreme attention to detail and critical thinking is required to 
        // do well in this assignment!

        // TO DO: Add the following variables to the Watch 1 window:
        // checkingAccount2211BalanceDecimal, savingsAccount8080BalanceDecimal, and
        // creditCardAccount2323BalanceDecimal

        // TO DO: Add the following two expressions to the Immediate window:
        // transferFromAccountBalanceDecimal - transferAmountDecimal
        // transfertoAccountBalanceDecimal + transferAmountDecimal

        // TO DO: Set a breakpoint on the appropriate line (see pseudocode provided later
        // in this program to know which line to set the breakpoint on)

        // TO DO: After you set the breakpoint, add variables to the Watch 1 window and
        // add the expressions to the Immediate window, take one screen capture of all three
        // and include that image file inside your project folder

        // Declare a variable for account balance for each account type 
        // (example: checkingAccount2211BalanceDecimal) 
        decimal checkingAccount2211BalanceDecimal;
        decimal savingsAccount8080BalanceDecimal;
        decimal creditCardAccount2323BalanceDecimal;

        // Declare variables for transfer from account balance and transfer to account balance
        decimal transferFromAccountBalanceDecimal;
        decimal transferToAccountBalanceDecimal;

        // Declare a variable (transactionString) to store the transaction details
        string transactionString;

        // Declare a variable (totalNumberOfTransfersInteger) to keep track of the total number of transfers
        int totalNumberOfTransfersInteger = 0;

        public AmericanBankFundsTransferApplicationForm()
        {
            InitializeComponent();
        }

        // Event handler to handle the Load event of the AmericanBankFundsTranferApplicationForm form
        private void AmericanBankFundsTransferApplicationForm_Load(object sender, EventArgs e)
        {
            // Set the initial balance in the checking account to $3233.34
            checkingAccount2211BalanceDecimal =3233.34m ;
            // Set the initial balance in the savings account to $1212.24
            savingsAccount8080BalanceDecimal =1212.24m ;
            // Set the initial balance in the credit card account to $1836.14
            creditCardAccount2323BalanceDecimal = 1836.14m;
        }

        // Event handler to handle the SelectedIndexChanged event of the transferFromAccountComboBox control
        private void transferFromAccountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Declare a variable (accountString) to store the transfer from account number
            string accountNumberString;

            // TO DO: Set a breakpoint on the following C# assignment statement
            // Get the value in the transferFromAccountComboBox and store it in the accountNumberString variable
            accountNumberString = Convert.ToString(transferFromAccountComboBox.SelectedItem);

            // Use a switch statement block to set the transfer from account balance based on the value
            // in the accountNumberString variable
            // changed from transactionString to  accountNumberString
            switch (accountNumberString)
            {
                case "CHKG-2211":
                    // I think these are swapped
                    transferFromAccountBalanceDecimal  = checkingAccount2211BalanceDecimal;
                    currentBalanceInTransferFromAccountLabel.Text = transferFromAccountBalanceDecimal.ToString("c2");
                    break;
                case "CARD-2323":
                    transferFromAccountBalanceDecimal = creditCardAccount2323BalanceDecimal;
                    currentBalanceInTransferFromAccountLabel.Text = transferFromAccountBalanceDecimal.ToString("c2");
                    //transferFromAccountBalanceDecimal = Convert.ToDecimal(currentBalanceInTransferFromAccountLabel);
                    break;
                case "SVNG-8080":
                    transferFromAccountBalanceDecimal = savingsAccount8080BalanceDecimal;
                    currentBalanceInTransferFromAccountLabel.Text = transferFromAccountBalanceDecimal.ToString("c2");
                    break;
                default:
                    break;
            }
        }

        // Event handler to handle the SelectedIndexChanged event of the transferToAccountComboBox control
        private void transferToAccountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Use an if statement to check whether the transfer from account and the transfer account are the same accounts ...
            // ... and whether the tranfer from account is empty
            if (transferFromAccountComboBox.Text == transferToAccountComboBox.Text || transferFromAccountComboBox.Text == "")
            {
                // If the transfer from account and the transfer account are the same accounts are the same, 
                // then display a message that the transfer is not possible
                MessageBox.Show("Sorry, You cannot transfer funds to the same account!!!", "Funds Transfer Error!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                // Declare a variable (accountString) to store the transfer to account number
                string accountNumberString;

                // Get the value in the transferToAccountComboBox and store it in the accountString variable
                accountNumberString = transferToAccountComboBox.Text;

                // Use a switch statement block to set the transfer to account balance based on the value
                // in the accountNumberString variable
                switch (accountNumberString)
                {
                    case "CHKG-2211":
                        transferToAccountBalanceDecimal = checkingAccount2211BalanceDecimal;
                        currentBalanceInTransferToAccountLabel.Text = transferToAccountBalanceDecimal.ToString("c2");
                        break;
                    case "SVNG-8080":
                        transferToAccountBalanceDecimal = savingsAccount8080BalanceDecimal;
                        currentBalanceInTransferToAccountLabel.Text = transferToAccountBalanceDecimal.ToString("c2");
                        break;
                    case "CARD-2323":
                        transferToAccountBalanceDecimal = creditCardAccount2323BalanceDecimal;
                        currentBalanceInTransferToAccountLabel.Text = transferToAccountBalanceDecimal.ToString("c2");
                        break;
                    default:
                        break;
                }
                // Enable the tranferFundsButton control to make it active
                //was false changed to true
                transferFundsButton.Enabled = true;
            }
        }

        // Event handler to handle the Click event of the transferFundsButton control
        private void transferFundsButton_Click(object sender, EventArgs e)
        {
            // Declare a variable (totalNumberOfTransfersInteger) to keep track of the total number of transfers
           // counters should be declared at the class level.
            //int totalNumberOfTransfersInteger = 0;

            // Declare a variable (transferAmountDecimal) to store the transfer amount
            decimal transferAmountDecimal = 0;

            // Add a try/catch block to catch exceptions in user input entered in the transferAmountTextBox
            try
            {
                // Put the line of code that you believe will cause an exception. 
                // (HINT: We are trying to validate user input entered in the transferAmountTextBox)
                //transferAmountTextBox.Text = transferAmountDecimal.ToString();
                transferAmountDecimal = Convert.ToDecimal(transferAmountTextBox.Text);
                
                // Use an if statement block to check whether the transfer amount is greater than the transfer from account balance.
                if (transferAmountDecimal > transferFromAccountBalanceDecimal)
                {
                    // If it does, then display a message stating that the transfer amount cannot exceed current account
                    // balance in the transfer from account
                    MessageBox.Show("Sorry, Transfer amount cannot exceed current account balance!!!",
                        "Funds Transfer Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    // Declare variables to store the account from and account to account numbers
                    string accountFromString = null;
                    string accountToString = null;

                    // Get the account number from the transferFromAccountComboBox and store it in the accountFromString variable
                    accountFromString = transferFromAccountComboBox.Text;

                    // Use a switch statement block to deduct the transfer amount from the transfer from account
                    switch (accountFromString)
                    {
                        case "CHKG-2211":
                            checkingAccount2211BalanceDecimal = checkingAccount2211BalanceDecimal - transferAmountDecimal;
                            transferFromAccountBalanceDecimal = checkingAccount2211BalanceDecimal;
                            currentBalanceInTransferFromAccountLabel.Text = transferFromAccountBalanceDecimal.ToString("c2");
                            break;
                        case "SVNG-8080":
                            savingsAccount8080BalanceDecimal = savingsAccount8080BalanceDecimal - transferAmountDecimal;
                            transferFromAccountBalanceDecimal = savingsAccount8080BalanceDecimal;
                            currentBalanceInTransferFromAccountLabel.Text = transferFromAccountBalanceDecimal.ToString("c2");
                            break;
                        case "CARD-2323":
                            creditCardAccount2323BalanceDecimal = creditCardAccount2323BalanceDecimal - transferAmountDecimal;
                            transferFromAccountBalanceDecimal = creditCardAccount2323BalanceDecimal;
                            currentBalanceInTransferFromAccountLabel.Text = transferFromAccountBalanceDecimal.ToString("c2");
                            break;
                        default:
                            break;
                    }

                    // Get the account number to the transferToAccountComboBox and store it in the accountToString variable
                    accountToString = transferToAccountComboBox.Text;

                    // Use a switch statement block to add the transfer amount to the transfer to account
                    switch (accountToString)
                    {
                        case "CHKG-2211":
                            checkingAccount2211BalanceDecimal = checkingAccount2211BalanceDecimal + transferAmountDecimal;
                            transferToAccountBalanceDecimal = checkingAccount2211BalanceDecimal;
                            currentBalanceInTransferToAccountLabel.Text = transferToAccountBalanceDecimal.ToString("c2");
                            break;
                        case "SVNG-8080":
                            savingsAccount8080BalanceDecimal = savingsAccount8080BalanceDecimal + transferAmountDecimal;
                            transferToAccountBalanceDecimal = savingsAccount8080BalanceDecimal;
                            currentBalanceInTransferToAccountLabel.Text = transferToAccountBalanceDecimal.ToString("c2");
                            break;
                        case "CARD-2323":
                            creditCardAccount2323BalanceDecimal = creditCardAccount2323BalanceDecimal + transferAmountDecimal;
                            transferToAccountBalanceDecimal = creditCardAccount2323BalanceDecimal;
                            currentBalanceInTransferToAccountLabel.Text = transferToAccountBalanceDecimal.ToString("c2");
                            break;
                        default:
                            break;
                    }

                    // Increment the total number of transfers by 1
                    totalNumberOfTransfersInteger ++;
                    // Display the value in the totalNumberOfTransfersInteger variable on the form using the 
                    // transactionNumberLabel control
                    // totalNumberOfTransfersInteger = Convert.ToInt32(transactionNumberLabel.Text);
                    transactionNumberLabel.Text = Convert.ToString(totalNumberOfTransfersInteger);

                    // Use string concatenation to create the transactionString that will be added to the 
                    // transactionHistoryListBox control
                    transactionString = "Transaction #" + totalNumberOfTransfersInteger.ToString() + " " +
                        transferAmountDecimal.ToString("c2");
                    transactionString = transactionString + " transferred from account " + accountFromString +
                        " to account " + accountToString;
                    // Add the value in the transactionString variable to the transactionHistoryListBox control
                    transactionHistoryListBox.Items.Add(transactionString);
                    // Display a message stating that the funds transfer was successful
                    MessageBox.Show("The funds transfer was successful!!!", "Funds Transfer Success!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Use an if statement block to check whether the total number of transfers is 3 or more.
                    if (totalNumberOfTransfersInteger == 3)
                    {
                        // If the total number of transfers is 3 or more, then display an appropriate message back to the user
                        MessageBox.Show("Monthly transfer limit of 3 was reached!!!", "Funds Transfer Limit Reached!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        transferFundsButton.Enabled = false;
                    }
                }
            }
            // This catch block will be executed if the user enters a non-numeric value for the tranfer amount
            catch
            {
                MessageBox.Show("Please enter a numeric value for the transfer amount!!!", "Data Entry Error - Transfer Amount!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        // Event handler to handle the Click event of the clearToolStripMenuItem control
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler to handle the Click event of the clearToolStripMenuItem control
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear all the controls on the form and deselect items selected in the combo box
            transferFromAccountComboBox.Text = "";
            transferToAccountComboBox.Text = "";
            //these two lines of code are not required.
           //transferFromAccountComboBox.SelectedIndex = 1;
           // transferToAccountComboBox.SelectedIndex = 1;
            currentBalanceInTransferFromAccountLabel.Text = "";
            currentBalanceInTransferToAccountLabel.Text = "";
            transferAmountTextBox.Clear();
            transactionNumberLabel.Text = "";
            transactionHistoryListBox.Items.Clear();

            // Re-initialize the accounts to their original balances
            checkingAccount2211BalanceDecimal = 3233.34m;
            savingsAccount8080BalanceDecimal = 1836.14m;
            creditCardAccount2323BalanceDecimal = 1212.24m;
            // Re-initialize the total number of transfers
            totalNumberOfTransfersInteger = 0;
        }

        // Event handler to handle the Click event of the aboutToolStripMenuItem control
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TO DO: Replace my name with yours
            MessageBox.Show("Programmed by: Erik Zander", "Programmer Information", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }
}
