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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextUsername.Select();
            TextPassword.UseSystemPasswordChar = true;
            TextConfirmPassword.UseSystemPasswordChar = true;
            LoginPassword.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClearSignUpPanelData()
        {
            TextUsername.Text = "";
            errorProvider1.SetError(TextUsername, string.Empty);
            TextUsername.BorderColor = Color.LightGray;
            TextPassword.Text = "";
            errorProvider1.SetError(TextPassword, string.Empty);
            TextPassword.BorderColor = Color.LightGray;
            TextConfirmPassword.Text = "";
            errorProvider1.SetError(TextConfirmPassword, string.Empty);
            TextConfirmPassword.BorderColor = Color.LightGray;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Panel_SignUp.Visible = true;
            guna2Transition1.ShowSync(Panel_SignUp);
            ClearSignUpPanelData();
            TextUsername.Select();
            SignUpToggleSwitch.Checked = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Panel_SignUp.Visible = false;
            guna2Transition1.HideSync(Panel_SignUp);
            ClearLoginPanelData();
            LoginName.Select();
        }

        private void SignUpToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (SignUpToggleSwitch.Checked)
            {
                TextPassword.UseSystemPasswordChar = false;
                TextConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TextPassword.UseSystemPasswordChar = true;
                TextConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void EmptyField(Guna2TextBox nameBox, Guna2TextBox passwordBox)
        {
            if (string.IsNullOrEmpty(nameBox.Text.Trim()))
            {
                errorProvider1.SetError(nameBox, "User name is required");
                nameBox.BorderColor = Color.Red;
            }
            if (string.IsNullOrEmpty(passwordBox.Text.Trim()))
            {
                errorProvider1.SetError(passwordBox, "Password is required");
                passwordBox.BorderColor = Color.Red;
            }
            if (string.IsNullOrEmpty(TextConfirmPassword.Text.Trim()))
            {
                errorProvider1.SetError(TextConfirmPassword, "Confirm Password is required");
                TextConfirmPassword.BorderColor = Color.Red;
            }
        }

        private void NameField(Guna2TextBox textBox)
        {
            if (textBox.Text != "")
            {
                if (!Validation.userName_check(textBox.Text))
                {
                    errorProvider1.SetError(textBox, "at least 4 characters (only use alphabets, numbers and underscore)");
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

        private void PasswordField(Guna2TextBox textBox)
        {
            if (textBox.Text != "")
            {
                if (!Validation.password_check(textBox.Text))
                {

                    errorProvider1.SetError(textBox, "at least 8 characters, containing uppercase, lowercase, numeric, and special characters(#,$,%,&)");
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
        private void ConfirmPasswordField()
        {
            if (TextConfirmPassword.Text != "")
            {
                if (!Validation.password_check(TextConfirmPassword.Text))
                {
                    errorProvider1.SetError(TextConfirmPassword, "at least 8 characters, containing uppercase, lowercase, numeric, and special characters(#,$,%,&)");
                    TextConfirmPassword.BorderColor = Color.Red;
                    TextConfirmPassword.Clear();
                }
                else
                {
                    errorProvider1.SetError(TextConfirmPassword, string.Empty);
                    TextConfirmPassword.BorderColor = Color.Green;
                }
            }
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            EmptyField(TextUsername, TextPassword);
            NameField(TextUsername);
            PasswordField(TextPassword);
            ConfirmPasswordField();
            string userName = TextUsername.Text;
            string password = TextPassword.Text;
            string confirmPassword = TextConfirmPassword.Text;
            if (Validation.userName_check(userName) && Validation.password_check(password) && Validation.password_check(confirmPassword))
            {
                if (password == confirmPassword)
                {
                    if (UserDL.isValidUsername(userName))
                    {
                        if (!UserDL.isPassowrdSame(password))
                        {
                            User info = new User(userName, password);
                            UserDL.addIntoUserList(info);
                            UserDL.saveUserData();
                            MessageBox.Show("Sign Up Successfully", "Sign Up Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearSignUpPanelData();
                        }
                        else
                        {
                            MessageBox.Show("Password Already Exist", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TextPassword.Text = "";
                            TextConfirmPassword.Text = "";
                            TextPassword.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username Already Exist", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextUsername.Text = "";
                        TextUsername.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Password does not match", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextPassword.Text = "";
                    TextConfirmPassword.Text = "";
                    TextPassword.Focus();
                }
            }
        }

        private void TextUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                NameField(TextUsername);
            }
        }

        private void TextUsername_Leave(object sender, EventArgs e)
        {
            NameField(TextUsername);
        }

        private void TextPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                PasswordField(TextPassword);
            }
        }

        private void TextPassword_Leave(object sender, EventArgs e)
        {
            PasswordField(TextPassword);
        }

        private void TextConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                ConfirmPasswordField();
            }
        }

        private void TextConfirmPassword_Leave(object sender, EventArgs e)
        {
            ConfirmPasswordField();
        }

        private void ClearLoginPanelData()
        {
            LoginName.Text = "";
            errorProvider1.SetError(LoginName, string.Empty);
            LoginName.BorderColor = Color.LightGray;
            LoginPassword.Text = "";
            errorProvider1.SetError(LoginPassword, string.Empty);
            LoginPassword.BorderColor = Color.LightGray;
        }

        private void LoginToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (LoginToggleSwitch.Checked)
            {
                LoginPassword.UseSystemPasswordChar = false;
            }
            else
            {
                LoginPassword.UseSystemPasswordChar = true;
            }
        }

        private void LoginName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                NameField(LoginName);
            }
        }

        private void LoginName_Leave(object sender, EventArgs e)
        {
            NameField(LoginName);
        }

        private void LoginPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                PasswordField(LoginPassword);
            }
        }

        private void LoginPassword_Leave(object sender, EventArgs e)
        {
            PasswordField(LoginPassword);
        }

        private void Login_Click(object sender, EventArgs e)
        {
            EmptyField(LoginName, LoginPassword);
            NameField(LoginName);
            PasswordField(LoginPassword);
            if(Validation.userName_check(LoginName.Text) && Validation.password_check(LoginPassword.Text))
            {
                User info = new User(LoginName.Text, LoginPassword.Text);
                string role = UserDL.checkRole(info);
                if (role == "manager")
                {
                    this.Hide();
                    Form adminForm = new AdminForm();
                    adminForm.Show();
                    ClearLoginPanelData();
                }
                else if (role == "customer")
                {
                    MessageBox.Show("WELCOME CUSTOMER");
                    ClearLoginPanelData();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearLoginPanelData();
                    LoginName.Select();
                }
            }
        }
    }
}
