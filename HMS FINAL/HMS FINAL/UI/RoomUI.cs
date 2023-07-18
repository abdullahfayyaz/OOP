using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_FINAL.BL;

namespace HMS_FINAL.UI
{
    class RoomUI
    {
        public static void roomType()
        {
            Room r = new Room();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t" + "Room Categories & their Facilities");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("1- Single: A room assigned to one person that consist of single bed.");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t" + "* Price Per Night: " + r.TypeSingle);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("2- Double: A room assigned to two people. May have one or more beds.");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t" + "* Price Per Night: " + r.TypeDouble);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("3- Triple: A room that can accommodate three persons and has been fitted with three twin beds.");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t" + "* Price Per Night: " + r.TypeTriple);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("4- Twin: A room with two twin beds. May be occupied by one or more people.");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t" + "* Price Per Night: " + r.TypeTwin);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("5- Executive: A parlour or living room connected with to one or more bedrooms.");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t" + "* Price Per Night: " + r.TypeExecutive);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("6- King: A room with a king-sized bed. May be occupied by one or more people.");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t" + "* Price Per Night: " + r.TypeKing);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

        // Room Suggestion
        public static void roomSuggestion(string totalPerson)
        {
            if (totalPerson == "1")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("---------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Recommended Room Type");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("> Single");
                Console.WriteLine("> Twin");
                Console.WriteLine("> King");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("---------------------");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (totalPerson == "2")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("---------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Recommended Room Type");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("> Double");
                Console.WriteLine("> Twin");
                Console.WriteLine("> King");
                Console.WriteLine("> Executive");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("---------------------");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (totalPerson == "3")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("---------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Recommended Room Type");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("> Triple");
                Console.WriteLine("> King");
                Console.WriteLine("> Executive");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("---------------------");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (totalPerson == "4" || totalPerson == "5")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("---------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Recommended Room Type");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("> King");
                Console.WriteLine("> Executive");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("---------------------");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
