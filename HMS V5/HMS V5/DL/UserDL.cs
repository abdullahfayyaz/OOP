using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HMS_V5.BL;

namespace HMS_V5.DL
{
    class UserDL
    {
        static List<User> userList = new List<User>();
        public static bool isValidUsername(string userName)
        {
            bool isNew = true;
            foreach (User isValid in userList)
            {
                if (userName == isValid.userName)
                {
                    isNew = false;
                    break;
                }
            }
            return isNew;
        }
        public static void addIntoUserList(User info)
        {
            userList.Add(info);
        }

        // Store User Data in File
        public static void saveUserData(string usersPath)
        {
            StreamWriter file = new StreamWriter(usersPath, false);
            for (int i = 0; i < userList.Count(); i++)
            {
                file.Write(userList[i].userName + "," + userList[i].password + ",");
                if (i == 0)
                {
                    file.WriteLine("manager");
                }
                else
                {
                    file.WriteLine("customer");
                }
            }
            file.Flush();
            file.Close();
        }
        public static string checkRole(User info)
        {
            string role = "undefined";
            foreach (User check in userList)
            {
                if (check.userName == info.userName && check.password == info.password)
                {
                    role = check.role;
                    break;
                }
            }
            return role;
        }
    }
}
