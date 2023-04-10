using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_2_Student_Management_System
{
    class Program
    {
        class students
        {
            public string name;
            public int roll_no;
            public float cgpa;
            public char isHostelide;
            public string department;
        }
        static void Main(string[] args)
        {
            students[] s = new students[10];
            char option;
            int count = 0;
            do
            {
                option = menu();
                if (option == '1')
                {
                    s[count] = addStudent();
                    count = count + 1;
                }
                else if (option == '2')
                {
                    viewStudent(s, count);
                }
                else if (option == '3')
                {
                    topStudent(s, count);
                }
                else if (option == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
            while (option != 4);
            Console.WriteLine("Press Enter to Exit.. ");
            Console.Read();
        }
        static char menu()
        {
            Console.Clear();
            char choice;
            Console.WriteLine("Press 1 for Adding a Student: ");
            Console.WriteLine("Press 2 for View a Student: ");
            Console.WriteLine("Press 3 for Top three students: ");
            Console.WriteLine("Press 4 to exit: ");
            choice = char.Parse(Console.ReadLine());
            return choice;
        }
        static students addStudent()
        {
            Console.Clear();
            students s1 = new students();
            Console.WriteLine("Enter Name: ");
            s1.name = Console.ReadLine();
            Console.WriteLine("Enter Roll No: ");
            s1.roll_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter CGPA: ");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Department: ");
            s1.department = Console.ReadLine();
            Console.WriteLine("Is Hostelide (y || n): ");
            s1.isHostelide = char.Parse(Console.ReadLine());
            return s1;
        }
        static void viewStudent(students[] s, int count)
        {
            Console.Clear();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Name: {0} Roll No: {1} CGPA: {2} Department: {3} IsHostelide: {4}", s[i].name, s[i].roll_no, s[i].cgpa, s[i].department, s[i].isHostelide);
            }
            Console.WriteLine("Press any key to contniue... ");
            Console.ReadKey();
        }
        static void topStudent(students[] s, int count)
        {
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("No Record Present");
            }
            else if (count == 1)
            {
                viewStudent(s, 1);
            }
            else if (count == 2)
            {
                for (int x = 0; x < 2; x++)
                {
                    int index = largest(s, x, count);
                    students temp = s[index];
                    s[index] = s[x];
                    s[x] = temp;
                }
                viewStudent(s, 2);
            }
            else
            {
                for (int x = 0; x < 3; x++)
                {
                    int index = largest(s, x, count);
                    students temp = s[index];
                    s[index] = s[x];
                    s[x] = temp;
                }
                viewStudent(s, 3);
            }
        }
        static int largest(students[] s, int start, int end)
        {
            int index = start;
            float large = s[start].cgpa;
            for (int x = start; x < end; x++)
            {
                if (large < s[x].cgpa)
                {
                    large = s[x].cgpa;
                    index = x;
                }
            }
            return index;
        }
    }
}
