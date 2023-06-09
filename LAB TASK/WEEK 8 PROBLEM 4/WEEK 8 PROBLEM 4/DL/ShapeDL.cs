using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_8_PROBLEM_4.BL;
using WEEK_8_PROBLEM_4.UI;

namespace WEEK_8_PROBLEM_4.DL
{
    class ShapeDL
    {
        static private List<Shape> shapesList = new List<Shape>();

        public static void addIntoList(Shape s)
        {
            shapesList.Add(s);
        }
        public static void Display()
        {
            foreach (Shape s in shapesList)
            {
                ShapeUI.GetData(s);
            }
        }
    }
}
