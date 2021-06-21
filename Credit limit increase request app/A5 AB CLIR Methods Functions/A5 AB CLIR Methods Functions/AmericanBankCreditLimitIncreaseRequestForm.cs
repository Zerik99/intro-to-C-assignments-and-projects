// TO DO: Enter the information requested below
// Class Name:  AmericanBankCreditLimitIncreaseRequestForm
// Namespace name:   A5_AB_CLIR_Methods_Functions
// Program Purpose:  current credit card customers to request a credit limit increase on their current credit cards.
// Programmer Name: Erik Zander
// Program Date: 11/04/2020
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A5_AB_CLIR_Methods_Functions
{
    public partial class AmericanBankCreditLimitIncreaseRequestForm : Form
    {
        // NOTE: FOR ALL THE VARIABLES YOU ARE ASKED TO DECLARE IN THIS PROGRAM, DECLARE 
        // THEM USING MEANINGFUL NAMES MAKING SURE TO FOLLOW THE CAMEL NAMING CONVENTION 
        // AND THE NAMING STYLE DESCRIBED IN NOTES 9 AND 10.

        // TO DO: Declare a variable of the appropriate data type to store the credit limit increase requests approved counter
            int cCLimitIncreaceRequestsApprovedCounterInt;
        // TO DO: Declare a variable of the appropriate data type to store the credit limit increase requests denied counter
            int cCLimitIncreaceRequestsDeniedCounterInt;

        
        // TO DO: Declare a variable of the appropriate data type to store the customer name
            string customerNameString;
        // TO DO: Declare a variable of the appropriate data type to store the customer since
            int  customerSinceInt;
        // TO DO: Declare a variable of the appropriate data type to store whether the customer is a preferred customer
        bool preferredCustomerBoolean;
        // TO DO: Declare a variable of the appropriate data type to store the FICO credit score
        int fICOCreditScoreInt;
        // TO DO: Declare a variable of the appropriate data type to store the monthly income
        decimal monthlyIncomeDecimal;
        // TO DO: Declare a variable of the appropriate data type to store the account number
        string accountNumberString;
        // TO DO: Declare a variable of the appropriate data type to store the account type
        string accountTypeString;
        // TO DO: Declare a variable of the appropriate data type to store the account balance
        decimal accountBalanceDecimal;
        // TO DO: Declare a variable of the appropriate data type to store the current credit limit
        int currentCreditLimitInteger;
        // TO DO: Declare a variable of the appropriate data type to store whether the customer has missed payments
        bool paymentsMissedBoolean;
        


        // NOTE THAT ALL OF THE ABOVE VARIABLES ARE DECLARED AT THE CLASS-LEVEL.  
        // TO DO: Move the appropriate variables (just 1) from the above list into the 
        // loadCustomerAndAccountInformationButton_Click() event handler method. Done!

        // TO DO: Move the appropriate variables (just 1) from the above list into the 
        // requestCreditLimitIncreaseButton_Click event handler method.

        // TO DO: Move the appropriate variables (just 1) from the above list into the 
        // ProcessCreditCardApplicationBasedOnCreditRating() user-defined method. Done!

        // This is this class's constructor method.  Leave it alone!
        public AmericanBankCreditLimitIncreaseRequestForm()
        {
            InitializeComponent();
        }


        // Handle the Click event of the loadCustomerAndAccountInformationButton button
        private void loadCustomerAndAccountInformationButton_Click(object sender, EventArgs e)
        {
            // TO DO: Move the appropriate variables from the class-level to here (local scope)
            // TO DO: Declare a variable of the appropriate data type to store the customer number
            int customerNumberInt;

            // Use a try catch block to catch any errors in data entry in the customerNumberTextBox control
            try
            {
                // TO DO: Put the assignment statement that you believe will cause the data entry error here
                // in the customerNumberTextBox control
                customerNumberInt = Convert.ToInt32(customerNumberTextBox.Text);

                // TO DO: Add a method call to the method SetCustomerAndAccountInformation()
                // by passing it 1 argument (customerNumberInteger)
                SetCustomerAndAccountInformation(customerNumberInt);

                // TO DO: Add a method call to the method DisplayCustomerAndAccountInformation()
                // by passing it 1 argument (customerNumberInteger)
                DisplayCustomerAndAccountInformation(customerNumberInt);
            }
            // If a non-numeric value is entered for the customer number, then use the catch block to display an appropriate message
            catch
            {
                MessageBox.Show("Please enter a numeric value for Customer number!", "Data Entry Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Handle the Click event of the requestCreditLimitIncreaseButton button
        private void requestCreditLimitIncreaseButton_Click(object sender, EventArgs e)
        {
            // TO DO: Move the appropriate variables from the class-level to here (local scope)
            // TO DO: Declare a variable of the appropriate data type to store the credit rating
            string creditRatingString;

            // TO DO: Add a function call to the function SetAndReturnCreditRatingBasedOnCustomerSinceYear()
            // by passing it 1 argument (customerSinceInteger) and store the returned
            // value in the variable creditRatingString
            creditRatingString = SetAndReturnCreditRatingBasedOnCustomerSinceYear(customerSinceInt);

            // TO DO: Add a function call to the function SetAndReturnCreditRatingBasedOnFICOCreditScore()
            // by passing it 1 argument (fICOCreditScoreInteger) and store the returned
            // value in the variable creditRatingString
            creditRatingString = SetAndReturnCreditRatingBasedOnFICOCreditScore(fICOCreditScoreInt);

            // TO DO: Add a function call to the function SetAndReturnCreditRatingBasedOnMonthlyIncomeAndAccountBalance()
            // by passing it 2 arguments (monthlyIncomeDecimal and accountBalanceDecimal) and store the returned
            // value in the variable creditRatingString
            creditRatingString = SetAndReturnCreditRatingBasedOnMonthlyIncomeAndAccountBalance(monthlyIncomeDecimal, accountBalanceDecimal);

            // TO DO: Add a function call to the function SetAndReturnCreditRatingBasedOnPaymentsMissed()
            // by passing it 1 argument (paymentsMissedBoolean) and store the returned value in 
            // the variable creditRatingString
            creditRatingString = SetAndReturnCreditRatingBasedOnPaymentsMissed(paymentsMissedBoolean);

            // TO DO: Add a method call to the method ProcessCreditCardApplicationBasedOnCreditRating()
            // by passing it 1 argument (creditRatingString)
            ProcessCreditCardApplicationBasedOnCreditRating(creditRatingString);

        }


        // Handle the Click event of the ExitButton button
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }

        // TO DO: Declare a method SetCustomerAndAccountInformation() with 1 parameter (customerNumberInteger)
        private void SetCustomerAndAccountInformation(int customerNumberInt)
        {
            // TO DO: Use an if statement block to check whether the customer number is 417102 and set the values
            // to the variables you declared earlier appropriately 
            if (customerNumberInt == 417102)
            {
                // SET THE VALUES FOR CUSTOMER INFORMATION RELATED VARIABLES FOR CUSTOMER NUMBER 417102
                // TO DO: Set the variable you declared for customer name to "Travis Kelce"
                customerNameString = "Travis Kelce";
                // TO DO: Set the variable you declared for customer since to 2011
                customerSinceInt = 2011;
                // TO DO: Set the variable you declared for preferred customer to true
                preferredCustomerBoolean = true;
                // TO DO: Set the variable you declared for FICO credit score to 770
                fICOCreditScoreInt = 770;
                // TO DO: Set the variable you declared for monthly income to $4000.00
                monthlyIncomeDecimal = 4000.00m;

                // SET THE VALUES FOR ACCOUNT INFORMATION RELATED VARIABLES
                // TO DO: Set the variable you declared for account number to "CARD-2323"
                accountNumberString = "CARD-2323";
                // TO DO: Set the variable you declared for account type to "Credit Card"
                accountTypeString = "CreditCard";
                // TO DO: Set the variable you declared for account balance to $1212.24
                accountBalanceDecimal = 1212.24m;
                // TO DO: Set the variable you declared for current credit limit to $12000
                currentCreditLimitInteger = 12000;
                // TO DO: Set the variable you declared for the payments missed to false
                paymentsMissedBoolean = false;
            }
            // TO DO: In the else part of the if statement block, check whether the customer number is 732050 and set the values
            // to the variables you declared earlier appropriately 
            else if (customerNumberInt == 732050)
            {
                // SET THE VALUES FOR CUSTOMER INFORMATION RELATED VARIABLES FOR CUSTOMER NUMBER 732050
                // TO DO: Set the variable you declared for customer name to "George Kittle"
                  customerNameString = "George Kittle";
                // TO DO: Set the variable you declared for customer since to 2015
                  customerSinceInt = 2015;
                // TO DO: Set the variable you declared for preferred customer to false
                  preferredCustomerBoolean = false;
                // TO DO: Set the variable you declared for FICO credit score to 480
                  fICOCreditScoreInt = 480;
                // TO DO: Set the variable you declared for monthly income to $2000.00
                  monthlyIncomeDecimal = 2000.00m;

                // SET THE VALUES FOR ACCOUNT INFORMATION RELATED VARIABLES
                // TO DO: Set the variable you declared for account number to "CARD-6699"
                 accountNumberString = "CARD-6699";
                // TO DO: Set the variable you declared for account type to "Credit Card"
                 accountTypeString = "Credit Card";
                // TO DO: Set the variable you declared for account balance to $3233.34
                  accountBalanceDecimal =3233.34m;
                // TO DO: Set the variable you declared for current credit limit to $6000
                  currentCreditLimitInteger = 6000;
                // TO DO: Set the variable you declared for the payments missed to true
                   paymentsMissedBoolean = true;
            }
        }

        // TO DO: Declare a method DisplayCustomerAndAccountInformation() with 1 parameter (customerNumberInteger)
      private void DisplayCustomerAndAccountInformation(int customerNumberInt)
        {
            // TO DO: Use an if statement block to check whether the customer number is 417102 and display
            // the appropriate customer and account information back to the user on the form 
            if (customerNumberInt == 417102)
            {
                // OUTPUT THE VALUES IN THE CUSTOMER INFORMATION VARIABLES BACK TO THE USER USING CONTROLS ON THE FORM
                // TO DO: Display the value in the variable you declared for customer name using the label control customerNameLabel
                customerNameLabel.Text = customerNameString;
                // TO DO: Display the value in the variable you declared for customer since using the label control customerSinceLabel
                customerSinceLabel.Text =Convert.ToString(customerSinceInt);
                // TO DO: Display the value in the variable you declared for preferred customer using the checkbox control preferredCustomerCheckBox
                preferredCustomerCheckBox.Checked = preferredCustomerBoolean;
                // TO DO: Display the value in the variable you declared for FICO credit score using the label control fICOCreditScoreLabel
                fICOCreditScoreLabel.Text = Convert.ToString(fICOCreditScoreInt);
                // TO DO: Display the value in the variable you declared for monthly income using the label control monthlyIncomeLabel. 
                // Use currency format with 2 decimal places.
                monthlyIncomeLabel.Text = monthlyIncomeDecimal.ToString("c2");

                // OUTPUT THE VALUES IN THE ACCOUNT INFORMATION VARIABLES BACK TO THE USER USING CONTROLS ON THE FORM
                // TO DO: Display the value in the variable you declared for account number using the label control accountNumberLabel
                accountNumberLabel.Text = accountNumberString;
                // TO DO: Display the value in the variable you declared for account type using the label control accountTypeLabel
                accountTypeLabel.Text = accountTypeString;
                // TO DO: Display the value in the variable you declared for account balance using the label control accountBalanceLabel. 
                // Use currency format with 2 decimal places.
                accountBalanceLabel.Text = accountBalanceDecimal.ToString("c2");
                // TO DO: Display the value in the variable you declared for current credit limit using the label control currentCreditLimitLabel. 
                // Use currency format with 2 decimal places.
                currentCreditLimitLabel.Text = currentCreditLimitInteger.ToString("c2");
                // TO DO: Display the value in the variable you declared for payments missed using the checkbox control paymentsMissedCheckBox
                paymentsMissedCheckBox.Checked = paymentsMissedBoolean;
    }
            // TO DO: In the else part of the if statement block, check whether the customer number is 732050 and display
            // the appropriate customer and account information back to the user on the form 
            else if (customerNumberInt == 732050)
            {
                // OUTPUT THE VALUES IN THE CUSTOMER INFORMATION VARIABLES BACK TO THE USER USING CONTROLS ON THE FORM
                // TO DO: Display the value in the variable you declared for customer name using the label control customerNameLabel
                customerNameLabel.Text = customerNameString;
                // TO DO: Display the value in the variable you declared for customer since using the label control customerSinceLabel
                customerSinceLabel.Text = Convert.ToString(customerSinceInt);
                // TO DO: Display the value in the variable you declared for preferred customer using the checkbox control preferredCustomerCheckBox
                preferredCustomerCheckBox.Checked = preferredCustomerBoolean;
                // TO DO: Display the value in the variable you declared for FICO credit score using the label control fICOCreditScoreLabel
                fICOCreditScoreLabel.Text = Convert.ToString(fICOCreditScoreInt);
                // TO DO: Display the value in the variable you declared for monthly income using the label control monthlyIncomeLabel. 
                // Use currency format with 2 decimal places.
                monthlyIncomeLabel.Text = monthlyIncomeDecimal.ToString("c2");

                // OUTPUT THE VALUES IN THE ACCOUNT INFORMATION VARIABLES BACK TO THE USER USING CONTROLS ON THE FORM
                // TO DO: Display the value in the variable you declared for account number using the label control accountNumberLabel
                accountNumberLabel.Text = accountNumberString;
                // TO DO: Display the value in the variable you declared for account type using the label control accountTypeLabel
                accountTypeLabel.Text = accountTypeString;
                // TO DO: Display the value in the variable you declared for account balance using the label control accountBalanceLabel. 
                // Use currency format with 2 decimal places.
                accountBalanceLabel.Text = accountBalanceDecimal.ToString("c2");
                // TO DO: Display the value in the variable you declared for current credit limit using the label control currentCreditLimitLabel. 
                // Use currency format with 2 decimal places.
                currentCreditLimitLabel.Text = currentCreditLimitInteger.ToString("c2");
                // TO DO: Display the value in the variable you declared for payments missed using the checkbox control paymentsMissedCheckBox
                paymentsMissedCheckBox.Checked = paymentsMissedBoolean;
            }
            // If the customer number entered in the textbox is neither 417102 nor 732050, then display an error message back to the user
            else
            {
                MessageBox.Show("Sorry, Customer was not found!", "Data Entry Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // TO DO: Declare a function SetAndReturnCreditRatingBasedOnCustomerSinceYear() with 1 parameter 
        // (customerSinceYearInteger)
       private string SetAndReturnCreditRatingBasedOnCustomerSinceYear( int customerSinceYearInteger)
        {
            // TO DO: Declare a variable of the appropriate data type to store the credit rating
            // TO DO: Declare a variable of the appropriate data type to store the credit rating
            string creditRatingString;

            // TO DO: Use a nested if statement block to implement the following business logic.  If the customer has been with the bank since before 2012 and the customer is a preferred customer, then ...
            // ... set the customer's credit rating to "Tier 1".  If the customer has been with the bank since before 2012, but is not a preferred customer, then set the customer's credit rating to "Tier 2". ...
            // ... If the customer has neither been with the bank since before 2012 nor is the customer a preferred customer, set the customer's credit rating to "Tier 3".
            if (customerSinceInt < 2012)
            {
                if (preferredCustomerCheckBox.Checked == true)
                {
                    // TO DO: Set the credit rating to Tier 1
                    creditRatingString = "Tier 1";
                }
                else
                {
                    // TO DO: Set the credit rating to Tier 2
                    creditRatingString = "Tier 2";
                }
            }
            else
            {
                // TO DO: Set the credit rating to Tier 3
                creditRatingString = "Tier 3";
            }

            // TO DO: Return the credit rating back to the function call
            return creditRatingString;
        }

        // TO DO: Declare a function SetAndReturnCreditRatingBasedOnFICOCreditScore() with 1 parameter 
        // (fICOCreditScoreInteger)
        private string SetAndReturnCreditRatingBasedOnFICOCreditScore(int fICOCreditScoreInteger)
        {
            // TO DO: Declare a variable of the appropriate data type to store the credit rating
            // TO DO: Declare a variable of the appropriate data type to store the credit rating
            string creditRatingString;
            // TO DO: Use an if statement block and the appropriate logical operators and relational operators to implement the following business logic.  If the customer's FICO credit score is at least 750, ... 
            // ... then set the customer's credit rating to "Tier 1".  If the customer's FICO credit score is at least 600 but less than 750, then set the customer's credit rating to "Tier 2". ... 
            // ... If the customer's FICO credit score is less than 600, then set the customer's credit rating to "Tier 3".
            if (fICOCreditScoreInt >= 750)
            {
                // TO DO: Set the credit rating to Tier 1
                creditRatingString = "Tier 1";
            }
            else if (fICOCreditScoreInt >= 600 && fICOCreditScoreInt < 750)
            {
                // TO DO: Set the credit rating to Tier 2
                creditRatingString = "Tier 2";
            }
            else
            {
                // TO DO: Set the credit rating to Tier 3
                creditRatingString = "Tier 3";
            }

            // TO DO: Return the credit rating back to the function call
            return creditRatingString;
        }

        // TO DO: Declare a function SetAndReturnCreditRatingBasedOnMonthlyIncomeAndAccountBalance() with 2 parameters
        // (monthlyIncomeDecimal and accountBalanceDecimal)
        private string SetAndReturnCreditRatingBasedOnMonthlyIncomeAndAccountBalance(decimal monthlyIncomeDecimal, decimal accountBalanceDecimal)
        {
            // TO DO: Declare a variable of the appropriate data type to store the credit rating
            // TO DO: Declare a variable of the appropriate data type to store the credit rating
            string creditRatingString;

            // TO DO: Use an if statement block and the appropriate logical operators and relational operators to implement the following business logic.  If the customer's monthly income is at least $4000, ... 
            // ... then set the customer's credit rating to "Tier 1".  If the customer's monthly income is at least $3000 but less than $4000, then set the customer's credit rating to "Tier 2". ... 
            // ... If the customer's monthly income is less than $3000, then set the customer's credit rating to "Tier 3".
            if (monthlyIncomeDecimal >= 4000.00m)
            {
                // TO DO: Set the credit rating to Tier 1
                creditRatingString = "Tier 1";
            }
            else if (monthlyIncomeDecimal >= 3000.00m && monthlyIncomeDecimal < 4000.00m)
            {
                // TO DO: Set the credit rating to Tier 2
                creditRatingString = "Tier 2";
            }
            else
            {
                // TO DO: Set the credit rating to Tier 3
                creditRatingString = "Tier 3";
            }

            // TO DO: Use an if statement block to implement the following business logic.  If the customer's account balance is greater than her/his monthly income ... 
            // ... then set the customer's credit rating to "Tier 1". If not, then set the customer's credit rating to "Tier 3". 
            if (accountBalanceDecimal > monthlyIncomeDecimal)
            {
                // TO DO: Set the credit rating to Tier 1
                creditRatingString = "Tier 1";
            }
            else
            {
                // TO DO: Set the credit rating to Tier 3
                creditRatingString = "Tier 3";
            }

            // TO DO: Return the credit rating back to the function call
            return creditRatingString;
        }

        // TO DO: Declare a function SetAndReturnCreditRatingBasedOnPaymentsMissed() with 1 parameter
        // (paymentsMissedBoolean)
        private string SetAndReturnCreditRatingBasedOnPaymentsMissed(bool paymentsMissedBoolean)
        {
            // TO DO: Declare a variable of the appropriate data type to store the credit rating
            // TO DO: Declare a variable of the appropriate data type to store the credit rating
            string creditRatingString;

            // TO DO: Use an if statement block to implement the following business logic.  If the customer has not missed a credit card payment ... 
            // ... then set the customer's credit rating to "Tier 1".  If not, then set the customer's credit rating to "Tier 3". 
            if (paymentsMissedCheckBox.Checked == false)
            {
                // TO DO: Set the credit rating to Tier 1
                creditRatingString = "Tier 1";
            }
            else
            {
                // TO DO: Set the credit rating to Tier 3
                creditRatingString = "Tier 3";
            }

            // TO DO: Return the credit rating back to the function call
            return creditRatingString;
        }

        // TO DO: Declare a method ProcessCreditCardApplicationBasedOnCreditRating() with 1 parameter
        private void ProcessCreditCardApplicationBasedOnCreditRating(string creditRatingString)
        {
            // TO DO: Move the appropriate variables from the class-level to here (local scope)
            
            // TO DO: Declare a variable of the appropriate data type to store the new credit limit
            int newCreditLimitInteger;

            // TO DO: Fix the code in the following switch statement block to check the value in the credit rating variable in order to decide whether the customer's request for credit limit increase should ...
            // ... be approved or not.  Customers from Tier 1 and Tier 2 do qualify for a credit limit increase.  Customers from Tier 3 do not.  I have already done the calculations, so don't change ...
            // ... any of my code here.
            switch (creditRatingString)
            {
                case "Tier 1":
                    newCreditLimitInteger = currentCreditLimitInteger + 3000;
                    MessageBox.Show("Congratulations!!! You qualify for a credit limit increase. Your new credit limit is " + newCreditLimitInteger.ToString("c2") + "!", "Credit Limit Increase Approved!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    currentCreditLimitInteger = newCreditLimitInteger;
                    currentCreditLimitLabel.BackColor = System.Drawing.Color.PeachPuff;
                    currentCreditLimitLabel.ForeColor = System.Drawing.Color.DarkRed;
                    currentCreditLimitLabel.Text = currentCreditLimitInteger.ToString("c2");
                    cCLimitIncreaceRequestsApprovedCounterInt++;
                    creditLimitIncreaseRequestsApprovedLabel.Text = Convert.ToString(cCLimitIncreaceRequestsApprovedCounterInt);
                    break;

                case "Tier 2":
                    newCreditLimitInteger = currentCreditLimitInteger + 1000;
                    MessageBox.Show("Congratulations!!! You qualify for a credit limit increase. Your new credit limit is " + newCreditLimitInteger.ToString("c2") + "!", "Credit Limit Increase Approved!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    currentCreditLimitInteger = newCreditLimitInteger;
                    currentCreditLimitLabel.BackColor = System.Drawing.Color.PeachPuff;
                    currentCreditLimitLabel.ForeColor = System.Drawing.Color.DarkRed;
                    currentCreditLimitLabel.Text = currentCreditLimitInteger.ToString("c2");
                    cCLimitIncreaceRequestsApprovedCounterInt++;
                    creditLimitIncreaseRequestsApprovedLabel.Text = Convert.ToString(cCLimitIncreaceRequestsApprovedCounterInt);
                    break;
                case "Tier 3":
                    MessageBox.Show("Sorry!!! Your request for a credit limit increase is denied! Please try again after 1 year.", "Credit Limit Increase Denied!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cCLimitIncreaceRequestsDeniedCounterInt++;
                    creditLimitIncreaseRequestsDeniedLabel.Text = Convert.ToString(cCLimitIncreaceRequestsDeniedCounterInt);
                    break;
                default:
                    break;
            }
        }
    }
}
