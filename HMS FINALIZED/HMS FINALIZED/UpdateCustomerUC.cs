﻿using System;
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
    public partial class UpdateCustomerUC : UserControl
    {
        private int customerIndex = 0;

        public UpdateCustomerUC()
        {
            InitializeComponent();
            Panel_Update.Visible = false;
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

        private void TextName_TextChanged(object sender, EventArgs e)
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

        private void TextName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                NameField(TextName);
            }
        }

        private void TextName_MouseLeave(object sender, EventArgs e)
        {
            NameField(TextName);
        }

        private void TextID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                CNIC_Field(TextID);
            }
        }

        private void TextID_MouseLeave(object sender, EventArgs e)
        {
            CNIC_Field(TextID);
        }

        private void ClearCustomerData()
        {
            TextName.Clear();
            TextName.BorderColor = Color.FromArgb(213, 218, 223);
            TextID.Clear();
            TextID.BorderColor = Color.FromArgb(213, 218, 223);
            Panel_Update.Visible = false;
        }

        private void UpdateCustomerGradientButton_Click(object sender, EventArgs e)
        {
            EmptyField(TextName, TextID);
            NameField(TextName);
            CNIC_Field(TextID);
            if (Validation.isValid(TextName.Text) && Validation.id_check(TextID.Text))
            {
                Customer info = new Customer(TextName.Text, TextID.Text);
                int index = PersonDL.foundCustomer(info);
                if (index == -1)
                {
                    MessageBox.Show("Customer is not staying in this hotel", "Customer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearCustomerData();
                }
                else
                {
                    Panel_Update.Visible = true;
                    ClearUpdateCustomerData();
                    customerIndex = index;
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Panel_Update.Visible = false;
            ClearCustomerData();
        }

        private void TextUpdateName_TextChanged(object sender, EventArgs e)
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

        private void TextUpdateName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                NameField(TextUpdateName);
            }
        }

        private void TextUpdateName_MouseLeave(object sender, EventArgs e)
        {
            NameField(TextUpdateName);
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

        private void ClearUpdateCustomerData()
        {
            TextUpdateName.Clear();
            TextUpdateName.BorderColor = Color.FromArgb(213, 218, 223);
            TextPersonComboBox.SelectedIndex = 0;
            TextRoomComboBox.SelectedIndex = 0;
            CheckoutDateTimePicker.Value = DateTime.Now;
            CheckoutDateTimePicker.BorderColor = Color.FromArgb(213, 218, 223);
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

        private void CheckoutDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(CheckoutDateTimePicker, string.Empty);
            CheckoutDateTimePicker.BorderColor = Color.Green;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            int index = customerIndex;
            string name = TextUpdateName.Text;
            string totalPerson = TextPersonComboBox.Text;
            string roomType = TextRoomComboBox.Text;
            string checkOutDate = CheckoutDateTimePicker.Text;

            if (!Validation.isValid(name) && !NotZeroIndex(TextPersonComboBox) && !NotZeroIndex(TextRoomComboBox))
            {
                MessageBox.Show("Data Update Failed ", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Validation.isValid(name) && name != "")
                {
                    PersonDL.updateName(name, index);
                }

                if (Validation.isValid(totalPerson) && totalPerson != "")
                {
                    PersonDL.updateTotalPerson(totalPerson, index);
                }

                if (Validation.isValid(roomType) && roomType != "")
                {
                    PersonDL.updateRoomType(roomType, index);
                }

                if (Validation.isValid(checkOutDate) && checkOutDate != "")
                {
                    PersonDL.updateCheckoutDate(checkOutDate, index);
                }

                PersonDL.saveData();
                MessageBox.Show("Customer Data Updated Successfully", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearCustomerData();
                Panel_Update.Visible = false;
            }
        }
    }
}