using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_2
{
    class Program
    {
        class students
        {
            public string name;
            public int roll_no;
            public float cgpa;
        }
        static void Main(string[] args)
        {
            // Task1();
            // Task2();
        }
        static void Task1()
        {
            // first Object
            students s1 = new students();
            s1.name = "ahmad";
            s1.roll_no = 5;
            s1.cgpa = 3.25F;
            Console.WriteLine("Name : {0} Roll No: {1} CGPA: {2}", s1.name, s1.roll_no, s1.cgpa);
            // Second Object
            students s2 = new students();
            s2.name = "bilal";
            s2.roll_no = 6;
            s2.cgpa = 3.75F;
            Console.WriteLine("Name : {0} Roll No: {1} CGPA: {2}", s2.name, s2.roll_no, s2.cgpa);
            Console.Read();
        }
        static void Task2()
        {
            // first Object
            students s1 = new students();
            Console.WriteLine("Enter Name: ");
            s1.name = Console.ReadLine();
            Console.WriteLine("Enter Roll No: ");
            s1.roll_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter CGPA: ");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Name : {0} Roll No: {1} CGPA: {2}", s1.name, s1.roll_no, s1.cgpa);
            Console.Read();
        }
    }
}
