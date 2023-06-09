using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_V6.BL;
using HMS_V6.DL;

namespace HMS_V6.UI
{
    class UserUI
    {
        private static string usersPath = "C:\\Users\\HP\\Documents\\STUDY\\2nd Semester\\OOP TASK\\HMS V6\\Users.txt";
        public static void loginSignup()
        {
            Console.WriteLine("Login and Sign-Up Menu >");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Select one of the following options number...");
            Console.WriteLine("1- Login");
            Console.WriteLine("2- Sign-Up");
            Console.WriteLine("3- Exit");
        }
        public static void Invalid()
        {
            Console.WriteLine("Invalid Credentials");
        }
        public static void InvalidPassword()
        {
            Console.WriteLine("Password must be 8 characters long (Mix of numbers,letters and special characters(#,$,%,&)");
        }
        public static void InvalidUsername()
        {
            Console.WriteLine("Username must be 7 characters long (Only use Alphabets and Underscore)");
        }
        public static void signUp()
        {
        here:
            Interface.printHeader();
            Interface.mainSubMenu("SignUp");
            Console.Write("Enter User Name: ");
            string userName = Console.ReadLine();
            bool valid_name = Validation.userName_check(userName);
            if (valid_name == true)
            {
                Console.Write("Enter Password: ");
                string password = Console.ReadLine();
                bool valid = Validation.password_check(password);
                if (valid == true)
                {
                    bool signUpCheck = UserDL.isValidUsername(userName);
                    if (signUpCheck == true)
                    {
                        User info = new User(userName, password);
                        UserDL.addIntoUserList(info);
                        UserDL.saveUserData(usersPath);
                        Console.WriteLine("Sign Up Successfully");
                    }
                    else if (signUpCheck == false)
                    {
                        Console.WriteLine("Username Already Exist");
                        Interface.clear();
                        goto here;
                    }
                }
                else if (valid == false)
                {
                    InvalidPassword();
                    Interface.clear();
                    goto here;
                }
            }
            else if (valid_name == false)
            {
                InvalidUsername();
                Interface.clear();
                goto here;
            }
            Interface.clear();
        }
        public static string login()
        {
            string role = "";
        here:
            Interface.printHeader();
            Interface.mainSubMenu("Login");
            Console.Write("Enter User Name: ");
            string userName = Console.ReadLine();
            bool valid_name = Validation.userName_check(userName);
            if (valid_name == true)
            {
                Console.Write("Enter Password: ");
                string password = Console.ReadLine();
                bool valid = Validation.password_check(password);
                if (valid == true)
                {
                    User info = new User(userName, password);
                    role = UserDL.checkRole(info);
                }
                else if (valid == false)
                {
                    InvalidPassword();
                    Interface.clear();
                    goto here;
                }
            }
            else if (valid_name == false)
            {
                InvalidUsername();
                Interface.clear();
                goto here;
            }
            return role;
        }
    }
}
