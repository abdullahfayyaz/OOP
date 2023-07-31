using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELEMENTAL_ARENA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void NewGameGradientButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm level1 = new GameForm();
            level1.ShowDialog();
            this.Close();
        }
    }
}
