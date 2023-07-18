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
    public partial class SearchCustomer : UserControl
    {
        public SearchCustomer()
        {
            InitializeComponent();
            Panel_SearchMini.Visible = false;
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

        private void TextSearchName_TextChanged(object sender, EventArgs e)
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

        private void TextSearchName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                NameField(TextSearchName);
            }
        }

        private void TextSearchName_Leave(object sender, EventArgs e)
        {
            NameField(TextSearchName);
        }

        private void TextSearchID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                CNIC_Field(TextSearchID);
            }
        }

        private void TextSearchID_Leave(object sender, EventArgs e)
        {
            CNIC_Field(TextSearchID);
        }

        private void ClearSearchCustomerData()
        {
            TextSearchName.Clear();
            TextSearchName.BorderColor = Color.FromArgb(213, 218, 223);
            TextSearchID.Clear();
            TextSearchID.BorderColor = Color.FromArgb(213, 218, 223);
            Panel_SearchMini.Visible = false;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Panel_SearchMini.Visible = false;
            ClearSearchCustomerData();
        }

        private void SearchGradientButton_Click(object sender, EventArgs e)
        {
            EmptyField(TextSearchName, TextSearchID);
            NameField(TextSearchName);
            CNIC_Field(TextSearchID);
            if (Validation.isValid(TextSearchName.Text) && Validation.id_check(TextSearchID.Text))
            {
                Customer info = new Customer(TextSearchName.Text, TextSearchID.Text);
                int index = PersonDL.foundCustomer(info);
                if (index == -1)
                {
                    MessageBox.Show("Customer is not staying in this hotel", "Customer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearSearchCustomerData();
                }
                else
                {
                    Panel_SearchMini.Visible = true;
                    foreach (Person p in PersonDL.PersonList)
                    {
                        if (info.getName() == p.getName() && info.getID() == p.getID())
                        {
                            labelName.Text = p.getName();
                            labelCNIC.Text = p.getID();
                            labelContact.Text = p.getContact();
                            labelCity.Text = p.getCity();
                            labelRoomNumber.Text = Convert.ToString(p.getRoomNumber());
                            labelRoomType.Text = p.getRoomType();
                            labelPerson.Text = p.getTotalPerson();
                            labelCheckInDate.Text = p.getCheckInDate();
                            labelCheckOutDate.Text = p.getCheckOutDate();
                            break;
                        }
                    }
                }
            }
        }
    }
}
