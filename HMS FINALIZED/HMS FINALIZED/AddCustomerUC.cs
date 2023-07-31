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
    public partial class AddCustomerUC : UserControl
    {
        public AddCustomerUC()
        {
            InitializeComponent();
        }

        private void TextCustomerName_TextChanged(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            // Save the cursor position to restore it after modification
            int cursorPosition = textBox.SelectionStart;

            if (!string.IsNullOrEmpty(textBox.Text))
            {
                string originalText = textBox.Text;

                // Initialize a variable to store the capitalized text
                string capitalizedText = "";

                // Track whether the next character should be capitalized
                bool capitalizeNextChar = true;

                // Iterate through each character in the original text
                foreach (char c in originalText)
                {
                    // Capitalize the current character if needed
                    if (capitalizeNextChar)
                    {
                        capitalizedText += char.ToUpper(c);
                    }
                    else
                    {
                        capitalizedText += char.ToLower(c);
                    }

                    // Determine if the next character should be capitalized
                    if (char.IsWhiteSpace(c))
                    {
                        capitalizeNextChar = true;
                    }
                    else
                    {
                        capitalizeNextChar = false;
                    }
                }

                // Update the text box with the capitalized text
                textBox.Text = capitalizedText;

                // Restore the cursor position
                textBox.SelectionStart = cursorPosition;
            }
        }

        private void EmptyField(Guna2TextBox nameBox, Guna2TextBox CNIC, Guna2TextBox contact)
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
            if (string.IsNullOrEmpty(contact.Text.Trim()))
            {
                errorProvider1.SetError(contact, "Contact is required");
                contact.BorderColor = Color.Red;
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

        private void ContactField(Guna2TextBox textBox)
        {
            if (textBox.Text != "")
            {
                if (!Validation.contact_check(textBox.Text))
                {
                    errorProvider1.SetError(textBox, "Invalid Format");
                    textBox.BorderColor = Color.Red;
                    textBox.Clear();
                }
                else
                {
                    errorProvider1.SetError(textBox, string.Empty);
                    textBox.BorderColor = Color.Green;
                }
            }
        }

        private void TextCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                NameField(TextCustomerName);
            }
        }

        private void TextCustomerName_MouseLeave(object sender, EventArgs e)
        {
            NameField(TextCustomerName);
        }

        private void TextCNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                CNIC_Field(TextCNIC);
            }
        }

        private void TextCNIC_MouseLeave(object sender, EventArgs e)
        {
            CNIC_Field(TextCNIC);
        }

        private void TextContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                ContactField(TextContact);
            }
        }

        private void TextContact_MouseLeave(object sender, EventArgs e)
        {
            ContactField(TextContact);
        }

        private bool NotZeroIndex(Guna2ComboBox item)
        {
            if (item.SelectedIndex == 0)
            {
                return false;
            }
            else
            {
                errorProvider1.SetError(item, string.Empty);
                item.BorderColor = Color.Green;
                return true;
            }
        }

        private void comboBox(Guna2ComboBox item)
        {
            if (item.SelectedIndex == 0)
            {
                errorProvider1.SetError(item, "Select an option");
                item.BorderColor = Color.Red;
            }
        }

        private void ClearAddCustomerData()
        {
            TextCustomerName.Clear();
            TextCustomerName.BorderColor = Color.FromArgb(213, 218, 223);
            TextCNIC.Clear();
            TextCNIC.BorderColor = Color.FromArgb(213, 218, 223);
            TextContact.Clear();
            TextContact.BorderColor = Color.FromArgb(213, 218, 223);
            TextCityComboBox1.SelectedIndex = 0;
            TextPersonComboBox.SelectedIndex = 0;
            TextRoomComboBox.SelectedIndex = 0;
            Check_inDateTimePicker.Value = DateTime.Now;
            Check_inDateTimePicker.BorderColor = Color.FromArgb(213, 218, 223);
            CheckoutDateTimePicker.Value = DateTime.Now;
            CheckoutDateTimePicker.BorderColor = Color.FromArgb(213, 218, 223);
        }

        private void TextCityComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TextCityComboBox1.SelectedIndex == 0)
            {
                TextCityComboBox1.BorderColor = Color.FromArgb(213, 218, 223);
            }
            else
            {
                errorProvider1.SetError(TextCityComboBox1, string.Empty);
                TextCityComboBox1.BorderColor = Color.Green;
            }
        }

        private void TextPersonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TextPersonComboBox.SelectedIndex == 0)
            {
                TextPersonComboBox.BorderColor = Color.FromArgb(213, 218, 223);
            }
            else
            {
                errorProvider1.SetError(TextPersonComboBox, string.Empty);
                TextPersonComboBox.BorderColor = Color.Green;
            }
        }

        private void TextRoomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TextRoomComboBox.SelectedIndex == 0)
            {
                TextRoomComboBox.BorderColor = Color.FromArgb(213, 218, 223);
            }
            else
            {
                errorProvider1.SetError(TextRoomComboBox, string.Empty);
                TextRoomComboBox.BorderColor = Color.Green;
            }
        }

        private void Check_inDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(Check_inDateTimePicker, string.Empty);
            Check_inDateTimePicker.BorderColor = Color.Green;
        }

        private void CheckoutDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(CheckoutDateTimePicker, string.Empty);
            CheckoutDateTimePicker.BorderColor = Color.Green;
        }

        private void AddCustomerGradientButton_Click(object sender, EventArgs e)
        {
            EmptyField(TextCustomerName, TextCNIC, TextContact);
            NameField(TextCustomerName);
            CNIC_Field(TextCNIC);
            comboBox(TextCityComboBox1);
            comboBox(TextPersonComboBox);
            comboBox(TextRoomComboBox);
            DateTime checkIn = Check_inDateTimePicker.Value;
            DateTime checkout = CheckoutDateTimePicker.Value;
            if (checkIn.Date != checkout.Date && checkIn.Date < checkout.Date && checkIn.Year <= checkout.Year && checkIn.Month <= checkout.Month)
            {
                string name = TextCustomerName.Text;
                string id = TextCNIC.Text;
                string contact = TextContact.Text;
                string city = TextCityComboBox1.Text;
                string totalPerson = TextPersonComboBox.Text;
                string roomType = TextRoomComboBox.Text;
                string check_in_date = Convert.ToString(checkIn);
                string check_out_date = Convert.ToString(checkout);

                if (Validation.isValid(TextCustomerName.Text) && Validation.id_check(TextCNIC.Text) && Validation.contact_check(TextContact.Text) && NotZeroIndex(TextCityComboBox1) && NotZeroIndex(TextPersonComboBox) && NotZeroIndex(TextRoomComboBox))
                {
                    if (PersonDL.checkCustomer(name, id))
                    {
                        int roomNumber = PersonDL.assignRoom();
                        Customer info = new Customer(name, id, contact, city, totalPerson, roomType, roomNumber, check_in_date, check_out_date);
                        PersonDL.addPersonIntoList(info);
                        PersonDL.saveData();
                        Room.roomCount++;
                        MessageBox.Show("Customer Added Successfully", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAddCustomerData();
                    }
                    else
                    {
                        MessageBox.Show("Already Exist", "Add Customer Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                errorProvider1.SetError(CheckoutDateTimePicker, "Check-out Date can't be same as Check-In Date");
                CheckoutDateTimePicker.BorderColor = Color.Red;
            }
        }
    }
}
