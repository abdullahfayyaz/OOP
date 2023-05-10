using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_V4.BL
{
    class user
    {
        public string userName;
        public string password;
        public string role;
        public user()
        {

        }
        public user(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
        public user(string userName, string password, string role)
        {
            this.userName = userName;
            this.password = password;
            this.role = role;
        }
        public bool isValidUsername(List<user> userData)
        {
            bool isNew = true;
            foreach (user isValid in userData)
            {
                if (userName == isValid.userName)
                {
                    isNew = false;
                    break;
                }
            }
            return isNew;
        }
        public string login(List<user> userData)
        {
            string role = "undefined";
            foreach (user check in userData)
            {
                if (check.userName == userName && check.password == password)
                {
                    role = check.role;
                    break;
                }
            }
            return role;
        }
    }
}
