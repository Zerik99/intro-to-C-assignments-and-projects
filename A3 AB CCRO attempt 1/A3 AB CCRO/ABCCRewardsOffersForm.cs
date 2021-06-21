// TO DO: Enter the following information
// Class Name:  ABCCRewardsOffersForm
// Program Purpose:   view available rewards offers on their credit card, to load
//those offers onto their credit card, and to cancel loaded offers from their credit card if necessary.
// Programmed By:  Erik Zander
// Program Date:  enter today's date here
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3_AB_CCRO
{
    public partial class ABCCRewardsOffersForm : Form
    {
        public ABCCRewardsOffersForm()
        {
            InitializeComponent();
        }

        private void ABCCRewardsOffersForm_Load(object sender, EventArgs e)
        {
            // TO DO: Add code below to display the total number of items in the availableOffersComboBox combo box control
            // using the countOfAvailableOffersLabel label control
            int countOfAvailableOffers;
            countOfAvailableOffers = availableOffersComboBox.Items.Count;
            countOfAvailableOffersLabel.Text = countOfAvailableOffers.ToString();


            // TO DO: Add code below to display the total number of items in the loadedOffersListBox list box control
            // using the countOfLoadedOffersLabel label control
            int countOfloadedOffers;
            countOfloadedOffers = loadedOffersListBox.Items.Count;
            countOfLoadedOffersLabel.Text = countOfloadedOffers.ToString();

            // TO DO: Add code below to set the Image property of the creditCardPictureBox control to null
            creditCardPictureBox.Image = null;
        }

        private void DisplayCreditCardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // TO DO: Use an if statement block to check if the displayCreditCardCheckBox
            // is checked
            if (displayCreditCardCheckBox.Checked == true)
            {
                    // TO DO: Add code below to display the credit card image in the 
                    // creditCardPictureBox control
                    creditCardPictureBox.Image = Properties.Resources.DavidNewtonCreditCard;
                
            }
            else
            {
                // TO DO: Add code below to set the Image property of the creditCardPictureBox 
                // control to null
                creditCardPictureBox.Image = null;
            }

        }

        private void AddNewOfferButton_Click(object sender, EventArgs e)
        {
            // TO DO: Declare a variable to store the new offer
            string newOffer;

            // TO DO: Get the new offer from the user and store it in the variable you 
            // declared earlier
            newOffer = availableOffersComboBox.Text;


            // TO DO: Add the new offer to the availableOffersComboBox combo box
            // control's Items collection by passing the value in the variable
            // as an argument to the appropriate method call
            if (availableOffersComboBox.Items.Contains(newOffer))        
            {
                MessageBox.Show("Sorry you can't add an offer that is already listed.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else 
            {
                availableOffersComboBox.Items.Add(newOffer); 
            }
            
            


            // TO DO: Clear the text in the text box portion of the 
            // availableOffersComboBox combo box
            availableOffersComboBox.Text = "";

            // TO DO: Add code below to display the total number of items in the 
            // availableOffersComboBox combo box control using the
            // countOfAvailableOffersLabel label control since the number of items
            // has changed now
            int countOfAvailableOffers;
            countOfAvailableOffers = availableOffersComboBox.Items.Count;
            countOfAvailableOffersLabel.Text = countOfAvailableOffers.ToString();


            // TO DO: Add code below to disable the addNewOfferButton button control
            addNewOfferButton.Enabled = false;
            // TO DO: Add code below to disable the addNewOfferToolStripMenuItem control
            addNewOfferToolStripMenuItem.Enabled = false;
        }

        private void LoadOfferOntoCreditCardButton_Click(object sender, EventArgs e)
        {
            // TO DO: Declare a variable to store the selected offer
            string selectedOfferString;

            // TO DO: Get the selected item from the combo box and store it 
            // in the variable you declared earlier
            selectedOfferString = availableOffersComboBox.Text;

            // TO DO: Add code below to add the selected item in the 
            // availableOffersComboBox combo box control to the 
            // loadedOffersListBox list box control
            loadedOffersListBox.Items.Add(selectedOfferString);

            // TO DO: Since the selected item from the availableOffersComboBox combo box control
            // has been added to the loadedOffersListBox list box control, add code below to
            // remove the selected item from the availableOffersComboBox combo box control
            availableOffersComboBox.Items.Remove(selectedOfferString);

            // TO DO: Add code below to display the total number of items in the 
            // availableOffersComboBox combo box control using the 
            // countOfAvailableOffersLabel label control since the number of items 
            // has changed now
            int countOfAvailableOffers;
            countOfAvailableOffers = availableOffersComboBox.Items.Count;
            countOfAvailableOffersLabel.Text = countOfAvailableOffers.ToString();

            // TO DO: Add code below to display the total number of items in the 
            // loadedOffersListBox list box control using the 
            // countOfLoadedOffersLabel label control since the number of items 
            // has changed now
            int countOfloadedOffers;
            countOfloadedOffers = loadedOffersListBox.Items.Count;
            countOfLoadedOffersLabel.Text = countOfloadedOffers.ToString();

            // TO DO: Add code below to disable the loadOfferOntoCreditCardButton, 
            // loadOfferOntoCreditCardToolStripMenuItem, addNewOfferButton, and
            // addNewOfferToolStripMenuItem controls
            loadOfferOntoCreditCardButton.Enabled = false;
            addNewOfferButton.Enabled = false;
            addNewOfferToolStripMenuItem.Enabled = false;
            loadOfferOntoCreditCardToolStripMenuItem.Enabled = false;
        }

        private void CancelLoadedOfferButton_Click(object sender, EventArgs e)
        {
            // TO DO: Declare a variable to store the selected offer
            string cancelOfferString;

            // TO DO: Get the selected item from the list box and store it 
            // in the variable you declared earlier
            cancelOfferString = loadedOffersListBox.SelectedItem.ToString();

            // TO DO: Add code below to add the selected item in the loadedOffersListBox
            // list box control to the availableOffersComboBox combo box control
            availableOffersComboBox.Items.Add(cancelOfferString);

            // TO DO: Since the selected item from the loadedOffersListBox list box control 
            // has been added back to the availableOffersComboBox combo box control, add code 
            // below to remove the selected item from the loadedOffersListBox list box control
            loadedOffersListBox.Items.Remove(cancelOfferString);

            // TO DO: Add code below to display the total number of items in the 
            // availableOffersComboBox combo box control using the countOfAvailableOffersLabel
            // label control since the number of items has changed
            int countOfAvailableOffers;
            countOfAvailableOffers = availableOffersComboBox.Items.Count;
            countOfAvailableOffersLabel.Text = countOfAvailableOffers.ToString();

            // TO DO: Add code below to display the total number of items in the 
            // loadedOffersListBox list box control using the countOfLoadedOffersLabel label
            // control since the number of items has changed
            int countOfloadedOffers;
            countOfloadedOffers = loadedOffersListBox.Items.Count;
            countOfLoadedOffersLabel.Text = countOfloadedOffers.ToString();

            // TO DO: Add code below to disable the cancelLoadedOfferButton button control
            // and the cancelLoadedOfferToolStripMenuItem control
            cancelLoadedOfferButton.Enabled = false;
            cancelLoadedOfferToolStripMenuItem.Enabled = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // TO DO: Add code below to close the application
            this.Close();
        }

        private void availableOffersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TO DO: Use an if statement block to check if an item has been 
            // selected in the availableOffersComboBox combo box control
            if (availableOffersComboBox.SelectedIndex != -1)
            {
                // TO DO: Enable the loadOfferOntoCreditCardButton button control
                loadOfferOntoCreditCardButton.Enabled = true;
                // TO DO: Enable the loadOfferOntoCreditCardToolStripMenuItem control
                loadOfferOntoCreditCardToolStripMenuItem.Enabled = true;
            }
        }

        private void loadedOffersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TO DO: Use an if statement block to check if an item has been 
            // selected in the loadedOffersListBox list box control
            if (loadedOffersListBox.SelectedIndex != -1)
            {
                // TO DO: Enable the cancelLoadedOfferButton button control
                cancelLoadedOfferButton.Enabled = true;
                // TO DO: Enable the cancelLoadedOfferToolStripMenuItem control
                cancelLoadedOfferToolStripMenuItem.Enabled = true;
            }
        }

        private void availableOffersComboBox_TextChanged(object sender, EventArgs e)
        {
            // TO DO: Use an if-statement block to check whether the combo box
            // is empty
            if (availableOffersComboBox.Text == "")
            {
                // TO DO: Disable the addNewOfferButton control
                addNewOfferButton.Enabled = false;
                // TO DO: Disable the addNewOfferToolStripMenuItem control
                addNewOfferToolStripMenuItem.Enabled = false;
            }
            else
            {
                // TO DO: Enable the addNewOfferButton control
                addNewOfferButton.Enabled = true;
                // TO DO: Enable the addNewOfferToolStripMenuItem control
                addNewOfferToolStripMenuItem.Enabled = true;
            }
        }

        private void countAvailableOffersToolStripMenuItem_Click(object sender, EventArgs e)
        { string message;
            int countOfAvailableOffers;
            countOfAvailableOffers = availableOffersComboBox.Items.Count;
            message = countOfAvailableOffers.ToString();
            MessageBox.Show(message, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void countLoadedOffersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message;
            int countOfloadedOffers;
            countOfloadedOffers = loadedOffersListBox.Items.Count;
            message = countOfloadedOffers.ToString();
            MessageBox.Show(message, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message;
            message = "American Bank Credit Card Rewards Offers Application \nVersion: 1.0 \nProgrammed by: Erik Zander";
            MessageBox.Show(message, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        /*
        private void AvailableOffersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LoadedOffersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AvailableOffersComboBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CountAvailableOffersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TO DO: Use a 4-argument message box to display the count of available
            // offers back to the user
            
        }

        private void CountLoadedOffersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TO DO: Use a 4-argument message box to display the count of loaded
            // offers back to the user
            
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TO DO: Use a 4-argument message box to display information about the
            // application back to the user (refer to step 17 in the instruction sheet)
            
        } 
        */
    }
}
