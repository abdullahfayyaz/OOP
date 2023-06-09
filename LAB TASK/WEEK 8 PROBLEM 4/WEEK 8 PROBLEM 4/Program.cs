using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_8_PROBLEM_4.BL;
using WEEK_8_PROBLEM_4.DL;
using WEEK_8_PROBLEM_4.UI;

namespace WEEK_8_PROBLEM_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Rectangle();
            s1 = RectangleUI.CreateShape();
            ShapeDL.addIntoList(s1);
            Shape s2 = new Circle();
            s2 = CircleUI.CreateShape();
            ShapeDL.addIntoList(s2);
            Shape s3 = new Square();
            s3 = SquareUI.CreateShape();
            ShapeDL.addIntoList(s3);
            Shape s4 = new Rectangle();
            s4 = RectangleUI.CreateShape();
            ShapeDL.addIntoList(s4);
            Shape s5 = new Circle();
            s5 = CircleUI.CreateShape();
            ShapeDL.addIntoList(s5);
            ShapeDL.Display();
            Console.ReadKey();
        }
    }
}
