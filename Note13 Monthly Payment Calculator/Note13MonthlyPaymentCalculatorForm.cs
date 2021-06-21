using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note13_Monthly_Payment_Calculator
{
    public partial class Note13MonthlyPaymentCalculatorForm : Form
    {
        //declare class level variable
        double monthlyPaymentDouble;
        double interestRateDouble;
        double principalDouble;
        int numberOfMonthsInt;
        const int MONTHS_Integer = 12;


        public Note13MonthlyPaymentCalculatorForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Erik Zander

           /* interestRateDouble = Convert.ToDouble(interestRateTextBox.Text);
            principalDouble = Convert.ToDouble(principleTextBox.Text);
            numberOfMonthsInt = Convert.ToInt32(numberOfMonthsTextBox.Text);
           */



            //Math.Pow( 1 + interestRateDouble / MONTHS_Integer, - numberOfMonthsInt)

            //not functioning
            // monthlyPaymentDouble = ((interestRateDouble / MONTHS_Integer) * principalDouble)
            //  / (1 - (1 + (interestRateDouble / MONTHS_Int

            //  monthlyPaymentDouble = ((interestRateDouble / MONTHS_Integer) * principalDouble) 
            //     / (1 - Math.Pow(1 + interestRateDouble / MONTHS_Integer, -numberOfMonthsInt));

            monthlyPaymentDouble = MonthlyPaymentFuncation(monthlyPaymentDouble);

            outPutLabel.Text = monthlyPaymentDouble.ToString("c2") ;
        }

        private double MonthlyPaymentFuncation(double monthlyPaymentDouble)    
        {
            interestRateDouble = Convert.ToDouble(interestRateTextBox.Text);
            principalDouble = Convert.ToDouble(principleTextBox.Text);
            numberOfMonthsInt = Convert.ToInt32(numberOfMonthsTextBox.Text);

            monthlyPaymentDouble = ((interestRateDouble / MONTHS_Integer) * principalDouble)
              / (1 - Math.Pow(1 + interestRateDouble / MONTHS_Integer, -numberOfMonthsInt));
            return monthlyPaymentDouble;
        }
    }
}
