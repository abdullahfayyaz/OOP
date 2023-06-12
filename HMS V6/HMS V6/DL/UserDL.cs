using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_V6.BL;
using HMS_V6.UI;

namespace HMS_V6.DL
{
    class UserDL
    {
        static private List<User> userList = new List<User>();
        public static bool isValidUsername(string userName)
        {
            bool isNew = true;
            foreach (User isValid in userList)
            {
                if (userName == isValid.getUserName())
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
        public static void saveUserData()
        {
            string usersPath = "Users.txt";
            StreamWriter file = new StreamWriter(usersPath, false);
            for (int i = 0; i < userList.Count(); i++)
            {
                file.Write(userList[i].getUserName() + "," + userList[i].getPassword() + ",");
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

        // Reading User File for Storing Data in Arrays
        public static void loadUserData()
        {
            string usersPath = "Users.txt";
            if (File.Exists(usersPath))
            {
                StreamReader fileVariable = new StreamReader(usersPath);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string userName = splittedRecord[0];
                    string password = splittedRecord[1];
                    string role = splittedRecord[2];
                    User info = new User(userName, password, role);
                    addIntoUserList(info);
                }
                fileVariable.Close();
            }
            else
            {
                Interface.FileNotExists();
            }
        }

        public static string checkRole(User info)
        {
            string role = "undefined";
            foreach (User check in userList)
            {
                if (check.getUserName() == info.getUserName() && check.getPassword() == info.getPassword())
                {
                    role = check.getRole();
                    break;
                }
            }
            return role;
        }
        // Password
        public static bool isPassowrdSame(string passowrd)
        {
            bool flag = false;
            foreach (User check in userList)
            {
                if (check.getPassword() == passowrd)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public static int foundUser(string password)
        {
            int indexFound = -1;
            for (int i = 0; i < userList.Count(); i++)
            {
                if (password == userList[i].getPassword() && userList[i].getRole() == "customer")
                {
                    indexFound = i;
                    break;
                }
            }
            return indexFound;
        }
        public static void changePassword(string password, int index)
        {
            User info = new User();
            info = userList[index];
            info.setPassword(password);
        }
    }
}
