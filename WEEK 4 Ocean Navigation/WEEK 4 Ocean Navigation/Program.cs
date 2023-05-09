using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_4_Ocean_Navigation.BL;

namespace WEEK_4_Ocean_Navigation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ship> shipsdata = new List<Ship>();
            int option = 0;
            while (option != 5)
            {
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    adddata(shipsdata);
                }
                if (option == 2)
                {
                    viewShipPosition(shipsdata);
                    Console.ReadKey();
                }
                if (option == 3)
                {
                    shipCoordinate(shipsdata);
                    Console.ReadKey();
                }
                if (option == 4)
                {
                    changePosition(shipsdata);
                }
                Console.Clear();
            }
        }
        static int menu()
        {
            Console.WriteLine(" 1. Add Ship");
            Console.WriteLine(" 2. View Ship Position");
            Console.WriteLine(" 3. View Ship Serial number");
            Console.WriteLine(" 4. Change Ship Position");
            Console.WriteLine(" 5. Exit");
            Console.Write(" Enter your Choice: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        static void adddata(List<Ship> shipsdata)
        {

            Console.Write(" Enter ship number: ");
            string number = Console.ReadLine();
            Console.WriteLine("Enter Ship Latitude ");
            Console.Write("Enter Latitude Degree: ");
            int latdeg = int.Parse(Console.ReadLine());
            Console.Write("Enter Latitude minutes: ");
            float latdmin = float.Parse(Console.ReadLine());
            Console.Write("Enter Latitude Direction: ");
            char latdir = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Ship Longitude ");
            Console.Write("Enter Longitude Degree: ");
            int longdeg = int.Parse(Console.ReadLine());
            Console.Write("Enter Longitude minutes: ");
            float longdmin = float.Parse(Console.ReadLine());
            Console.Write("Enter Longitude Direction: ");
            char longdir = char.Parse(Console.ReadLine());
            Ship obj = new Ship(number);
            obj.shiplong(longdeg, longdmin, longdir);
            obj.shiplat(latdeg, latdmin, latdir);
            shipsdata.Add(obj);
        }
        static void viewShipPosition(List<Ship> shipsdata)
        {
            Ship obj = new Ship();
            string name;
            Console.Write(" Enter Ship Serial number to find its postion: ");
            name = Console.ReadLine();
            int index = obj.shipposition(shipsdata, name);
            int degree = 0;
            float minute = 0;
            char direction = ' ';
            shipsdata[index].latvalue(ref degree, ref minute, ref direction);
            Console.Write("Ship is at " + degree + ">" + minute + "'" + direction + " and ");
            shipsdata[index].longvalue(ref degree, ref minute, ref direction);
            Console.WriteLine(degree + ">" + minute + "'" + direction);
        }
        static void changePosition(List<Ship> shipsdata)
        {
            string name = "";
            Console.Write(" Enter Ship serial number whose position to be changed: ");
            name = Console.ReadLine();
            Ship obj = new Ship();
            int index = obj.shipposition(shipsdata, name);

            Console.WriteLine("Enter Latitude ");
            Console.Write("Enter Latitude Degree: ");
            int latdeg = int.Parse(Console.ReadLine());
            Console.Write("Enter Latitude minutes: ");
            float latdmin = float.Parse(Console.ReadLine());
            Console.Write("Enter Latitude Direction: ");
            char latdir = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Longitude ");
            Console.Write("Enter Longitude Degree: ");
            int longdeg = int.Parse(Console.ReadLine());
            Console.Write("Enter Longitude minutes: ");
            float longdmin = float.Parse(Console.ReadLine());
            Console.Write("Enter Longitude Direction: ");
            char longdir = char.Parse(Console.ReadLine());

            shipsdata[index].shiplong(longdeg, longdmin, longdir);
            shipsdata[index].shiplat(latdeg, latdmin, latdir);
        }
        static void shipCoordinate(List<Ship> shipsdata)
        {
            Ship s = new Ship();
            Console.WriteLine(" > for degree sign and < for ' sign ");
            string latcoordinates = "";
            Console.Write(" Enter the ship Latitude: ");
            latcoordinates = Console.ReadLine();
            string longcoordinates = "";
            Console.Write(" Enter the ship Longitude: ");
            longcoordinates = Console.ReadLine();
            int latdegree = 0;
            float latminute = 0;
            char latdirection = ' ';
            int longdegree = 0;
            float longminute = 0;
            char longdirection = ' ';
            s.shipserialnumber(longcoordinates, latcoordinates, ref latdegree, ref latminute, ref latdirection, ref longdegree, ref longminute, ref longdirection);
            int index = 0;
            bool find = false;
            for (int x = 0; x < shipsdata.Count; x++)
            {
                find = shipsdata[x].valusereturn(ref latdegree, ref latminute, ref latdirection, ref longdegree, ref longminute, ref longdirection);
                if (find)
                {
                    index = x;
                }
            }
            if (find)
            {
                Console.WriteLine(" Ship serial number: " + shipsdata[index].shipno);
            }
            else
            {
                Console.WriteLine(" Incorrect Coordinates!!!!");
            }
        }
    }
}
