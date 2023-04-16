using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_V2.BL
{
    class customer
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
    }
    class user
    {
        public string userName;
        public string password;
        public string role;
    }
    class roomCategories
    {
        public int type_single = 3000;
        public int type_double = 5000;
        public int type_triple = 8000;
        public int type_twin = 6000;
        public int type_executive = 15000;
        public int type_king = 10000;
    }
    class feedback
    {
        public string reviews;
        public string ratings;
    }
}
