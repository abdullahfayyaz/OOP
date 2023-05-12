using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_V5.UI
{
    class Interface
    {
        public static void printHeader()
        {
            Console.Clear();
            Console.WriteLine(" __   __  _______  _______  _______  ___        __   __  _______  __    _  _______  _______  _______  __   __  _______  __    _  _______    _______  __   __  _______  _______  _______  __   __   ");
            Console.WriteLine("|  | |  ||       ||       ||       ||   |      |  |_|  ||   _   ||  |  | ||   _   ||       ||       ||  |_|  ||       ||  |  | ||       |  |       ||  | |  ||       ||       ||       ||  |_|  |  ");
            Console.WriteLine("|  |_|  ||   _   ||_     _||    ___||   |      |       ||  |_|  ||   |_| ||  |_|  ||    ___||    ___||       ||    ___||   |_| ||_     _|  |  _____||  |_|  ||  _____||_     _||    ___||       |  ");
            Console.WriteLine("|       ||  | |  |  |   |  |   |___ |   |      |       ||       ||       ||       ||   | __ |   |___ |       ||   |___ |       |  |   |    | |_____ |       || |_____   |   |  |   |___ |       |  ");
            Console.WriteLine("|       ||  |_|  |  |   |  |    ___||   |___   |       ||       ||  _    ||       ||   ||  ||    ___||       ||    ___||  _    |  |   |    |_____  ||_     _||_____  |  |   |  |    ___||       |  ");
            Console.WriteLine("|   _   ||       |  |   |  |   |___ |       |  | ||_|| ||   _   || | |   ||   _   ||   |_| ||   |___ | ||_|| ||   |___ | | |   |  |   |     _____| |  |   |   _____| |  |   |  |   |___ | ||_|| |  ");
            Console.WriteLine("|__| |__||_______|  |___|  |_______||_______|  |_|   |_||__| |__||_|  |__||__| |__||_______||_______||_|   |_||_______||_|  |__|  |___|    |_______|  |___|  |_______|  |___|  |_______||_|   |_|  ");
            Console.WriteLine();
        }
        public static string choice()
        {
            string option;
            Console.Write("Enter Your Choice: ");
            option = Console.ReadLine();
            return option;
        }
        public static void clear()
        {
            Console.Write("Press any key to continue: ");
            Console.ReadKey();
        }
        public static void subMenu(string subMenu)
        {
            string message = "Main Menu > " + subMenu;
            Console.WriteLine(message);
            Console.WriteLine("--------------------------------------------");
        }
        public static void mainSubMenu(string mainSubMenu)
        {
            string message = "Login and Sign-Up Menu > " + mainSubMenu;
            Console.WriteLine(message);
            Console.WriteLine("--------------------------------------------");
        }
        public static void wrongInput()
        {
            Console.WriteLine("Wrong input\nTry again");
        }
    }
}
