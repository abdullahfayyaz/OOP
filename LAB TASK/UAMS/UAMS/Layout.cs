using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace UAMS
{
    class Layout
    {
        public string MainMenu()
        {

            Console.Clear();
            Console.WriteLine("****************************************");
            Console.WriteLine("#                   UAMS               #");
            Console.WriteLine("****************************************");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate Merit");
            Console.WriteLine("4. View Registered Students");
            Console.WriteLine("5. View Student's Of A Specific Program");
            Console.WriteLine("6. Register Subjects For A Specific Student");
            Console.WriteLine("7. Calculate Fees For All Registered Students");
            Console.WriteLine("8. Exit");
            Console.WriteLine("");
            Console.Write("Enter Your Choice : ");
            string Choice = Console.ReadLine();
            return Choice;
        }
        public bool Exit(bool Running)
        {
            Console.Clear();
            Running = false;
            Console.Write("Ending All Processes ! ! ! Please Wait.......");
            Thread.Sleep(2000);
            return Running;
        }
        public void Invalid()
        {
            Console.Clear();
            Console.Write("! ! ! INVALID CHOICE ! ! !");
            Thread.Sleep(2000);
        }
        public Student AddStudent(List<Degree>Degree)
        {
            Console.Clear();
            List<Student> Preferences = new List<Student>();
            Console.Write("Enter Student's Name : ");
            string Name = Console.ReadLine();
            Console.Write("Enter Student's Age : ");
            int Age = int.Parse(Console.ReadLine());
            Console.Write("Enter Student's FSC Marks : ");
            float FSC = int.Parse(Console.ReadLine());
            Console.Write("Enter Student's ECAT Marks : ");
            float ECAT = int.Parse(Console.ReadLine());
            AvailableDegreePrograms(Degree);
            TakePreferences(Name, Preferences);
            Student StudentRecord = new Student(Name, Age, FSC, ECAT, Preferences);
            return StudentRecord;
        }
        public void AvailableDegreePrograms(List<Degree>Degree)
        {
            int i = 1;
            Console.WriteLine();
            Console.WriteLine("Available Programs");
            foreach(Degree Record in Degree)
            {
                Console.WriteLine(i + " " + Record.Name);
                i++;
            }
            Console.WriteLine();
        }
        public void TakePreferences(string Name, List<Student> Preferences)
        {
            Console.Write("Enter Number Of Preferences For " + Name + " : ");
            int Loop = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Loop; i++)
            {
                Console.Write("Enter Preference Number " + i + " : ");
                string Preference = Console.ReadLine();
                Student PreferenceRecord = new Student(Preference);
                Preferences.Add(PreferenceRecord);
            }
        }
        public void AddDegreeProgram(List<Degree> Degree,List<Subject> Subject)
        {
            Console.Clear();
            Degree.Add(AddDegree());
            Console.Write("Enter Number Of Subjects For The Degree : ");
            int Loop = int.Parse(Console.ReadLine());
            for (int i = 0; i < Loop; i++)
            {
                Subject.Add(AddSubject());
            }
        }
        public Degree AddDegree()
        {
            Console.Write("Enter Degree's Name : ");
            string Name = Console.ReadLine();
            Console.Write("Enter Degree's Duration : ");
            int Duration = int.Parse(Console.ReadLine());
            Console.Write("Enter Available Seats For " + Name + " : ");
            int Seats = int.Parse(Console.ReadLine());
            Degree DegreeRecord = new Degree(Name, Duration, Seats);
            return DegreeRecord;
        }
        public Subject AddSubject()
        {
            Console.Write("Enter Subject's Name : ");
            string SubjectCode = Console.ReadLine();
            Console.Write("Enter Subject's Type : ");
            string SubjectType = Console.ReadLine();
            Console.Write("Enter Subject's Credit Hours : ");
            int CreditHours = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject's Fees : ");
            int SubjectFees = int.Parse(Console.ReadLine());
            Subject SubjectRecord = new Subject(SubjectCode, SubjectType, CreditHours, SubjectFees);
            return SubjectRecord;
        }
        public void RegisteredStudents(List<Student>Student)
        {
            Console.Clear();
            Console.WriteLine("NAME     AGE     FSC     ECAT");
            foreach (Student Record in Student)
            {
                Console.WriteLine(Record.Name + "   |   " + Record.Age +"   |   " + Record.FSC +"   |   " + Record.ECAT);
            }
            Console.ReadKey();
        }
        public void GenerateMerit(List<Student>Student)
        {
            Console.Clear();
            foreach(Student Record in Student)
            {
                float Merit = ((Record.ECAT / 400) * 40) + ((Record.FSC /1100) * 60);
                foreach (Student Preference in Record.Preferences)
                {
                    if (Merit > 80)
                    {
                        Console.WriteLine(Record.Name + "Got Admission in " + Preference.Preference);
                    }
                }
            }
            Console.ReadKey();
        }
        public void SpecificProgram(List<Student>Student)
        {
            Console.Clear();
            Console.Write("Enter Degree Program To See The List Of Student's in That Specific Progarms : ");
            string DegreeName = Console.ReadLine();
            foreach(Student Record in Student)
            {
                foreach (Student Preference in Record.Preferences)
                {
                    if (DegreeName == Preference.Preference)
                    {
                        Console.WriteLine(Record.Name);
                    }
                }
            }
            Console.ReadKey();
        }
        public void RegisterSubject(List<Student>Student,List<Subject>Subject)
        {
            Console.Clear();
            int CreditHours = 0;
            bool Isvalid = false;
            List<Subject> Subjects = new List<Subject>();
            Console.Write("Enter Student Name : ");
            string Name = Console.ReadLine();
            foreach(Student Record in Student)
            {
                Isvalid = true;
                if(Record.Name == Name)
                {
                    if(CreditHours <= 20)
                    {
                        Console.Write("Enter Subject Code : ");
                        string Code = Console.ReadLine();
                        foreach(Subject SubjectRecord in Subject)
                        {
                            if(Code == SubjectRecord.SubjectCode)
                            {
                                CreditHours = CreditHours + SubjectRecord.CreditHours;
                                Subjects.Add(SubjectRecord);
                                Subject Records = new Subject(Subjects, CreditHours);
                            }
                        }
                    }
                    else
                    {
                        Console.Write("Maximum Credit Hour Limit Approached.");
                    }
                }
            }
            if(Isvalid == false)
            {
                Console.Clear();
                Console.Write("! ! ! INVALID STUDENT NAME ! ! !");
            }
            Console.ReadKey();
        }
        public void GenerateFees(List<Student>Student,List<Subject>Subject)
        {
            int Fees = 0;
            foreach(Student Record in Student)
            {
                foreach(Subject SubjectRecord in Subject)
                {
                    foreach(Subject Records in SubjectRecord.Subjects)
                    {
                        Fees = Fees + Records.SubjectFees;
                    }
                }
                Console.WriteLine(Record.Name + " " + Fees);
            }
            Console.ReadKey();
        }
    }
}