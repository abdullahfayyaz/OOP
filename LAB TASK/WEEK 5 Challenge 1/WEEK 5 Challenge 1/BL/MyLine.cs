using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_5_Challenge_1.BL
{
    class MyLine
    {
        public MyPoint begin;
        public MyPoint end;

        public MyLine()
        {

        }
        public MyLine(MyPoint begin, MyPoint end)
        {
            this.begin = begin;
            this.end = end;
        }
        public MyPoint getbegin()
        {
            return begin;
        }
        public MyPoint getend()
        {
            return end;
        }
        public void setBegin(MyPoint begin)
        {
            this.begin = begin;
        }
        public void setend(MyPoint end)
        {
            this.end = end;
        }
        public double getLength()
        {
            double distance;
            distance = (((end.x - begin.x) * (end.x - begin.x)) + ((end.y - begin.y) * (end.y - begin.y)));
            distance = Math.Sqrt(distance);
            return distance;
        }
        public double getGradient()
        {
            double gradient;
            double yS = end.y - begin.y;
            double xS = end.x - begin.x;
            gradient = yS / xS;
            return gradient;
        }
    }
}
