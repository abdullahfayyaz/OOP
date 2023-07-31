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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            SetControlVisibility(true, false, false, false, false, false);
        }

        private void SetControlVisibility(bool customerMainVisible = false,
                             bool addCustomerVisible = false,
                             bool removeCustomerVisible = false,
                             bool roomsCategoryVisible = false,
                             bool reviewVisible = false,
                             bool ratingVisible = false)
        {
            // Set visibility for each control based on the provided parameters
            customerMainUC1.Visible = customerMainVisible;
            addCustomerUC1.Visible = addCustomerVisible;
            removeCustomerUC1.Visible = removeCustomerVisible;
            roomsCategoryUC1.Visible = roomsCategoryVisible;
            reviewUC1.Visible = reviewVisible;
            ratingUC1.Visible = ratingVisible;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // HOME
        private void Home_Click(object sender, EventArgs e)
        {
            SetControlVisibility(false, false, false, false, false, false);
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.ScaleAndRotate;
            guna2Transition1.ShowSync(customerMainUC1);
        }

        private void Home_MouseHover(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(pictureBox, "Home");
        }

        // ONLINE BOOKING
        private void OnlineBookingButton_Click(object sender, EventArgs e)
        {
            SetControlVisibility(false, false, false, false, false, false);
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.ShowSync(addCustomerUC1);
        }

        // CANCEL BOOKING
        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            SetControlVisibility(false, false, false, false, false, false);
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.ShowSync(removeCustomerUC1);
        }

        // ROOM CATEGORIES
        private void RoomTypeButton_Click(object sender, EventArgs e)
        {
            roomsCategoryUC1.Panel_Room.Visible = false;
            SetControlVisibility(false, false, false, false, false, false);
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.ShowSync(roomsCategoryUC1);
        }

        // GIVE REVIEW
        private void ViewReviewsButton_Click(object sender, EventArgs e)
        {
            SetControlVisibility(false, false, false, false, false, false);
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.ShowSync(reviewUC1);
        }

        // GIVE RATING
        private void ViewRatingButton_Click(object sender, EventArgs e)
        {
            SetControlVisibility(false, false, false, false, false, false);
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.ShowSync(ratingUC1);
        }
    }
}
