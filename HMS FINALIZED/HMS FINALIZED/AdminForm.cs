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
            SetControlVisibility(true, false, false, false, false, false, false, false, false, false, false, false, false, false);
        }

        private void SetControlVisibility(bool managerVisible = false,
                                     bool addCustomerVisible = false,
                                     bool updateCustomerVisible = false,
                                     bool searchCustomerVisible = false,
                                     bool removeCustomerVisible = false,
                                     bool bookedRoomsVisible = false,
                                     bool availableRoomsVisible = false,
                                     bool roomsCategoryVisible = false,
                                     bool checkoutVisible = false,
                                     bool viewReviewVisible = false,
                                     bool viewRatingVisible = false,
                                     bool addStaffVisible = false,
                                     bool removeStaffVisible = false,
                                     bool viewStaffVisible = false)
        {
            // Set visibility for each control based on the provided parameters&
            managerUC1.Visible = managerVisible;
            addCustomerUC1.Visible = addCustomerVisible;
            updateCustomerUC1.Visible = updateCustomerVisible;
            searchCustomer1.Visible = searchCustomerVisible;
            removeCustomerUC1.Visible = removeCustomerVisible;
            bookedRoomsUC1.Visible = bookedRoomsVisible;
            availableRoomsUC1.Visible = availableRoomsVisible;
            roomsCategoryUC1.Visible = roomsCategoryVisible;
            checkoutUC1.Visible = checkoutVisible;
            viewReviewUC1.Visible = viewReviewVisible;
            viewRatingUC1.Visible = viewRatingVisible;
            addStaffUC1.Visible = addStaffVisible;
            removeStaffUC1.Visible = removeStaffVisible;
            viewStaffUC1.Visible = viewStaffVisible;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // HOME
        private void Home_Click(object sender, EventArgs e)
        {
            SetControlVisibility(false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.ScaleAndRotate;
            guna2Transition1.ShowSync(managerUC1);

        }
        private void Home_MouseHover(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(pictureBox, "Home");
        }

        // ADD CUSTOMER
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            SetControlVisibility(false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.ShowSync(addCustomerUC1);
        }

        // UPDATE CUSTOMER
        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
            updateCustomerUC1.Panel_Update.Visible = false;
            SetControlVisibility(false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.ShowSync(updateCustomerUC1);
        }

        // SEARCH CUSTOMER
        private void SearchCustomerButton_Click(object sender, EventArgs e)
        {
            searchCustomer1.Panel_SearchMini.Visible = false;
            SetControlVisibility(false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.ShowSync(searchCustomer1);
        }

        // REMOVE CUSTOMER
        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            SetControlVisibility(false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.ShowSync(removeCustomerUC1);
        }

        // VIEW BOOKED ROOMS
        private void BookedRoomsButton_Click(object sender, EventArgs e)
        {
            SetControlVisibility(false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            ShowBookedRooms();
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.ShowSync(bookedRoomsUC1);
        }
        private void ShowBookedRooms()
        {
            List<Person> customerList = new List<Person>();
            foreach (Person info in PersonDL.PersonList)
            {
                if (info.Role == "Customer")
                {
                    customerList.Add(info);
                }
            }
            DataTable bookedRoomsDataTable = ToDataTable(customerList, new[] { "Role", "Bill", "Review", "Rating", "ReviewCheck", "RatingCheck", "Designation" });
            bookedRoomsUC1.ShowBookedRoomDataGridView(bookedRoomsDataTable);
            bookedRoomsUC1.setColumnHeaders();
        }

        // AVAILABLE ROOMS
        private void AvailableRoomsButton_Click(object sender, EventArgs e)
        {
            SetControlVisibility(false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.ShowSync(availableRoomsUC1);
        }

        // ROOM CATEGORIES
        private void RoomTypeButton_Click(object sender, EventArgs e)
        {
            roomsCategoryUC1.Panel_Room.Visible = false;
            SetControlVisibility(false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.ShowSync(roomsCategoryUC1);
        }

        // CHECKOUT
        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            checkoutUC1.Panel_Checkout.Visible = false;
            SetControlVisibility(false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.ShowSync(checkoutUC1);
        }

        // VIEW REVIEWS
        private void ViewReviewsButton_Click(object sender, EventArgs e)
        {
            SetControlVisibility(false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            DisplayReviews();
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.ShowSync(viewReviewUC1);
        }
        private void DisplayReviews()
        {
            List<Person> reviewList = new List<Person>();
            foreach (Person info in PersonDL.PersonList)
            {
                if (info.Role == "Customer" && info.ReviewCheck == true)
                {
                    reviewList.Add(info);
                }
            }
            DataTable reviewDataTable = ToDataTable(reviewList, new[] { "Role", "Id", "Contact", "City", "RoomType", "RoomNumber", "TotalPerson", "CheckInDate", "CheckOutDate", "Bill", "Rating", "ReviewCheck", "RatingCheck", "Designation" });
            viewReviewUC1.ShowReviewDataGridView(reviewDataTable);
        }


        // VIEW RATING
        private void ViewRatingButton_Click(object sender, EventArgs e)
        {
            SetControlVisibility(false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            DisplayRatings();
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.ShowSync(viewRatingUC1);
        }
        private void DisplayRatings()
        {
            List<Person> ratingList = new List<Person>();
            foreach (Person info in PersonDL.PersonList)
            {
                if (info.Role == "Customer" && info.RatingCheck == true)
                {
                    ratingList.Add(info);
                }
            }
            DataTable ratingDataTable = ToDataTable(ratingList, new[] { "Role", "Id", "Contact", "City", "RoomType", "RoomNumber", "TotalPerson", "CheckInDate", "CheckOutDate", "Bill", "Review", "ReviewCheck", "RatingCheck", "Designation" });
            viewRatingUC1.ShowRatingDataGridView(ratingDataTable);
        }

        // ADD STAFF MEMBER
        private void AddStaffButton_Click(object sender, EventArgs e)
        {
            SetControlVisibility(false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.ShowSync(addStaffUC1);
        }

        // REMOVE STAFF MEMBER
        private void RemoveStaffButton_Click(object sender, EventArgs e)
        {
            SetControlVisibility(false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.ShowSync(removeStaffUC1);
        }

        // VIEW STAFF MEMBERS
        private void ViewStaffButton_Click(object sender, EventArgs e)
        {
            SetControlVisibility(false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            DisplayStaffMembers();
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.ShowSync(viewStaffUC1);
        }
        private void DisplayStaffMembers()
        {
            List<Person> staffList = new List<Person>();
            foreach (Person info in PersonDL.PersonList)
            {
                if (info.Role == "Staff")
                {
                    staffList.Add(info);
                }
            }
            DataTable staffDataTable = ToDataTable(staffList, new[] { "Role", "RoomType", "RoomNumber", "TotalPerson", "CheckInDate", "CheckOutDate", "Bill", "Review", "Rating", "ReviewCheck", "RatingCheck" });
            viewStaffUC1.ShowStaffDataGridView(staffDataTable);
            viewStaffUC1.setColumnHeaders();
        }

        // Helper method to convert List<T> to DataTable, excluding specified columns
        private DataTable ToDataTable<T>(List<T> items, string[] excludeColumns)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            // Get all the properties
            System.Reflection.PropertyInfo[] props = typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

            foreach (System.Reflection.PropertyInfo prop in props)
            {
                // Skip columns to be excluded
                if (!excludeColumns.Contains(prop.Name))
                {
                    // Setting column names as Property names
                    dataTable.Columns.Add(prop.Name);
                }
            }

            foreach (T item in items)
            {
                var values = new object[dataTable.Columns.Count];
                int columnIndex = 0;
                for (int i = 0; i < props.Length; i++)
                {
                    // Skip columns to be excluded
                    if (!excludeColumns.Contains(props[i].Name))
                    {
                        // Inserting property values to datatable rows
                        values[columnIndex] = props[i].GetValue(item, null);
                        columnIndex++;
                    }
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
    }
}
