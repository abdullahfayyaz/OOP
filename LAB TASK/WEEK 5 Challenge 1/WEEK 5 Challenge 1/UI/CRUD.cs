using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_5_Challenge_1.BL;

namespace WEEK_5_Challenge_1.UI
{
    class CRUD
    {
        public static int menu()
        {
            Console.WriteLine(" 1. Make a Line");
            Console.WriteLine(" 2. Update the begin point");
            Console.WriteLine(" 3. Update the end point");
            Console.WriteLine(" 4. Show the begin point");
            Console.WriteLine(" 5. Show the end point");
            Console.WriteLine(" 6. Get the length of line");
            Console.WriteLine(" 7. Get gradient of line");
            Console.WriteLine(" 8. Find the distance of begin point from zero");
            Console.WriteLine(" 9. Find the distance of end point from zero");
            Console.WriteLine(" 10. Exit");
            Console.Write(" Enter your choice: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public static MyLine makeLineX()
        {
            Console.WriteLine("Enter X value of Starting line: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y value of Starting line: ");
            int y1 = int.Parse(Console.ReadLine());
            MyPoint begining = new MyPoint(x1, y1);
            Console.WriteLine();
            Console.WriteLine("Enter X value of Ending line: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y value of Ending line: ");
            int y2 = int.Parse(Console.ReadLine());
            MyPoint ending = new MyPoint(x2, y2);
            MyLine line = new MyLine(begining, ending);
            return line;
        }
        public static void viewStartingPoints(MyLine line)
        {
            int startX = line.begin.x;
            int startY = line.begin.y;
            Console.WriteLine("         x =  " + startX);
            Console.WriteLine("         y =  " + startY);
        }
        public static void viewEndingPoints(MyLine line)
        {
            int endX = line.end.x;
            int endY = line.end.y;
            Console.WriteLine("         x =  " + endX);
            Console.WriteLine("         y =  " + endY);
        }
        public static MyPoint changeBeginPoint()
        {
            Console.WriteLine("Enter any point To  change Staring X Point: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter any point To  change Staring Y Point: ");
            int x2 = int.Parse(Console.ReadLine());
            MyPoint startU = new MyPoint(x1, x2);
            return startU;
        }
        public static MyPoint changeEndPoint()
        {
            Console.WriteLine("Enter any point To  change Ending X Point: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter any point To  change Ending Y Point: ");
            int x2 = int.Parse(Console.ReadLine());
            MyPoint endU = new MyPoint(x1, x2);
            return endU;
        }
        public static void viewLength(double length)
        {
            Console.WriteLine("Length is " + length);
        }
        public static void viewGradient(double gradient)
        {
            Console.WriteLine("Gradient is " + gradient);
        }
        public static void beginPointsDistance(double distance)
        {
            Console.WriteLine("Distance of Begin Points From Zero is " + distance);
        }
        public static void endPointsDistance(double distance)
        {
            Console.WriteLine("Distance of End Points From Zero is " + distance);
        }
    }
}
