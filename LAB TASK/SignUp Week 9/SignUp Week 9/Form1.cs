using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SignUp_Week_9.BL;
using SignUp_Week_9.DL;

namespace SignUp_Week_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string path = "data.txt";
            if(MuserDL.readDataFromFile(path))
            {
                MessageBox.Show("Data Loaded From the File");
            }
            else
            {
                MessageBox.Show("Data not loaded");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(SignIn.Checked)
            {
                Form moreForm = new SignIn();
                moreForm.Show();
                SignIn.Checked = false;
            }
            else if(SignUp.Checked)
            {
                Form moreForm = new SignUp();
                moreForm.Show();
                SignUp.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
