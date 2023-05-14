using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_5_UAMS.BL
{
    class DegreeProgram
    {
        public List<Subject> Subjects;
        public string name;
        public int duration;
        public int seats;
        public DegreeProgram()
        {

        }
        public DegreeProgram(string name, int duration, int seats)
        {
            this.name = name;
            this.duration = duration;
            this.seats = seats;
            Subjects = new List<Subject>();
        }
        public bool isSubjectExists(Subject sub)
        {
            foreach (Subject s in Subjects)
            {
                if (s.code == sub.code)
                {
                    return true;
                }
            }
            return false;
        }
        public int calculateCreditHour()
        {
            int count = 0;
            for (int x = 0; x < Subjects.Count; x++)
            {
                count = count + Subjects[x].creditHours;
            }
            return count;
        }
        public bool addSubject(Subject s)
        {
            int checkCR = calculateCreditHour();

            if (checkCR + s.creditHours <= 20)
            {
                Subjects.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
