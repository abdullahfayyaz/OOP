using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_5_Departmental_Store.BL;
using WEEK_5_Departmental_Store.UI;

namespace WEEK_5_Departmental_Store.DL
{
    class MUserCRUD
    {
        static List<MUser> userList = new List<MUser>();
        public static void addInToList(MUser user)
        {
            userList.Add(user);
        }
        public static string isValid(MUser user)
        {
            string role = "undefined";
            for (int x = 0; x < userList.Count(); x++)
            {
                if (user.name == userList[x].name && user.password == userList[x].password)
                {
                    role = userList[x].role;
                }
            }
            return role;
        }
    }
}
