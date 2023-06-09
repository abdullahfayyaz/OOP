using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_7_Inheritance.BL;

namespace WEEK_7_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            DayScholar std = new DayScholar();
            std.name = "Ahmad";
            std.busNo = 1;
            Console.WriteLine(std.name + " is Allocated Bus " + std.busNo);
            Hostelite std2 = new Hostelite();
            std2.name = "Ali";
            std2.RoomNumber = 12;
            Console.WriteLine(std2.name + " is Allocated Room " + std2.RoomNumber);
            Console.ReadKey();
        }
    }
}
