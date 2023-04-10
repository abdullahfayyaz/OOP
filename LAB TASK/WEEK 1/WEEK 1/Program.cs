using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WEEK_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task1();
            // Task2();
            // Task3();
            // Task4();
            // Task5();
            // Task6();
            // Task7();
            // Task8();
            // Task9();
            // Task10();
            // Task11();
            // Task12();
            // Task13();
            // Task14();
            // Task15();
            // Task16();
            // Task17();
            // Task18();
            // Task19();
            // Task20();
        }
        static void Task1()
        {
            Console.Write("HELLO WORLD!!");
            Console.Write("HELLO WORLD!!");
            Console.ReadKey();
        }
        static void Task2()
        {
            Console.WriteLine("HELLO WORLD!!");
            Console.Write("HELLO WORLD!!");
            Console.ReadKey();
        }
        static void Task3()
        {
            int number = 7;
            Console.Write("Number: " + number);
            Console.ReadKey();
        }
        static void Task4()
        {
            string variable = "I am string";
            Console.WriteLine("String: ");
            Console.Write(variable);
            Console.ReadKey();
        }
        static void Task5()
        {
            char variable = 'A';
            Console.WriteLine("Character: ");
            Console.Write(variable);
            Console.ReadKey();
        }
        static void Task6()
        {
            float variable = 2.2F;
            Console.WriteLine("Decimal: ");
            Console.Write(variable);
            Console.ReadKey();
        }
        static void Task7()
        {
            string str;
            str = Console.ReadLine();
            Console.WriteLine("You have inputted: ");
            Console.WriteLine(str);
            Console.ReadKey();
        }
        static void Task8()
        {
            string str;
            str = Console.ReadLine();
            Console.WriteLine("You have inputted: ");
            int number = int.Parse(str);
            Console.WriteLine("The Number is: ");
            Console.Write(number);
            Console.ReadKey();
        }
        static void Task9()
        {
            string str;
            Console.WriteLine("Enter Floating Point Value: ");
            str = Console.ReadLine();
            float number = float.Parse(str);
            Console.WriteLine("The Floating Value is: ");
            Console.Write(number);
            Console.ReadKey();
        }
        static void Task10()
        {
            float length;
            float area;
            string input;
            Console.WriteLine("Enter Length: ");
            input = Console.ReadLine();
            length = float.Parse(input);
            area = length * length;
            Console.WriteLine("The Area is: ");
            Console.Write(area);
            Console.ReadKey();
        }
        static void Task11()
        {
            string input;
            float marks;
            Console.Write("Enter Marks: ");
            input = Console.ReadLine();
            marks = float.Parse(input);
            if (marks > 50)
            {
                Console.WriteLine("You are Passed");
            }
            else
            {
                Console.WriteLine("You are Failed");
            }
            Console.ReadKey();
        }
        static void Task12()
        {
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Welcome Jack");
            }
            Console.ReadKey();
        }
        static void Task13()
        {
            int number;
            int sum = 0;
            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());
            while (number != -1)
            {
                sum = sum + number;
                Console.Write("Enter Number: ");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The total sum is {0}", sum);
            Console.ReadKey();
        }
        static void Task14()
        {
            int number;
            int sum = 0;
            do
            {
                Console.Write("Enter Number: ");
                number = int.Parse(Console.ReadLine());
                sum = sum + number;
            }
            while (number != -1);
            sum = sum + 1;
            Console.WriteLine("The total sum is {0}", sum);
            Console.ReadKey();
        }
        static void Task15()
        {
            int[] numbers = new int[3];
            for (int index = 0; index < 3; index++)
            {
                Console.Write("Enter Number: ");
                numbers[index] = int.Parse(Console.ReadLine());
            }
            int largest = -1;
            for (int index = 0; index < 3; index++)
            {
                if (numbers[index] > largest)
                {
                    largest = numbers[index];
                }
            }
            Console.WriteLine("Largest is: {0}", largest);
            Console.ReadKey();
        }
        static void Task16()
        {
            string path = "C:\\Users\\HP\\Documents\\STUDY\\2nd Semester\\OOP\\LAB TASK\\WEEK 1\\file.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine("HELLO");
            file.Flush();
            file.Close();
            Console.ReadKey();
        }
        static void Task17()
        {
            string path = "C:\\Users\\HP\\Documents\\STUDY\\2nd Semester\\OOP\\LAB TASK\\WEEK 1\\file.txt";
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                }
                file.Close();
            }
            else
            {

                Console.WriteLine("File Not Exists");
            }
            Console.ReadKey();
        }
        static void Task18()
        {
            int number1;
            int number2;
            Console.Write("Enter 1st Number: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd Number: ");
            number2 = int.Parse(Console.ReadLine());
            int result = add(number1, number2);
            Console.Write("Sum is {0}", result);
            Console.ReadKey();
        }
        static int add(int num1, int num2)
        {
            return num1 + num2;
        }
        static void Task19()
        {
            int age;
            float priceM, priceT, money;
            float even = 0, odd = 0;
            float sum;
            Console.Write("Enter Lilly's Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter Machine Price: ");
            priceM = float.Parse(Console.ReadLine());
            Console.Write("Enter Each toy price: ");
            priceT = float.Parse(Console.ReadLine());
            while (age > 0)
            {
                if (age % 2 == 0)
                {
                    even++;
                }
                else if (age % 2 != 0)
                {
                    odd++;
                }
                age--;
            }
            sum = (even / 2) * (20 + (even - 1) * 10);
            money = sum + (odd * priceT);
            money = money - even;
            if (money > priceM)
            {
                money = money - priceM;
                Console.Write("Yes! " + money);
                Console.Write(" USD are Remaining");
            }
            else if (money < priceM)
            {
                money = priceM - money;
                Console.Write("No! " + money);
                Console.Write(" more USD are Required");
            }
            Console.ReadKey();
        }
        static void Task20()
        {
                string path = "C:\\Users\\HP\\Documents\\STUDY\\2nd Semester\\OOP\\LAB TASK\\WEEK 1\\Customers.txt";
                string[] names = new string[5];
                int uOrder;
                int uprice;
                int orders = 1;
                int orders1 = 1;
                int[] prices = new int[100];
                int[] price1 = new int[100];
                bool check = readdata(path, names, orders, orders1, prices, price1);
                if (check)
                {
                    Console.Write("Enter No. of Order: ");
                    uOrder = int.Parse(Console.ReadLine());
                    Console.Write("Enter Minimum Price: ");
                    uprice = int.Parse(Console.ReadLine());
                    calculate(names, orders, orders1, prices, price1, uOrder, uprice);
                }

                Console.ReadKey();
            }
            static string parseData(string record, int field)
            {
                int comma = 1;
                string item = "";
                for (int x = 0; x < record.Length; x++)
                {
                    if (record[x] == ',')
                    {
                        comma++;
                    }
                    else if (comma == field)
                    {
                        item = item + record[x];
                    }
                }
                return item;
            }
            static bool readdata(string path, string[] names, int orders, int orders1, int[] prices, int[] price1)
            {

                if (File.Exists(path))
                {
                    StreamReader filevariable = new StreamReader(path);
                    string record;
                    record = filevariable.ReadLine();
                    names[0] = parseData(record, 1);
                    orders = int.Parse(parseData(record, 2));
                    int y = 0;

                    for (int index = 3; index < 11; index++)
                    {
                        prices[y] = int.Parse(parseData(record, index));
                        y++;
                    }
                    record = filevariable.ReadLine();
                    names[1] = parseData(record, 1);
                    orders1 = int.Parse(parseData(record, 2));
                    int z = 0;
                    for (int x = 3; x < 13; x++)
                    {
                        price1[z] = int.Parse(parseData(record, x));
                        z++;
                    }

                    filevariable.Close();
                    return true;
                }
                else
                {
                    Console.WriteLine(" Not Exists");
                    return false;
                }
            }
            static void calculate(string[] names, int orders, int orders1, int[] prices, int[] price1, int uOrder, int uprice)
            {
                int sum = 0;
                int ave = 0;
                for (int x = 0; x < uOrder; x++)
                {
                    sum = sum + prices[x];
                }
                ave = sum / uOrder;
                if (ave > uprice)
                {
                    Console.WriteLine(" " + names[0]);
                }
                int sum1 = 0;
                int ave1 = 0;

                for (int x = 0; x < uOrder; x++)
                {
                    sum1 = sum1 + price1[x];
                }
                ave1 = sum1 / uOrder;
                if (ave1 > uprice)
                {
                    Console.WriteLine(" " + names[1]);
                }
                else
                {
                    Console.WriteLine("none");
                }
            }
        }
    }
