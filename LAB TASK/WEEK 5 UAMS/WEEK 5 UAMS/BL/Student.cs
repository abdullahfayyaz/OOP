using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_5_UAMS.BL
{
    class Student
    {
        public string name;
        public int age;
        public float fscM;
        public float ecatM;
        public float merit;
        public List<DegreeProgram> preferences;
        public DegreeProgram regDegree;
        public List<Subject> regSubject;
        public Student()
        {

        }
        public Student(string name, int age, float fscM, float ecatM, List<DegreeProgram> preferences)
        {
            this.name = name;
            this.age = age;
            this.fscM = fscM;
            this.ecatM = ecatM;
            this.preferences = preferences;

        }
        public void generateMerit()
        {
            this.merit = (((fscM / 1100) * 0.4F) + ((ecatM / 400) * 0.55F)) * 100;
        }
        public bool redStudentSubject(Subject s)
        {
            int subCH = getCHR();
            if (regDegree != null && regDegree.isSubjectExists(s) && subCH + s.creditHours <= 9)
            {
                regSubject.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int getCHR()
        {
            int count = 0;
            foreach (Subject sub in regSubject)
            {
                count = count + sub.creditHours;
            }
            return count;
        }
        public float calfees()
        {
            float fee = 0;
            if (regDegree != null)
            {
                foreach (Subject sub in regSubject)
                {
                    fee = fee + sub.subjectFee;
                }
            }
            return fee;
        }
    }
}
