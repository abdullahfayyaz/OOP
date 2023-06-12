using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_V6.BL
{
    class User
    {
        private string userName;
        private string password;
        private string role;
        public User()
        {

        }
        public User(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
        public User(string userName, string password, string role)
        {
            this.userName = userName;
            this.password = password;
            this.role = role;
        }
        public void setUserName(string userName)
        {
            this.userName = userName;
        }
        public string getUserName()
        {
            return userName;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public string getPassword()
        {
            return password;
        }
        public void setRole(string role)
        {
            this.role = role;
        }
        public string getRole()
        {
            return role;
        } 
    }
}