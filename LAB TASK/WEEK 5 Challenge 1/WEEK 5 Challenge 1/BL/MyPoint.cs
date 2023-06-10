using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_5_Challenge_1.BL
{
    class MyPoint
    {
        MyLine objpoints = new MyLine();

        public int x;
        public int y;
        public MyPoint()
        {

        }
        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public void setXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public double distanceWithCoordiates(int x, int y)
        {
            double distane = (((this.x - x) * (this.x - x)) + ((this.y - y) * (this.y - y)));
            distane = Math.Sqrt(distane);
            return distane;
        }
        public double distanceWithobject(MyPoint another)
        {
            double distane = (((x - another.x) * (x - another.x)) + ((y - another.y) * (y - another.y)));
            distane = Math.Sqrt(distane);
            return distane;
        }
        public double distanceFromZero()
        {
            double distane = (((this.x - 0) * (this.x - 0)) + ((this.y - 0) * (this.y - 0)));
            distane = Math.Sqrt(distane);
            return distane;
        }
    }
}
