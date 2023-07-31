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
    public partial class BookedRoomsUC : UserControl
    {
        public BookedRoomsUC()
        {
            InitializeComponent();
        }

        public void ShowBookedRoomDataGridView(DataTable bookedRoomsDataTable)
        {
            BookedRoomsDataGridView.DataSource = bookedRoomsDataTable;
            BookedRoomsDataGridView.Refresh();
        }
        public void setColumnHeaders()
        {
            BookedRoomsDataGridView.Columns["Id"].HeaderText = "CNIC Number";
            BookedRoomsDataGridView.Columns["Contact"].HeaderText = "Contact Number";
            BookedRoomsDataGridView.Columns["City"].HeaderText = "City of Residence";
            BookedRoomsDataGridView.Columns["TotalPerson"].HeaderText = "Total Person";
            BookedRoomsDataGridView.Columns["RoomType"].HeaderText = "Room Type";
            BookedRoomsDataGridView.Columns["RoomNumber"].HeaderText = "Room Number";
            BookedRoomsDataGridView.Columns["CheckInDate"].HeaderText = "Check-in Date";
            BookedRoomsDataGridView.Columns["CheckOutDate"].HeaderText = "Check-out Date";
        }
    }
}
