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
    public partial class ViewStaffUC : UserControl
    {
        public ViewStaffUC()
        {
            InitializeComponent();
        }

        public void ShowStaffDataGridView(DataTable staffDataTable)
        {
            StaffDataGridView.DataSource = staffDataTable;
            StaffDataGridView.Refresh();
        }
        public void setColumnHeaders()
        {
            StaffDataGridView.Columns["Id"].HeaderText = "CNIC Number";
            StaffDataGridView.Columns["Contact"].HeaderText = "Contact Number";
            StaffDataGridView.Columns["City"].HeaderText = "City of Residence";
            StaffDataGridView.Columns["Designation"].HeaderText = "Job Designation";
        }
    }
}
