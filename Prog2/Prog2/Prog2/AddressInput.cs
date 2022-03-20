using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class AddressInput : Form
    {
        public AddressInput()
        {
            InitializeComponent();
            stateComboBox.Text = "KY";
        }

        internal string AddressName
        {
            // Precondition:  None
            // Postcondition: Text in nameTxt is returned
            get { return nameTxt.Text; }
            // Precondition:  None
            // Postcondition: Text in nameTxt is set to specified value
            set { nameTxt.Text = value; }

        }
        internal string Address
        {
            // Precondition:  None
            // Postcondition: Text in addressTxt is returned
            get { return addressTxt.Text; }
            // Precondition:  None
            // Postcondition: Text in addressTxt is set to specified value
            set { addressTxt.Text = value; }

        }
        internal string Address2
        {
            // Precondition:  None
            // Postcondition: Text in address2Txt is returned
            get { return address2Txt.Text; }
            // Precondition:  None
            // Postcondition: Text in address2Txt is set to specified value
            set { address2Txt.Text = value; }

        }
        internal string City
        {
            // Precondition:  None
            // Postcondition: Text in cityTxt is returned
            get { return cityTxt.Text; }
            // Precondition:  None
            // Postcondition: Text in cityTxt is set to specified value
            set { cityTxt.Text = value; }

        }
        internal string State
        {
            // Precondition:  None
            // Postcondition: Text in stateTxt is returned
            get { return stateComboBox.Text; }
            // Precondition:  None
            // Postcondition: Text in stateTxt is set to specified value
            set { stateComboBox.Text = value; }

        }



        internal string zipValue // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in zipTxt is returned
            get { return zipTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in zipTxt is set to specified value
            set { zipTxt.Text = value; }
        }
        private void intZipValidating(object sender, CancelEventArgs e)
        {
            int number; // Value entered into inputTxt

            // Will try to parse text as int
            // If fails, TryParse returns false
            // If succeeds, TryParse returns true and number stores parsed value
            if (!int.TryParse(zipTxt.Text, out number))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProvider1.SetError(zipTxt, "Enter an Zip!"); // Set error message

                zipTxt.SelectAll(); // Select all text in inputTxt to ease correction
            }
            else
            {
                if (number < 0 )
                {
                    e.Cancel = true; // Stops focus changing process
                    // Will NOT proceed to Validated event

                    errorProvider1.SetError(zipTxt, "Enter a non-negative integer!"); // Set error message

                    zipTxt.SelectAll(); // Select all text in inputTxt to ease correction
                }
                if (number > 99999)
                {
                    e.Cancel = true; // Stops focus changing process
                    // Will NOT proceed to Validated event

                   errorProvider1.SetError(zipTxt, "Enter a number less than 99999!"); // Set error message

                    zipTxt.SelectAll(); // Select all text in inputTxt to ease correction
                }
            }
        }


        // Precondition:  inputTxt_Validating succeeded
        // Postcondition: Any error message set for inputTxt is cleared
        //                Focus is allowed to change
        private void intZipValidated(object sender, EventArgs e)
        {
            errorProvider1.SetError(zipTxt, ""); // Clears error message
        }
        private void name_validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(nameTxt.Text) || string.IsNullOrWhiteSpace(nameTxt.Text)) //If the textbox is empty or has white space
            {// it will throw an error
                e.Cancel = true;
                errorProvider1.SetError(nameTxt, "Please Enter a Name");
                nameTxt.SelectAll();
            }
        }
        private void name_valid(object sender, EventArgs e)
        {
            errorProvider1.Clear(); //Clears the Error
        }
        //145-179 are the same logic as above
        private void address_validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(addressTxt.Text) || string.IsNullOrWhiteSpace(addressTxt.Text))
            {
                e.Cancel = true;
                errorProvider2.SetError(addressTxt, "Please Enter a Address");
                addressTxt.SelectAll(); 
            }
        }
        private void address_validated(object sender, EventArgs e)
        {

            {
                errorProvider2.Clear();
            }

        }

        private void city_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cityTxt.Text) || string.IsNullOrWhiteSpace(cityTxt.Text))
            {
                e.Cancel = true;
                errorProvider2.SetError(cityTxt, "Please Enter a City");
                addressTxt.SelectAll();
            }

        }
        private void city_Validated(object sender, EventArgs e)
        {
            {
                errorProvider2.Clear();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }


        private void cancelBtn_Mouse(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
        }


    }
}
