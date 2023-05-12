using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_5_Sorting.BL;

namespace WEEK_5_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            //selfAssessment1a();
            selfAssessment1b();
        }
        static void selfAssessment1a()
        {
            List<string> name = new List<string>() { "Abdullah", "Bilal", "Ali", "Maryam", "Kanza", "Noor", "Danish" };
            name.Sort();
            foreach (string n in name)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            List<float> number = new List<float>() { 35.4F, 1.3F, 2.5F, 6.7F, 2.2F, 1.1F, 45.54F };
            number.Sort();
            foreach (float n in number)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
        static void selfAssessment1b()
        {
            Student s1 = new Student("Ahmad", 15, 120);
            Student s2 = new Student("Hassan", 11, 115);
            Student s3 = new Student("Ali", 13, 250);
            List<Student> student = new List<Student>() { s1, s2, s3 };
            List<Student> sortedList = student.OrderByDescending(o => o.rollNumber).ToList();
            Console.WriteLine("Name \t Roll No \t Ecat Marks");
            foreach (Student s in sortedList)
            {
                Console.WriteLine("{0} \t {1} \t\t {2}", s.name, s.rollNumber, s.ecatMarks);
            }
            Console.ReadKey();
        }
    }
}
