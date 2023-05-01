using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEKK_3.BL
{
    class student
    {
        public student()
        {
            Console.WriteLine("Default Constructor Called");
        }
        public student(student s)               // Copy Constructor 
        {
            sname = s.sname;
            matricMarks = s.matricMarks;
            fscMarks = s.fscMarks;
            ecatMarks = s.ecatMarks;
            aggregate = s.aggregate;
        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;
    }
    class Student
    {
        public Student()
        {
            Console.WriteLine("Default Constructor Called");
        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;
    }
    class STUDENT
    {
        public STUDENT()
        {
            sname = "Jill";
            matricMarks = 1100F;
            fscMarks = 1100F;
            ecatMarks = 400F;
            aggregate = 100F;
        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;
    }
    class studentP
    {
        public studentP(string n)
        {
            sname = n;
        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;
    }
    class studentPara
    {
        public studentPara(string n, float m, float f, float e, float a)
        {
            sname = n;
            matricMarks = m;
            fscMarks = f;
            ecatMarks = e;
            aggregate = a;
        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;
    }
}
