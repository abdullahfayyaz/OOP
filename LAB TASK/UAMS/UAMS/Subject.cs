using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class Subject
    {
        public string SubjectCode;
        public string SubjectType;
        public int CreditHours;
        public int SubjectFees;
        public List<Subject> Subjects;
        public Subject()
        {

        }
        public Subject(string SubjectCode, string SubjectType,int CreditHours,int SubjectFees)
        {
            this.SubjectCode = SubjectCode;
            this.SubjectType = SubjectType;
            this.CreditHours = CreditHours;
            this.SubjectFees = SubjectFees;
        }
        public Subject(List<Subject> Subjects,int CreditHours)
        {
            this.Subjects = Subjects;
            this.CreditHours = CreditHours;
        }
        
    }
}
