using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_8_PROBLEM_1.BL
{
    class Cylinder : Circle
    {
        private double height = 1.0;
        public Cylinder()
        {

        }
        public Cylinder(double radius)
        {
            this.radius = radius;
        }
        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }
        public Cylinder(double radius, double height, string color)
        {
            this.radius = radius;
            this.height = height;
            this.color = color;
        }
        public double getHeight()
        {
            return height;
        }
        public  void setHeight(double height)
        {
            this.height = height;
        }
        public double getVolume()
        {
            return (2 * Math.PI * radius * height);
        }
    }
}
