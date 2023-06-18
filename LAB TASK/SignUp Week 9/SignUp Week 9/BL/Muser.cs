using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUp_Week_9.BL
{
    class Muser
    {
        private string userName;
        private string userPassword;
        private string userRole;
        public Muser(string userName, string userPassword, string userRole)
        {
            this.userName = userName;
            this.userPassword = userPassword;
            this.userRole = userRole;
        }
        public Muser(string userName, string userPassword)
        {
            this.userName = userName;
            this.userPassword = userPassword;
            this.userRole = "NA";
        }
        public string getUserName()
        {
            return userName;
        }
        public string getUserPassword()
        {
            return userPassword;
        }
        public string getUserRole()
        {
            return userRole;
        }
        public bool isAdmin()
        {
            if(userRole == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
