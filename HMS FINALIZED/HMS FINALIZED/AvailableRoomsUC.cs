using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS_FINALIZED.BL;
using HMS_FINALIZED.DL;

namespace HMS_FINALIZED
{
    public partial class AvailableRoomsUC : UserControl
    {
        public AvailableRoomsUC()
        {
            InitializeComponent();
        }

        private void AvailableRoomsUC_Load(object sender, EventArgs e)
        {
            Room info = new Room();
            int availableRooms = PersonDL.availableRooms(info.TotalRoom);
            TotalRoomsLabel.Text = Convert.ToString(info.TotalRoom);
            AvailableRoomsLabel.Text = Convert.ToString(availableRooms);
        }
    }
}
