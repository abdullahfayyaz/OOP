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
        public static void loginSignup()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Login and Sign-Up Menu >");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Select one of the following options number...");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1- Login");
            Console.WriteLine("2- Sign-Up");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("3- Exit");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Invalid()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Invalid Credentials");
            Console.ForegroundColor = ConsoleColor.White;        }
        public static void InvalidPassword()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Password must be 8 characters long (Mix of numbers,letters and special characters(#,$,%,&)");
            Console.ForegroundColor = ConsoleColor.White;        }
        public static void InvalidUsername()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Username must be 7 characters long (Only use Alphabets and Underscore)");
            Console.ForegroundColor = ConsoleColor.White;        }
        public static void invalidUser()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Invalid");
            Console.ForegroundColor = ConsoleColor.White;        }
        public static void PasswordExists()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Password Already Exists");
            Console.ForegroundColor = ConsoleColor.White;        }
        public static void signUp()
        {
        here:
            Interface.printHeader();
            Interface.mainSubMenu("SignUp");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Enter User Name: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string userName = Console.ReadLine();
            bool valid_name = Validation.userName_check(userName);
            if (valid_name == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Enter Password: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string password = Console.ReadLine();
                bool valid = Validation.password_check(password);
                if (valid == true)
                {
                    bool passwordCheck = UserDL.isPassowrdSame(password);
                    bool signUpCheck = UserDL.isValidUsername(userName);
                    if (signUpCheck == true && passwordCheck == false)
                    {
                        User info = new User(userName, password);
                        UserDL.addIntoUserList(info);
                        UserDL.saveUserData();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Sign Up Successfully");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (signUpCheck == false || passwordCheck == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Already Exist");
                        Console.ForegroundColor = ConsoleColor.White;
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
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Enter User Name: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string userName = Console.ReadLine();
            bool valid_name = Validation.userName_check(userName);
            if (valid_name == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Enter Password: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string password = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
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
