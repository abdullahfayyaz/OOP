using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_V6.UI;

namespace HMS_V6.BL
{
    class Customer : Person
    {
        private string totalPerson;
        private string roomType;
        private int roomNumber;
        private string no_of_stay;
        protected string checkIn;
        private float bill = 0F;
        public Customer()
        {

        }
        public Customer(string name, string id) : base(name, id)
        {
           
        }
        public Customer(string name, string id, string contact, string city, string totalPerson, string roomType, int roomNumber, string no_of_stay, string checkIn) : base(name, id, contact, city)
        {
            this.totalPerson = totalPerson;
            this.roomType = roomType;
            this.roomNumber = roomNumber;
            this.no_of_stay = no_of_stay;
            this.checkIn = checkIn;
        }
        public Customer(string name, string id, string contact, string city, string totalPerson, string roomType, int roomNumber, string no_of_stay, string checkIn, float bill) : this(name, id, contact, city, totalPerson, roomType, roomNumber, no_of_stay, checkIn)
        {
            this.bill = bill;
        }
        public void setTotalPerson(string totalPerson)
        {
            this.totalPerson = totalPerson;
        }
        public string getTotalPerson()
        {
            return totalPerson;
        }
        public void setRoomType(string roomType)
        {
            this.roomType = roomType;
        }
        public string getRoomType()
        {
            return roomType;
        }
        public void setRoomNumber(int roomNumber)
        {
            this.roomNumber = roomNumber;
        }
        public int getRoomNumber()
        {
            return roomNumber;
        }
        public void setNoOfStay(string no_of_stay)
        {
            this.no_of_stay = no_of_stay;
        }
        public string getNoOfStay()
        {
            return no_of_stay;
        }
        public void setCheckIn(string checkIn)
        {
            this.checkIn = checkIn;
        }
        public string getCheckIn()
        {
            return checkIn;
        }
        public void setBill(float bill)
        {
            this.bill = bill;
        }
        public float getBill()
        {
            return bill;
        }
        public static string addRating()
        {
            string choice = Interface.choice();
            string rating = "";
            if (choice == "1")
            {
                rating = "One Star";
            }
            else if (choice == "2")
            {
                rating = "Two Star";
            }
            else if (choice == "3")
            {
                rating = "Three Star";
            }
            else if (choice == "4")
            {
                rating = "Four Star";
            }
            else if (choice == "5")
            {
                rating = "Five Star";
            }
            else
            {
                Interface.wrongInput();
                Interface.clear();
            }
            return rating;
        }
    }
}
