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
    public partial class LastForm : Form
    {
        public LastForm()
        {
            InitializeComponent();
        }

        private void PlayAgainGradientButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm level1 = new GameForm();
            level1.ShowDialog();
            this.Close();
        }

        private void ExitGameGradientButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
