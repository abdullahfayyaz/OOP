using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_5_Challenge_1.BL;
using WEEK_5_Challenge_1.UI;

namespace WEEK_5_Challenge_1
{
    class Program
    {
        static MyLine objLine = new MyLine();
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                Console.Clear();
                option = CRUD.menu();
                if (option == 1)
                {
                    Console.Clear();
                    objLine = CRUD.makeLineX();
                    Console.ReadKey();
                }
                if (option == 2)
                {
                    Console.Clear();
                    MyPoint point = CRUD.changeBeginPoint();
                    objLine.begin.setX(point.x);
                    objLine.begin.setY(point.y);
                    Console.ReadKey();
                }
                if (option == 3)
                {
                    Console.Clear();
                    MyPoint point = CRUD.changeEndPoint();
                    objLine.end.setX(point.x);
                    objLine.end.setY(point.y);
                    Console.ReadKey();
                }
                if (option == 4)
                {
                    Console.Clear();
                    CRUD.viewStartingPoints(objLine);
                    Console.ReadKey();
                }
                if (option == 5)
                {
                    Console.Clear();
                    CRUD.viewEndingPoints(objLine);
                    Console.ReadKey();
                }
                if (option == 6)
                {
                    Console.Clear();
                    double length = objLine.getLength();
                    CRUD.viewLength(length);
                    Console.ReadKey();
                }
                if (option == 7)
                {
                    Console.Clear();
                    double gradient = objLine.getGradient();
                    CRUD.viewGradient(gradient);
                    Console.ReadKey();
                }
                if (option == 8)
                {
                    Console.Clear();
                    double distance = objLine.begin.distanceFromZero();
                    CRUD.beginPointsDistance(distance);
                    Console.ReadKey();
                }
                if (option == 9)
                {
                    Console.Clear();
                    double distance = objLine.end.distanceFromZero();
                    CRUD.endPointsDistance(distance);
                    Console.ReadKey();
                }
            }
            while (option != 10);
        }
    }
}
