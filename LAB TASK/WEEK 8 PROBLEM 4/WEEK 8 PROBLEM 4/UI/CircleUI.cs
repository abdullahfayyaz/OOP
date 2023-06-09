using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_8_PROBLEM_4.BL;

namespace WEEK_8_PROBLEM_4.UI
{
    class CircleUI
    {
        public static Circle CreateShape()
        {
            double radius;
            Console.Write("Enter Radius: ");
            radius = double.Parse(Console.ReadLine());
            Circle c = new Circle(radius);
            return c;
        }
    }
}
