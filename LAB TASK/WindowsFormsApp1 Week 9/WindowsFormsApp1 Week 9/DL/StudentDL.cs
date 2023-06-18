using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1_Week_9.BL;

namespace WindowsFormsApp1_Week_9.DL
{
    class StudentDL
    {
        private static List<Student> studentList = new List<Student>();
        public static void LoadDummyData()
        {
            Student s1 = new Student();
            s1.name = "Abdullah";
            s1.fatherName = "Fayyaz";
            s1.marks = 1060;
            studentList.Add(s1);
            Student s2 = new Student();
            s2.name = "Ali";
            s2.fatherName = "Tariq";
            s2.marks = 1050;
            studentList.Add(s2);
            Student s3 = new Student();
            s3.name = "Maryam";
            s3.fatherName = "Mueen";
            s3.marks = 1070;
            studentList.Add(s3);
        }
        public static void addStudent(Student student)
        {
            studentList.Add(student);
        }
        public static List<Student> getStudent()
        {
            return studentList;
        }
    }
}
