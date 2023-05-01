using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEKK_3.BL;

namespace WEKK_3
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
        }
        static void Task1()
        {
            student s1 = new student();
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
            Console.Read();
        }
        static void Task2()
        {
            Student s1 = new Student();
            Console.Read();
        }
        static void Task3()
        {
            STUDENT s1 = new STUDENT();
            Console.Write(s1.sname);
            Console.Read();
        }
        static void Task4()
        {
            STUDENT s1 = new STUDENT();
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
            Console.Read();
        }
        static void Task5()
        {
            STUDENT s1 = new STUDENT();
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
            Console.WriteLine();
            STUDENT s2 = new STUDENT();
            Console.WriteLine(s2.sname);
            Console.WriteLine(s2.matricMarks);
            Console.WriteLine(s2.fscMarks);
            Console.WriteLine(s2.ecatMarks);
            Console.WriteLine(s2.aggregate);
            Console.Read();
        }
        static void Task6()
        {
            studentP s1 = new studentP("John");
            Console.WriteLine(s1.sname);
            studentP s2 = new studentP("Jack");
            Console.WriteLine(s2.sname);
            Console.Read();
        }
        static void Task7()
        {
            studentPara s1 = new studentPara("Jack", 1100, 1100, 400, 100);
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
            Console.Read();
        }
        static void Task8()
        {
            studentPara s1 = new studentPara("Jack", 1100, 1100, 400, 100);
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
            Console.WriteLine();
            studentPara s2 = new studentPara("Jill", 1000, 1000, 200, 50);
            Console.WriteLine(s2.sname);
            Console.WriteLine(s2.matricMarks);
            Console.WriteLine(s2.fscMarks);
            Console.WriteLine(s2.ecatMarks);
            Console.WriteLine(s2.aggregate);
            Console.Read();
        }
        static void Task9()
        {
            student s1 = new student();
            s1.sname = "Jack";
            student s2 = new student(s1);
            Console.WriteLine(s1.sname);
            Console.WriteLine(s2.sname);
            Console.ReadKey();
        }
        static void Task10()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i =0; i<numbers.Count();i++)   // For Loop
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();
            foreach (int i in numbers)   // Foreach Loop
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            foreach (var i in numbers)   // Foreach Loop
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
