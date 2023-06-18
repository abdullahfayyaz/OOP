using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignUp_Week_9.BL;

namespace SignUp_Week_9.DL
{
    class MuserDL
    {
        private static List<Muser> usersList = new List<Muser>();
        public static void addUserIntoList(Muser user)
        {
            usersList.Add(user);
        }
        public static Muser SignIn(Muser user)
        {
            foreach(Muser storedUser in usersList)
            {
                if(storedUser.getUserName() == user.getUserName() && storedUser.getUserPassword() == user.getUserPassword())
                {
                    return storedUser;
                }
            }
            return null;
        }
        public static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for(int x = 0; x < record.Length; x++)
            {
                if(record[x] == ',')
                {
                    comma++;
                }
                else if(comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        public static bool readDataFromFile(string path)
        {
            if(File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while((record = fileVariable.ReadLine()) != null)
                {
                    string userName = parseData(record, 1);
                    string userPassword = parseData(record, 2);
                    string userRole = parseData(record, 3);
                    Muser user = new Muser(userName, userPassword, userRole);
                    addUserIntoList(user);
                }
                fileVariable.Close();
                return true;
            }
            else
                return false;
        }
        public static void storeUserIntoFile(Muser user, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.getUserName() + "," + user.getUserPassword() + "," + user.getUserRole());
            file.Flush();
            file.Close();
        }
    }
}
