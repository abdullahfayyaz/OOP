using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_8_PROBLEM_4.BL;

namespace WEEK_8_PROBLEM_4.UI
{
    class SquareUI
    {
        public static Square CreateShape()
        {
            Console.Write("Enter Side: ");
            double side = double.Parse(Console.ReadLine());
            Square s = new Square(side);
            return s;
        }
    }
}
