using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_FINALIZED.BL
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

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}
