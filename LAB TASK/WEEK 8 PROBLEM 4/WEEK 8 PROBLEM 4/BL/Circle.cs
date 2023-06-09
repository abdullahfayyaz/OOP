using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_8_PROBLEM_4.BL
{
    class Circle : Shape
    {
        private double radius = 0;
        public Circle()
        {

        }
        public Circle(double radius)
        {
            this.radius = radius;
            this.type = "Circle";
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public override double getArea()
        {
            area = 2 * Math.PI * Math.Pow(radius, 2);
            return area;
        }
        public override string toString()
        {
            return "This shape is " + type + " and its area is " + getArea();
        }
    }
}
