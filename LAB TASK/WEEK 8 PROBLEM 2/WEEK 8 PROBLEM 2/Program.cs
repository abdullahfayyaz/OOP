using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_8_PROBLEM_2.BL;

namespace WEEK_8_PROBLEM_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student("Abdullah", "Wahdat Road", "BSCS", 2022, 77700);
            Student std2 = new Student();
            std2.setName("Bilal");
            std2.setAddress("Shadbagh");
            std2.setProgram("BSCS");
            std2.setYear(2022);
            std2.setFee(77700);

            Staff s = new Staff("Ali", "Walton", "LGS", 80000);
            Staff s2 = new Staff();
            s2.setName("Maryam");
            s2.setAddress("Muslim Town");
            s2.setSchool("APS");
            s2.setPay(90000);

            Console.WriteLine(std.toString());
            Console.WriteLine(std2.toString());

            Console.WriteLine(s.toString());
            Console.WriteLine(s2.toString());

            Console.ReadKey();
        }
    }
}
