using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_8_PROBLEM_1.BL;

namespace WEEK_8_PROBLEM_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder c1 = new Cylinder();
            Cylinder c2 = new Cylinder(2);
            Cylinder c3 = new Cylinder(2, 3);
            c2.setHeight(5);
            double volume = c2.getVolume();
            Console.WriteLine("Volume of Cylinder: " + volume);
            Console.ReadKey();
        }
    }
}
