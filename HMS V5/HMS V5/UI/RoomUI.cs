using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_V5.BL;

namespace HMS_V5.UI
{
    class RoomUI
    {
        public static void roomType()
        {
            Room r = new Room();
            Console.WriteLine("\t" + "Room Categories & their Facilities");
            Console.WriteLine();
            Console.WriteLine("1- Single: A room assigned to one person that consist of single bed.");
            Console.WriteLine("\t" + "* Price Per Night: " + r.type_single);
            Console.WriteLine();
            Console.WriteLine("2- Double: A room assigned to two people. May have one or more beds.");
            Console.WriteLine("\t" + "* Price Per Night: " + r.type_double);
            Console.WriteLine();
            Console.WriteLine("3- Triple: A room that can accommodate three persons and has been fitted with three twin beds.");
            Console.WriteLine("\t" + "* Price Per Night: " + r.type_triple);
            Console.WriteLine();
            Console.WriteLine("4- Twin: A room with two twin beds. May be occupied by one or more people.");
            Console.WriteLine("\t" + "* Price Per Night: " + r.type_twin);
            Console.WriteLine();
            Console.WriteLine("5- Executive: A parlour or living room connected with to one or more bedrooms.");
            Console.WriteLine("\t" + "* Price Per Night: " + r.type_executive);
            Console.WriteLine();
            Console.WriteLine("6- King: A room with a king-sized bed. May be occupied by one or more people.");
            Console.WriteLine("\t" + "* Price Per Night: " + r.type_king);
            Console.WriteLine();
        }

        // Room Suggestion
        public static void roomSuggestion(string totalPerson)
        {
            if (totalPerson == "1")
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Recommended Room Type");
                Console.WriteLine("> Single");
                Console.WriteLine("> Twin");
                Console.WriteLine("> King");
                Console.WriteLine("---------------------");
            }
            else if (totalPerson == "2")
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Recommended Room Type");
                Console.WriteLine("> Double");
                Console.WriteLine("> Twin");
                Console.WriteLine("> King");
                Console.WriteLine("> Executive");
                Console.WriteLine("---------------------");
            }
            else if (totalPerson == "3")
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Recommended Room Type");
                Console.WriteLine("> Triple");
                Console.WriteLine("> King");
                Console.WriteLine("> Executive");
                Console.WriteLine("---------------------");
            }
            else if (totalPerson == "4" || totalPerson == "5")
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Recommended Room Type");
                Console.WriteLine("> King");
                Console.WriteLine("> Executive");
                Console.WriteLine("---------------------");
            }
        }
    }
}
