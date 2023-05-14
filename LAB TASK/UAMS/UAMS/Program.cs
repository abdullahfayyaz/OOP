using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Running = true;
            Layout Display = new Layout();
            List<Student> Student = new List<Student>();
            List<Degree> Degree = new List<Degree>();
            List<Subject> Subject = new List<Subject>();
            while(Running)
            {
                string Choice = Display.MainMenu();
                if(Choice == "1")
                {
                    Student.Add(Display.AddStudent(Degree));
                }
                else if(Choice == "2")
                {
                    Display.AddDegreeProgram(Degree,Subject);
                }
                else if(Choice == "3")
                {
                    Display.GenerateMerit(Student);
                }
                else if(Choice == "4")
                {
                    Display.RegisteredStudents(Student);
                }
                else if(Choice == "5")
                {
                    Display.SpecificProgram(Student);
                }
                else if(Choice == "6")
                {
                    Display.RegisterSubject(Student,Subject);
                }
                else if(Choice == "7")
                {
                    Display.GenerateFees(Student,Subject);
                }
                else if(Choice == "8")
                {
                    Running = Display.Exit(Running);
                }
                else
                {
                    Display.Invalid();
                }    
            }
        }
    }
}
