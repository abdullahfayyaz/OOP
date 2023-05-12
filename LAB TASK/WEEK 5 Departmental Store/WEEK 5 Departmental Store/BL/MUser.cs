using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_5_Departmental_Store.BL
{
    class MUser
    {
        public string name;
        public string password;
        public string role;

        public MUser()
        {

        }
        public MUser(string name, string password, string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }
        public MUser(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
    }
}
