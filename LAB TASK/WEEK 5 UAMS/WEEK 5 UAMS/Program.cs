using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_5_UAMS.BL;
using WEEK_5_UAMS.DL;
using WEEK_5_UAMS.UI;

namespace WEEK_5_UAMS
{
    class Program
    {
        static void Main(string[] args)
        {
            MUserCRUD.clearScreen();
            while (true)
            {
                string op = MUserCRUD.menu();
                if (op == "1")
                {
                    if (DegreeProgramList.program.Count > 0)
                    {
                        Student s = MUserCRUD.addStudent();
                        StudentList.addIntoStudentList(s);
                    }
                }
                else if (op == "2")
                {
                    DegreeProgram d = MUserCRUD.addProgram();
                    DegreeProgramList.addProgramsIntoList(d);
                }
                else if (op == "3")
                {
                    List<Student> sortedstudentlsit = new List<Student>();
                    sortedstudentlsit = StudentList.sortbymerit();
                    StudentList.giveadmission(sortedstudentlsit);
                    MUserCRUD.generateMeritView();
                }
                else if (op == "4")
                {
                    MUserCRUD.regsiteredView();
                }
                else if (op == "5")
                {
                    string degreename;
                    Console.Write("Enter Degree Name :");
                    degreename = Console.ReadLine();
                    MUserCRUD.ViewSelectedStudent(degreename);
                }
                else if (op == "6")
                {
                    Console.Write("Enter the Student Name : ");
                    string name = Console.ReadLine();
                    Student s = StudentList.studentPresent(name);
                    if (s != null)
                    {
                        MUserCRUD.viewsubject(s);
                        MUserCRUD.registerSubjects(s);
                    }
                }
                else if (op == "7")
                {
                    MUserCRUD.calculateFee();
                }
                else if (op == "8")
                {
                    Environment.Exit(0);
                }
            }
            MUserCRUD.clearScreen();
            Console.ReadLine();
        }
    }
}
