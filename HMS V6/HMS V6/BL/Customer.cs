using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_V6.BL
{
    class Customer : Role
    {
        private float bill = 0F;
        public Customer()
        {

        }
        public Customer(string name, string id) : base(name ,id)
        {

        }
        public Customer(string name, string id, string contact, string city, string totalPerson, string roomType, int roomNumber, string no_of_stay, string checkIn) : base(name, id, contact, city, totalPerson, roomType, roomNumber, no_of_stay, checkIn)
        {
          
        }
        public Customer(string name, string id, string contact, string city, string totalPerson, string roomType, int roomNumber, string no_of_stay, string checkIn, float bill) : base(name, id, contact, city, totalPerson, roomType, roomNumber, no_of_stay, checkIn)
        {
            this.bill = bill;
        }
        public void setBill(float bill)
        {
            this.bill = bill;
        }
        public float getBill()
        {
            return bill;
        }
    }
}
