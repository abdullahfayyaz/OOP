using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PD_WEEK_9_Problem_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Sting");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}
