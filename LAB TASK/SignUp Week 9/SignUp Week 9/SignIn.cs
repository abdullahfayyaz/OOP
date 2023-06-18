using SignUp_Week_9.BL;
using SignUp_Week_9.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUp_Week_9
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void ClearDataFromForm()
        {
            textBox4.Text = "";
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userName = textBox4.Text;
            string password = textBox1.Text;
            Muser user = new Muser(userName, password);
            Muser validUser = MuserDL.SignIn(user);
            if(validUser != null)
            {
                MessageBox.Show("User is Valid");
            }
            else
            {
                MessageBox.Show("User is Invalid");
            }
            ClearDataFromForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
