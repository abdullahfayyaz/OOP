using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class Student
    {
        public string Name;
        public int Age;
        public float FSC;
        public float ECAT;
        public List<Student> Preferences;
        public string Preference;
        public Student()
        {

        }
        public Student(string Name,int Age, float FSC,float ECAT,List<Student>Preferences)
        {
            this.Name = Name;
            this.Age = Age;
            this.FSC = FSC;
            this.ECAT = ECAT;
            this.Preferences = Preferences;
        }
        public Student(string Preference)
        {
            this.Preference = Preference;
        }
    }
}