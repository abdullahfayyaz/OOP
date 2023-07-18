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
            ViewBookedRooms();
        }

        private void ViewBookedRooms()
        {
            List<Person> CustomerList = new List<Person>();
            foreach (Person customer in PersonDL.PersonList)
            {
                CustomerList.Add(customer);
            }
            dataGridView1.DataSource = CustomerList;
            dataGridView1.Show();
        }
    }
}
