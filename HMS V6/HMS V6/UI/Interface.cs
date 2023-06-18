using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_V6.UI
{
    class Interface
    {
        public static void printHeader()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" __   __  _______  _______  _______  ___        __   __  _______  __    _  _______  _______  _______  __   __  _______  __    _  _______    _______  __   __  _______  _______  _______  __   __   ");
            Console.WriteLine("|  | |  ||       ||       ||       ||   |      |  |_|  ||   _   ||  |  | ||   _   ||       ||       ||  |_|  ||       ||  |  | ||       |  |       ||  | |  ||       ||       ||       ||  |_|  |  ");
            Console.WriteLine("|  |_|  ||   _   ||_     _||    ___||   |      |       ||  |_|  ||   |_| ||  |_|  ||    ___||    ___||       ||    ___||   |_| ||_     _|  |  _____||  |_|  ||  _____||_     _||    ___||       |  ");
            Console.WriteLine("|       ||  | |  |  |   |  |   |___ |   |      |       ||       ||       ||       ||   | __ |   |___ |       ||   |___ |       |  |   |    | |_____ |       || |_____   |   |  |   |___ |       |  ");
            Console.WriteLine("|       ||  |_|  |  |   |  |    ___||   |___   |       ||       ||  _    ||       ||   ||  ||    ___||       ||    ___||  _    |  |   |    |_____  ||_     _||_____  |  |   |  |    ___||       |  ");
            Console.WriteLine("|   _   ||       |  |   |  |   |___ |       |  | ||_|| ||   _   || | |   ||   _   ||   |_| ||   |___ | ||_|| ||   |___ | | |   |  |   |     _____| |  |   |   _____| |  |   |  |   |___ | ||_|| |  ");
            Console.WriteLine("|__| |__||_______|  |___|  |_______||_______|  |_|   |_||__| |__||_|  |__||__| |__||_______||_______||_|   |_||_______||_|  |__|  |___|    |_______|  |___|  |_______|  |___|  |_______||_|   |_|  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
        public static string choice()
        {
            string option;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter Your Choice: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            option = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            return option;
        }
        public static void clear()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Press any key to continue: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
        public static void subMenu(string subMenu)
        {
            string message = "Main Menu > " + subMenu;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void mainSubMenu(string mainSubMenu)
        {
            string message = "Login and Sign-Up Menu > " + mainSubMenu;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void wrongInput()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Wrong input\nTry again");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void FileNotExists()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("File Not Exists");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void NotValidName()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Enter a Valid Name");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void InvalidCNICFormat()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Please Enter Valid Format (#####-#######-#)");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void NotValidContact()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Enter a Valid Number");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
