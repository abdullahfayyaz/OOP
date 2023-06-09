using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_5_UAMS.BL;

namespace WEEK_5_UAMS.UI
{
    class SubjectUI
    {
        public static Subject takeInputForSubjec()
        {
            Console.Write("Enter Subject Code : ");
            string code = Console.ReadLine();
            Console.Write("Enter Subject Type : ");
            string type = Console.ReadLine();
            Console.Write("Enter Subject Credit Hours : ");
            int creditHours = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject Fees : ");
            int subjectFees = int.Parse(Console.ReadLine());
            Subject sub = new Subject(code, type, creditHours, subjectFees);
            return sub;
        }
        public static void viewSubjects(Student s)
        {
            if (s.regDegree != null)
            {
                Console.WriteLine("Sub Code\tSub Type");
                foreach (Subject sub in s.regDegree.subjects)
                {
                    Console.WriteLine(sub.code + "\t\t" + sub.type);
                }
            }
        }
        public static void registerSubjects(Student s)
        {
            Console.Write("Enter how many subjects you want to register: ");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                Console.Write("Enter the subject Code: ");
                string code = Console.ReadLine();
                bool Flag = false;
                foreach (Subject sub in s.regDegree.subjects)
                {
                    if (code == sub.code && !(s.regSubject.Contains(sub)))
                    {

                        if (s.regStudentSubject(sub))
                        {
                            Flag = true;
                            break;

                        }
                        else
                        {
                            Console.WriteLine("A student cannot have more than 9 CH");
                            Flag = true;
                            break;
                        }
                    }
                }
                if (Flag == false)
                {
                    Console.WriteLine("Enter Valid Course");
                    x--;
                }
            }
        }
    }
}
