using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_5_Sorting.BL
{
    class Student
    {
        public string name;
        public int rollNumber;
        public int ecatMarks;
        public Student(string name, int rollNumber, int ecatMarks)
        {
            this.name = name;
            this.rollNumber = rollNumber;
            this.ecatMarks = ecatMarks;
        }
    }
}
