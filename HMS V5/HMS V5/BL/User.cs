using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_V5.BL
{
    class User
    {
        public string userName;
        public string password;
        public string role;
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

        // Separating credentials for storing in arrays individually
        public static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
    }
}
