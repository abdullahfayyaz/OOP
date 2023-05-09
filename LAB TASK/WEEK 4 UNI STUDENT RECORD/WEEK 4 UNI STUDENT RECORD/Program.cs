using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_4_UNI_STUDENT_RECORD.BL;

namespace WEEK_4_UNI_STUDENT_RECORD
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>();
            Student s = new Student();
            int option = 0;
            float merit = 0.0F;
            do
            {
                option = menu();
                if (option == 1)
                {
                    Console.Clear();
                    addStudent(student);
                }
                else if (option == 2)
                {
                    Console.Clear();
                    displayStudent(student);
                }
                else if (option == 3)
                {
                    Console.Clear();
                    displayMerit(student);
                }
                else if (option == 4)
                {
                    Console.Clear();
                    scholarshipStatus(student, merit);
                }
                Console.ReadKey();
            }
            while (option != 5);
        }
        static int menu()
        {
            Console.Clear();
            Console.WriteLine("1- Add Student");
            Console.WriteLine("2- Student Info");
            Console.WriteLine("3- Calculate Merit");
            Console.WriteLine("4- Scholarship Status");
            Console.Write("Enter Option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        static void addStudent(List<Student> student)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Roll Number: ");
            int rollNo = int.Parse(Console.ReadLine());
            Console.Write("Enter CGPA: ");
            float cgpa = float.Parse(Console.ReadLine());
            Console.Write("Enter Fsc Marks: ");
            float fscMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Matric Marks: ");
            float matricMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Ecat Marks: ");
            float ecatMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Home Town: ");
            string homeTown = Console.ReadLine();
            Console.Write("Day Scholar or Hostelite: Enter (d or h): ");
            string h = Console.ReadLine();
            bool check = isHostelite(h);
            Student s = new Student(name, rollNo, cgpa, matricMarks, fscMarks, ecatMarks, homeTown, check);
            student.Add(s);
        }
        static void displayMerit(List<Student> student)
        {
            float merit = 0;
            foreach (Student s in student)
            {
                merit = s.calculateMerit();
                Console.WriteLine("Name of Student is: " + s.name);
                Console.WriteLine("Merit is: " + merit);
            }
        }
        static bool isHostelite(string hostelite)
        {
            bool check = false;
            if (hostelite == "h")
            {
                check = true;
            }
            else if (hostelite == "d")
            {
                check = false;
            }
            return check;
        }
        static void displayStudent(List<Student> student)
        {
            Student s = new Student();
            for (int x = 0; x < student.Count(); x++)
            {
                s = student[x];
                Console.WriteLine("Name: " + s.name);
                Console.WriteLine("Roll Number: " + s.rollNumber);
                Console.WriteLine("CGPA: " + s.cgpa);
                Console.WriteLine("Matric Marks: " + s.matricMarks);
                Console.WriteLine("Fsc Marks: " + s.fscMarks);
                Console.WriteLine("Ecat Marks: " + s.ecatMarks);
                Console.WriteLine("Home Town: " + s.homeTown);
                Console.WriteLine("Hostelite: " + s.isHostelite);
            }
        }
        static void scholarshipStatus(List<Student> student, float merit)
        {
            bool isEligible;
            string status = "";
            foreach (Student s in student)
            {
                isEligible = s.isEligibleForScholarship(merit);
                Console.WriteLine("Name of Student is: " + s.name);
                if (isEligible == true)
                {
                    status = "Eligible";
                }
                else if (isEligible == false)
                {
                    status = "Not Eligible";
                }
                Console.WriteLine("Scholarship Status: " + status);
            }
        }
    }
}
