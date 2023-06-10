using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_V6.BL
{
    class Role
    {
        protected string name;
        protected string id;
        protected string contact;
        protected string city;
        protected string totalPerson;
        protected string roomType;
        protected int roomNumber;
        protected string no_of_stay;
        protected string checkIn;
        public Role()
        {

        }
        public Role(string name, string id)
        {
            this.name = name;
            this.id = id;
        }
        public Role(string name, string id, string contact, string city, string totalPerson, string roomType, int roomNumber, string no_of_stay, string checkIn)
        {
            this.name = name;
            this.id = id;
            this.contact = contact;
            this.city = city;
            this.totalPerson = totalPerson;
            this.roomType = roomType;
            this.roomNumber = roomNumber;
            this.no_of_stay = no_of_stay;
            this.checkIn = checkIn;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setID(string id)
        {
            this.id = id;
        }
        public string getID()
        {
            return id;
        }
        public void setContact(string contact)
        {
            this.contact = contact;
        }
        public string getContact()
        {
            return contact;
        }
        public void setCity(string city)
        {
            this.city = city;
        }
        public string getCity()
        {
            return city;
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
    }
}
