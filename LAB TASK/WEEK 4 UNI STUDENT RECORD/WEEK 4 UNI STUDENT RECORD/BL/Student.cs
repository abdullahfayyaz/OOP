using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_4_UNI_STUDENT_RECORD.BL
{
    class Student
    {
        public string name;
        public int rollNumber;
        public float cgpa;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public string homeTown;
        public bool isHostelite;
        public bool isTakingScholarship;
        public float merit;
        public Student()
        {

        }
        public Student(string name, int rollNumber, float cgpa, float matricMarks, float fscMarks, float ecatMarks, string homeTown, bool isHostelite)
        {
            this.name = name;
            this.rollNumber = rollNumber;
            this.cgpa = cgpa;
            this.matricMarks = matricMarks;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.homeTown = homeTown;
            this.isHostelite = isHostelite;
        }
        public float calculateMerit()
        {
            Student s = new Student();
            float fsc = (fscMarks / 1100.0f ) * 100.0F;
            float ecat = (ecatMarks / 400.0f) * 100.0F;
            merit = (fsc * 0.6F) + (ecat * 0.4F);
            return merit;
        }
        public bool isEligibleForScholarship(float meritPercentage)
        {
            bool check;
            if (meritPercentage > 80 && isHostelite == true)
            {
                isTakingScholarship = true;
                check = true;
            }
            else
            {
                isTakingScholarship = false;
                check = false;
            }
            return check;
        }
    }
}
