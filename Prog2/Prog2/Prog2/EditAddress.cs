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
    public partial class EditAddress : Form
    {
        private List<Address> addressList;
        public EditAddress(List<Address> addresses)
        {
            InitializeComponent();
            addressList = addresses;
        }
        internal int AddressIndex
        {
            get
            {
                return comboBox1.SelectedIndex;
            }
            set
            {
                if ((value >= -1) && (value < addressList.Count))
                    comboBox1.SelectedIndex = value;
                else
                    throw new ArgumentOutOfRangeException("Selected Index", value, "has to be valid");
            }
        }

        private void EditAddress_Load(object sender, EventArgs e)
        {
            foreach (Address a in addressList)
            {
                comboBox1.Items.Add(a.Name);
            }
            comboBox1.SelectedIndex = 0; 
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                DialogResult = DialogResult.OK;
        }

        private void listBox_validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(comboBox1, "");
        }

        private void listBox_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                e.Cancel = true;
            errorProvider1.SetError(comboBox1, "Select a Address");
        }
    }
}
