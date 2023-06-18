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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private void ClearDataFromForm()
        {
            textBox4.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userName = textBox4.Text;
            string password = textBox1.Text;
            string role = textBox3.Text;
            string path = "data.txt";
            Muser user = new Muser(userName, password, role);
            MuserDL.addUserIntoList(user);
            MuserDL.storeUserIntoFile(user, path);
            MessageBox.Show("User Added Successfully");
            ClearDataFromForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
