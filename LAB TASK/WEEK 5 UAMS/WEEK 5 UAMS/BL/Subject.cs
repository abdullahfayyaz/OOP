using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_5_UAMS.BL
{
    class Subject
    {
        public string code;
        public int creditHours;
        public string subjectType;
        public int subjectFee;
        public Subject()
        {

        }
        public Subject(string code, string subjectType, int creditHours, int subjectFee)
        {
            this.code = code;
            this.subjectType = subjectType;
            this.creditHours = creditHours;
            this.subjectFee = subjectFee;
        }
    }
}
