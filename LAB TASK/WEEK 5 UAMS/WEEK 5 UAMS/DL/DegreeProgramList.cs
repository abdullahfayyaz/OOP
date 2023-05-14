using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_5_UAMS.BL;

namespace WEEK_5_UAMS.DL
{
    class DegreeProgramList
    {
        public static List<DegreeProgram> program = new List<DegreeProgram>();

        public static void addProgramsIntoList(DegreeProgram s)
        {
            program.Add(s);
        }
        public static void viewDegreeProgram()
        {
            foreach (DegreeProgram d in program)
            {
                Console.WriteLine(d.name);
            }
        }
    }
}
