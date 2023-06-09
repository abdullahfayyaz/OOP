using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_7_Challenge_1.BL;

namespace WEEK_7_Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            FireTruck t = new FireTruck();
            Ladder l = new Ladder();
            l.colour = "red";
            HosePipe h = new HosePipe();
            h.diameter = 12.4F;
            t.setPipe(h);
        }
    }
}
