using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_8_PROBLEM_4.BL
{
    class Shape
    {
        protected double area = 0;
        protected string type;
        public Shape()
        {

        }
        public void setArea(double area)
        {
            this.area = area;
        }
        public virtual double getArea()
        {
            return 0;
        }
        public virtual string toString()
        {
            return " ";
        }
    }
}
