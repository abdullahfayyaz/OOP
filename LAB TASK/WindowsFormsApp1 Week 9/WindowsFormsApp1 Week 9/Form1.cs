using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1_Week_9.BL;
using WindowsFormsApp1_Week_9.DL;

namespace WindowsFormsApp1_Week_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StudentDL.LoadDummyData();
            dataGridView1.DataSource = StudentDL.getStudent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 welcome = new Form2();
            welcome.Show();
        }
    }
}
