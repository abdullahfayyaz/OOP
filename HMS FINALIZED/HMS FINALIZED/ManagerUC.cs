using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_FINALIZED
{
    public partial class ManagerUC : UserControl
    {
        public ManagerUC()
        {
            InitializeComponent();
            Login_User_name.Text = Form1.loginName;
        }

        private void ManagerUC_Load(object sender, EventArgs e)
        {
            
        }

        private void AccountButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(AccountButton, "Logout");
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            foreach (Form f in Form1.formList)
            {
                f.Hide();
                f.Close();
            }
            Form loginForm = new Form1();
            loginForm.ShowDialog();
        }
    }
}
