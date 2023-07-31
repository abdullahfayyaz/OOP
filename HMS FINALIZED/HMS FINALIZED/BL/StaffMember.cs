using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_FINALIZED.BL
{
    class StaffMember : Person
    {
        private string designation;
        public override string Designation { get => designation; set => designation = value; }
        public StaffMember()
        {

        }
        public StaffMember(string name, string id) : base(name, id)
        {

        }
        public StaffMember(string name, string id, string contact, string city, string designation) : base(name, id, contact, city)
        {
            base.role = "Staff";
            this.designation = designation;
        }
    }
}
