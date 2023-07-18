using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using HMS_FINALIZED.BL;
using HMS_FINALIZED.DL;

namespace HMS_FINALIZED
{
    public partial class RemoveCustomerUC : UserControl
    {
        public RemoveCustomerUC()
        {
            InitializeComponent();
        }

        private void EmptyField(Guna2TextBox nameBox, Guna2TextBox CNIC)
        {
            if (string.IsNullOrEmpty(nameBox.Text.Trim()))
            {
                errorProvider1.SetError(nameBox, "Name is required");
                nameBox.BorderColor = Color.Red;
            }
            if (string.IsNullOrEmpty(CNIC.Text.Trim()))
            {
                errorProvider1.SetError(CNIC, "CNIC is required");
                CNIC.BorderColor = Color.Red;
            }
        }

        private void NameField(Guna2TextBox nameBox)
        {
            if (nameBox.Text != "")
            {
                if (!Validation.isValid(nameBox.Text))
                {
                    errorProvider1.SetError(nameBox, "Invalid Name");
                    nameBox.BorderColor = Color.Red;
                    nameBox.Clear();
                }
                else
                {
                    errorProvider1.SetError(nameBox, string.Empty);
                    nameBox.BorderColor = Color.Green;
                }
            }
        }

        private void CNIC_Field(Guna2TextBox CNICBox)
        {
            if (CNICBox.Text != "")
            {
                if (!Validation.id_check(CNICBox.Text))
                {
                    errorProvider1.SetError(CNICBox, "Invalid CNIC Format");
                    CNICBox.BorderColor = Color.Red;
                    CNICBox.Clear();
                }
                else
                {
                    errorProvider1.SetError(CNICBox, string.Empty);
                    CNICBox.BorderColor = Color.Green;
                }
            }
        }

        private void TextRemoveName_TextChanged(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            // Make sure the text box is not empty
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                // Convert the first letter to uppercase
                char firstChar = char.ToUpper(textBox.Text[0]);

                // Convert the remaining letters to lowercase
                string remainingChars = textBox.Text.Substring(1).ToLower();

                // Set the modified text back to the text box
                textBox.Text = firstChar + remainingChars;

                // Set the cursor position to the end of the text box
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void TextRemoveName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                NameField(TextRemoveName);
            }
        }

        private void TextRemoveName_MouseLeave(object sender, EventArgs e)
        {
            NameField(TextRemoveName);
        }

        private void TextRemoveID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                CNIC_Field(TextRemoveID);
            }
        }

        private void TextRemoveID_MouseLeave(object sender, EventArgs e)
        {
            CNIC_Field(TextRemoveID);
        }

        private void ClearRemoveCustomerData()
        {
            TextRemoveName.Clear();
            TextRemoveName.BorderColor = Color.FromArgb(213, 218, 223);
            TextRemoveID.Clear();
            TextRemoveID.BorderColor = Color.FromArgb(213, 218, 223);
        }

        private void RemoveGradientButton_Click(object sender, EventArgs e)
        {
            EmptyField(TextRemoveName, TextRemoveID);
            NameField(TextRemoveName);
            CNIC_Field(TextRemoveID);
            if (Validation.isValid(TextRemoveName.Text) && Validation.id_check(TextRemoveID.Text))
            {
                Customer info = new Customer(TextRemoveName.Text, TextRemoveID.Text);
                int index = PersonDL.foundCustomer(info);
                if (index == -1)
                {
                    MessageBox.Show("Customer is not staying in this hotel", "Remove Customer Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearRemoveCustomerData();
                }
                else
                {
                    PersonDL.removePerson(index);
                    PersonDL.saveData();
                    MessageBox.Show("Customer Removed Successfully", "Remove Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearRemoveCustomerData();
                }
            }
        }
    }
}
