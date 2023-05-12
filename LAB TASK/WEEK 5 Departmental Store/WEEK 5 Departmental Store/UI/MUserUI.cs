using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_5_Departmental_Store.BL;

namespace WEEK_5_Departmental_Store.UI
{
    class MUserUI
    {
        public static int menu()
        {
            int choice;
            Console.WriteLine("1. Sign In");
            Console.WriteLine("2. Sign Up");
            Console.WriteLine("3. Exit");
            Console.Write("Enter Choice: ");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static MUser signIn()
        {
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Your Password: ");
            string password = Console.ReadLine();
            MUser user = new MUser(name, password);
            return user;
        }
        public static MUser signUp()
        {
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Your Password: ");
            string password = Console.ReadLine();
            Console.Write("Enter Your Role: ");
            string role = Console.ReadLine();
            MUser user = new MUser(name, password, role);
            return user;
        }
    }
}
