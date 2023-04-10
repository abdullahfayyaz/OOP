using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WEEK_2_CHALLENGE.BL;

namespace WEEK_2_CHALLENGE
{
    class Program
    {
        static void Main(string[] args)
        {
            //challenge_1();
            challenge_2();
        }

        // Challenge 1
        static void challenge_1()
        {
            products[] p = new products[10];
            string option;
            int count = 0;
            do
            {
                option = menu();
                if (option == "1")
                {
                    p[count] = addProduct();
                    count = count + 1;
                }
                else if (option == "2")
                {
                    viewProduct(p, count);
                }
                else if (option == "3")
                {
                    calculateTotalPrice(p, count);
                }
                else if (option == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
            while (option != "4");
            Console.WriteLine("Press Enter to Exit.. ");
            Console.Read();
        }
        static string menu()
        {
            Console.Clear();
            string choice;
            Console.WriteLine("Press 1 for Adding a Product: ");
            Console.WriteLine("Press 2 for View a Product: ");
            Console.WriteLine("Press 3 to Calculate Total Store Worth: ");
            Console.WriteLine("Press 4 to exit: ");
            choice = Console.ReadLine();
            return choice;
        }
        static products addProduct()
        {
            Console.Clear();
            products p1 = new products();
            Console.Write("Enter Product Name: ");
            p1.name = Console.ReadLine();
            Console.Write("Enter Product ID: ");
            p1.id = Console.ReadLine();
            Console.Write("Enter Price: ");
            p1.price = float.Parse(Console.ReadLine());
            Console.Write("Enter Category: ");
            p1.category = Console.ReadLine();
            Console.Write("Enter Brand Name: ");
            p1.brandName = Console.ReadLine();
            Console.Write("Enter Country: ");
            p1.country = Console.ReadLine();
            return p1;
        }
        static void viewProduct(products[] p, int count)
        {
            Console.Clear();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Product Name: {0} Product ID: {1} Price: {2} Category: {3} Brand Name: {4} Country: {5}", p[i].name, p[i].id, p[i].price, p[i].category, p[i].brandName, p[i].country);
            }
            Console.WriteLine("Press any key to contniue... ");
            Console.ReadKey();
        }
        static void calculateTotalPrice(products[] p, int count)
        {
            Console.Clear();
            float sum = 0.0F;
            for (int i = 0; i < count; i++)
            {
                sum = sum + p[i].price;
            }
            Console.WriteLine("Total Store Worth: {0}", sum);
            Console.WriteLine("Press any key to contniue... ");
            Console.ReadKey();
        }

        // Challenge 2
        static void challenge_2()
        {
            string path = "C:\\Users\\HP\\Documents\\STUDY\\2nd Semester\\OOP\\LAB TASK\\WEEK 2 CHALLENGE\\usersData.txt";
            credentials[] c = new credentials[10];
            int count = 0;
            string option;
            do
            {
                readData(path, c, ref count);
                Console.Clear();
                option = loginMenu();
                Console.Clear();
                if (option == "1")
                {
                    Console.Write("Enter UserName: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    string password = Console.ReadLine();
                    signIn(name, password, c, count);
                }
                else if (option == "2")
                {
                    c[count] = addUser();
                    count = count + 1;
                    signUp(path, c, ref count);
                }
            }
            while (option != "3");
            Console.ReadKey();
        }
        static string loginMenu()
        {
            string option;
            Console.WriteLine("1. SignIn");
            Console.WriteLine("2. SignUp");
            Console.WriteLine("3- Exit");
            Console.Write("Enter Option: ");
            option = Console.ReadLine();
            return option;
        }
        static credentials addUser()
        {
            Console.Clear();
            credentials c1 = new credentials();
            Console.Write("Enter New UserName: ");
            c1.userName = Console.ReadLine();
            Console.Write("Enter New Password: ");
            c1.password = Console.ReadLine();
            return c1;
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
        static void readData(string path, credentials[] c, ref int count)
        {
            credentials c1 = new credentials();
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string name = parseData(record, 1);
                    string pass = parseData(record, 2);
                    c1.userName = name;
                    c1.password = pass;
                    c[x] = c1;
                    x++;
                    count++;
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
        }
        static void signIn(string name, string password, credentials[] c, int count)
        {
            bool flag = false;
            for (int x = 0; x < count; x++)
            {
                if (name == c[x].userName && password == c[x].password)
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Invalid User");
            }
            Console.ReadKey();
        }
        static void signUp(string path, credentials[] c, ref int count)
        {
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < count; i++)
            {
                file.WriteLine(c[i].userName + "," + c[i].password);
            }
            file.Flush();
            file.Close();
        }
    }

}
