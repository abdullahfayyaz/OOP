using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_8_PROBLEM_1.BL
{
    class Circle
    {
        protected double radius = 1.0;
        protected string color = " red";
        protected double area;
        public Circle()
        {

        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public string getColor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public double getArea()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
        public string toString()
        {
            return "Radius: " + radius + "Color: " + color + "Area: " + area;
        }
    }
}
