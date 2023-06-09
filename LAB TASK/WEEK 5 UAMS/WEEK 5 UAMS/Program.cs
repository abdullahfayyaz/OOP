using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_5_UAMS.BL;
using WEEK_5_UAMS.degreeProgramDL;
using WEEK_5_UAMS.UI;

namespace WEEK_5_UAMS
{
    class Program
    {
        static void Main(string[] args)
        {
            string subjectPath = "C:\\Users\\HP\\Documents\\STUDY\\2nd Semester\\OOP TASK\\LAB TASK\\WEEK 5 UAMS\\subject.txt";
            string degreePath = "C:\\Users\\HP\\Documents\\STUDY\\2nd Semester\\OOP TASK\\LAB TASK\\WEEK 5 UAMS\\degree.txt";
            string studentPath = "C:\\Users\\HP\\Documents\\STUDY\\2nd Semester\\OOP TASK\\LAB TASK\\WEEK 5 UAMS\\student.txt";
            if (SubjectDL.readFromFile(subjectPath))
            {
                Console.WriteLine("Subject Data Loaded Successfully");
            }
            if (DegreeProgramDL.readFromFile(degreePath))
            {
                Console.WriteLine("DegreeProgram Data Loaded Successfully");
            }
            if (StudentDL.readFromFile(studentPath))
            {
                Console.WriteLine("Student Data Loaded Successfully");
            }
            string option = "";
            do
            {
                option = MenuUI.menu();
                if (option == "1")
                {
                    if (DegreeProgramDL.programList.Count > 0)
                    {
                        Student s = StudentUI.takeInputForStudent();
                        StudentDL.addIntoStudentList(s);
                        StudentDL.storeIntoFile(studentPath, s);
                    }
                }
                else if (option == "2")
                {
                    DegreeProgram d = DegreeProgramUI.takeInputForDegree();
                    DegreeProgramDL.addIntoDegreeList(d);
                    DegreeProgramDL.storeIntoFile(degreePath, d);
                }
                else if (option == "3")
                {
                    List<Student> sortedStudentList = new List<Student>();
                    sortedStudentList = StudentDL.sortStudentByMerit();
                    StudentDL.giveAdmission(sortedStudentList);
                    StudentUI.printStudents();
                }
                else if (option == "4")
                {
                    StudentUI.viewRegsiteredStudents();
                }
                else if (option == "5")
                {
                    string degName;
                    Console.Write("Enter Degree Name: ");
                    degName = Console.ReadLine();
                    StudentUI.viewStudentInDegree(degName);
                }
                else if (option == "6")
                {
                    Console.Write("Enter the Student Name: ");
                    string name = Console.ReadLine();
                    Student s = StudentDL.StudentPresent(name);
                    if (s != null)
                    {
                        SubjectUI.viewSubjects(s);
                        SubjectUI.registerSubjects(s);
                    }
                }
                else if (option == "7")
                {
                    StudentUI.calculateFeeForAll();
                }
                MenuUI.clearScreen();
            }
            while (option != "8");
        }
    }
}
