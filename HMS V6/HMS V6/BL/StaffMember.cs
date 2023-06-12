using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_V6.BL
{
    class StaffMember : Person
    {
        private string role;
        public StaffMember()
        {

        }
        public StaffMember(string name, string id) : base(name, id)
        {

        }
        public StaffMember(string name, string id, string contact, string city, string role) : base(name, id, contact, city)
        {
            this.role = role;
        }
        public void setRole(string role)
        {
            this.role = role;
        }
        public string getRole()
        {
            return role;
        }
        public static string assignRole(string option)
        {
            string role = "";
            if(option == "1")
            {
                role = "Hotel receptionist";
            }
            else if (option == "2")
            {
                role = "Operations manager";
            }
            else if (option == "3")
            {
                role = "Security manager";
            }
            else if (option == "4")
            {
                role = "Hotel porter";
            }
            else if (option == "5")
            {
                role = "Room attendant";
            }
            return role;
        }
    }
}
