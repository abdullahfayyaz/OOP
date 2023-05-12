using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_V5.BL
{
    class Customer
    {
        public string name;
        public string id;
        public string contact;
        public string city;
        public string totalPerson;
        public string roomType;
        public int roomNumber;
        public string no_of_stay;
        public string checkIn;
        public Customer()
        {

        }
        public Customer(string name, string id)
        {
            this.name = name;
            this.id = id;
        }
        public Customer(string name, string id, string contact, string city, string totalPerson, string roomType, int roomNumber, string no_of_stay, string checkIn)
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
    }
}
