using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_FINAL.BL
{
    class StaffMember : Person
    {
        private string duty;
        public StaffMember()
        {

        }
        public StaffMember(string name, string id) : base(name, id)
        {

        }
        public StaffMember(string name, string id, string contact, string city, string duty) : base(name, id, contact, city)
        {
            base.role = "Staff";
            this.duty = duty;
        }
        public override void setDuty(string duty)
        {
            this.duty = duty;
        }
        public override string getDuty()
        {
            return duty;
        }
        public static string assignRole(string option)
        {
            string role = "";
            if (option == "1")
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
