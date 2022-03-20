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
    public partial class LetterInput : Form
    {
        private List<Address> addressList;
        public LetterInput(List<Address> addresses)
        {
            InitializeComponent();
            addressList = addresses;
            
        }
        internal string FixedCost
        {
            get { return fixCostTxt.Text; }
            set { fixCostTxt.Text = value; }
        }
        internal int OriAdd
        {
            get { return destComboBox.SelectedIndex; }
            set { destComboBox.Text = value.ToString(); }
        }
        internal int DesAdd
        {
            get { return originCombo.SelectedIndex; }
            set { originCombo.Text = value.ToString(); }
        }



        private void cancelmouseBttn(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        private void origin_Validating(object sender, CancelEventArgs e)
        {
            if (originCombo.SelectedIndex < 0 || originCombo == destComboBox)
            {
                e.Cancel = true;
                errorProvider1.SetError(originCombo, "Enter value for Origin");
                originCombo.SelectAll();
            }

        }
        private void origin_Validated(object sender, EventArgs e)
        {

            errorProvider1.Clear(); //Clears the Error

        }
        private void dest_Validating(object sender, CancelEventArgs e)
        {
            if (destComboBox.SelectedIndex < 0 || destComboBox.SelectedIndex == originCombo.SelectedIndex)
            {
                e.Cancel = true;
                errorProvider1.SetError(destComboBox, "enter a value for destination");
                destComboBox.SelectAll();
            }
        }

        private void dest_Validate(object sender, EventArgs e)
        {
            errorProvider1.Clear(); //Clears the Error
        }



        private void fixed_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
        private void fixed_Validating(object sender, CancelEventArgs e)
        {
            int number; // Value entered into inputTxt

            // Will try to parse text as int
            // If fails, TryParse returns false
            // If succeeds, TryParse returns true and number stores parsed value
            if (!int.TryParse(fixCostTxt.Text, out number))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProvider1.SetError(fixCostTxt, "Enter an Zip!"); // Set error message

                fixCostTxt.SelectAll(); // Select all text in inputTxt to ease correction
            }
            else
            {
                if (number < 0)
                {
                    e.Cancel = true; // Stops focus changing process
                    // Will NOT proceed to Validated event

                    errorProvider1.SetError(fixCostTxt, "Enter a non-negative integer!"); // Set error message

                    fixCostTxt.SelectAll(); // Select all text in inputTxt to ease correction
                }
            }


        }

        private void LetterInput_Load(object sender, EventArgs e)
        {
            foreach (Address a in addressList)
            {
                originCombo.Items.Add(a.Name);
                destComboBox.Items.Add(a.Name);

            }
        }
    }
}

