using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_FINALIZED.BL
{
    class Customer : Person
    {
        private string totalPerson;
        private string roomType;
        private int roomNumber;
        private string checkInDate;
        private string checkOutDate;
        private float bill = 0F;
        private string review;
        private string rating;
        private bool reviewCheck;
        private bool ratingCheck;

        public override string TotalPerson { get => totalPerson; set => totalPerson = value; }
        public override string RoomType { get => roomType; set => roomType = value; }
        public override int RoomNumber { get => roomNumber; set => roomNumber = value; }
        public override string CheckInDate { get => checkInDate; set => checkInDate = value; }
        public override string CheckOutDate { get => checkOutDate; set => checkOutDate = value; }
        public override float Bill { get => bill; set => bill = value; }
        public override string Review { get => review; set => review = value; }
        public override string Rating { get => rating; set => rating = value; }
        public override bool ReviewCheck { get => reviewCheck; set => reviewCheck = value; }
        public override bool RatingCheck { get => ratingCheck; set => ratingCheck = value; }

        internal Room Room
        {
            get => default;
            set
            {
            }
        }

        public Customer()
        {

        }
        public Customer(string name, string id) : base(name, id)
        {

        }
        public Customer(string name, string id, string contact, string city, string totalPerson, string roomType, int roomNumber, string checkInDate, string checkOutDate) : base(name, id, contact, city)
        {
            base.role = "Customer";
            this.totalPerson = totalPerson;
            this.roomType = roomType;
            this.roomNumber = roomNumber;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            this.bill = 0;
            this.review = null;
            this.rating = null;
            this.reviewCheck = false;
            this.ratingCheck = false;
        }
    }
}
