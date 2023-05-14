using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_5_UAMS.DL
{
    class SubjectList
    {
        static List<SubjectList> subjects = new List<SubjectList>();

        public static void setSubjectIntoList(SubjectList s)
        {
            subjects.Add(s);
        }
    }
}
