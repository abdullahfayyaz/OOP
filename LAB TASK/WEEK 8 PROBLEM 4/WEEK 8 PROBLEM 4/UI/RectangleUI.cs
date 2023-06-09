using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_8_PROBLEM_4.BL;

namespace WEEK_8_PROBLEM_4.UI
{
    class RectangleUI
    {
        public static Rectangle CreateShape()
        {
            Console.Write("Enter Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter Height: ");
            double height = double.Parse(Console.ReadLine());
            Rectangle r = new Rectangle(width, height);
            return r;
        }
    }
}
