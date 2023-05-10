using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_V4.BL
{
    class roomCategories
    {
        public int type_single = 3000;
        public int type_double = 5000;
        public int type_triple = 8000;
        public int type_twin = 6000;
        public int type_executive = 15000;
        public int type_king = 10000;
        public void roomType()
        {
            Console.WriteLine("\t" + "Room Categories & their Facilities");
            Console.WriteLine();
            Console.WriteLine("1- Single: A room assigned to one person that consist of single bed.");
            Console.WriteLine("\t" + "* Price Per Night: " + type_single);
            Console.WriteLine();
            Console.WriteLine("2- Double: A room assigned to two people. May have one or more beds.");
            Console.WriteLine("\t" + "* Price Per Night: " + type_double);
            Console.WriteLine();
            Console.WriteLine("3- Triple: A room that can accommodate three persons and has been fitted with three twin beds.");
            Console.WriteLine("\t" + "* Price Per Night: " + type_triple);
            Console.WriteLine();
            Console.WriteLine("4- Twin: A room with two twin beds. May be occupied by one or more people.");
            Console.WriteLine("\t" + "* Price Per Night: " + type_twin);
            Console.WriteLine();
            Console.WriteLine("5- Executive: A parlour or living room connected with to one or more bedrooms.");
            Console.WriteLine("\t" + "* Price Per Night: " + type_executive);
            Console.WriteLine();
            Console.WriteLine("6- King: A room with a king-sized bed. May be occupied by one or more people.");
            Console.WriteLine("\t" + "* Price Per Night: " + type_king);
            Console.WriteLine();
        }

        // Checkout
        public int checkoutBill(List<customer> customerData, int index)
        {
            int bill = 0;
            customer c = new customer();
            c = customerData[index];
            int stay_days = int.Parse(c.no_of_stay);
            if (c.roomType == "single" || c.roomType == "Single")
            {
                bill = type_single * stay_days;
            }
            else if (c.roomType == "double" || c.roomType == "Double")
            {
                bill = type_double * stay_days;
            }
            else if (c.roomType == "triple" || c.roomType == "Triple")
            {
                bill = type_triple * stay_days;
            }
            else if (c.roomType == "twin" || c.roomType == "Twin")
            {
                bill = type_twin * stay_days;
            }
            else if (c.roomType == "executive" || c.roomType == "Executive")
            {
                bill = type_executive * stay_days;
            }
            else if (c.roomType == "king" || c.roomType == "King")
            {
                bill = type_king * stay_days;
            }
            return bill;
        }
    }
}
