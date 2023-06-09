using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_8_PROBLEM_4.BL
{
    class Rectangle : Shape
    {
        private double width = 0;
        private double height = 0;
        public Rectangle()
        {

        }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
            this.type = "Rectangle";
        }
        public void setWidth(double width)
        {
            this.width = width;
        }
        public void setHeight(double height)
        {
            this.height = height;
        }
        public override double getArea()
        {
            area = width * height;
            return area;
        }
        public override string toString()
        {
            return "This shape is " + type + " and its area is " + getArea();
        }
    }
}
