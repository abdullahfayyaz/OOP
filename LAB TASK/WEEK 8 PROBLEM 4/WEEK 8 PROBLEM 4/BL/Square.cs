using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_8_PROBLEM_4.BL
{
    class Square : Shape
    {
        private double side = 0;
        public Square()
        {

        }
        public Square(double side)
        {
            this.side = side;
            this.type = "Square";
        }
        public void setSide(double side)
        {
            this.side = side;
        }
        public override double getArea()
        {
            area = side * side;
            return area;
        }
        public override string toString()
        {
            return "This shape is " + type + " and its area is " + getArea();
        }
    }
}
