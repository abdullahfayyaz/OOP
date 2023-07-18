using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using HMS_FINALIZED.BL;
using HMS_FINALIZED.DL;

namespace HMS_FINALIZED
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            managerUC1.Visible = true;
            addCustomerUC1.Visible = false;
            searchCustomer1.Visible = false;
            removeCustomerUC1.Visible = false;
            bookedRoomsUC1.Visible = false;
            availableRoomsUC1.Visible = false;
            roomsCategoryUC1.Visible = false;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // HOME
        private void Home_Click(object sender, EventArgs e)
        {
            addCustomerUC1.Visible = false;
            searchCustomer1.Visible = false;
            removeCustomerUC1.Visible = false;
            bookedRoomsUC1.Visible = false;
            availableRoomsUC1.Visible = false;
            roomsCategoryUC1.Visible = false;
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.ScaleAndRotate;
            guna2Transition1.ShowSync(managerUC1);

        }
        private void Home_MouseHover(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(pictureBox, "Home");
            /*
            DateTime checkin;
            DateTime checkout;
            checkin = Check_inDateTimePicker.Value;
            checkout = CheckoutDateTimePicker.Value;
            int stay;
            stay = (int)(checkout - checkin).TotalDays;
            label11.Text = Convert.ToString(stay);
            */
        }

        // ADD CUSTOMER
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            managerUC1.Visible = false;
            searchCustomer1.Visible = false;
            removeCustomerUC1.Visible = false;
            bookedRoomsUC1.Visible = false;
            availableRoomsUC1.Visible = false;
            roomsCategoryUC1.Visible = false;
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.ShowSync(addCustomerUC1);
        }

        // SEARCH CUSTOMER
        private void SearchCustomerButton_Click(object sender, EventArgs e)
        {
            managerUC1.Visible = false;
            addCustomerUC1.Visible = false;
            searchCustomer1.Panel_SearchMini.Visible = false;
            removeCustomerUC1.Visible = false;
            bookedRoomsUC1.Visible = false;
            availableRoomsUC1.Visible = false;
            roomsCategoryUC1.Visible = false;
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.ShowSync(searchCustomer1);
        }

        // REMOVE CUSTOMER
        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            managerUC1.Visible = false;
            addCustomerUC1.Visible = false;
            searchCustomer1.Visible = false;
            bookedRoomsUC1.Visible = false;
            availableRoomsUC1.Visible = false;
            roomsCategoryUC1.Visible = false;
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.ShowSync(removeCustomerUC1);
        }

        // VIEW BOOKED ROOMS
        private void BookedRoomsButton_Click(object sender, EventArgs e)
        {
            managerUC1.Visible = false;
            addCustomerUC1.Visible = false;
            searchCustomer1.Visible = false;
            removeCustomerUC1.Visible = false;
            availableRoomsUC1.Visible = false;
            roomsCategoryUC1.Visible = false;
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.ShowSync(bookedRoomsUC1);
        }

        // AVAILABLE ROOMS
        private void AvailableRoomsButton_Click(object sender, EventArgs e)
        {
            managerUC1.Visible = false;
            addCustomerUC1.Visible = false;
            searchCustomer1.Visible = false;
            removeCustomerUC1.Visible = false;
            bookedRoomsUC1.Visible = false;
            roomsCategoryUC1.Visible = false;
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.ShowSync(availableRoomsUC1);
        }

        // ROOM CATEGORIES
        private void RoomTypeButton_Click(object sender, EventArgs e)
        {
            managerUC1.Visible = false;
            addCustomerUC1.Visible = false;
            searchCustomer1.Visible = false;
            removeCustomerUC1.Visible = false;
            bookedRoomsUC1.Visible = false;
            availableRoomsUC1.Visible = false;
            roomsCategoryUC1.Panel_Room.Visible = false;
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.ShowSync(roomsCategoryUC1);
        }
    }
}
