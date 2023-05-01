using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_3_ClockType2.BL;

namespace WEEK_3_ClockType2
{
    class Program
    {
        static void Main(string[] args)
        {
            //      Elapse Time

            clockType fullTime = new clockType(23, 9, 59);
            Console.Write("Full Time: ");
            fullTime.timeP();
            Console.WriteLine();
            int result = fullTime.sec();
            int elapseT = result - 0;

            Console.WriteLine();
            Console.WriteLine("Elapse Time In Seconds = " + elapseT + "s");
            Console.Write("Elapse Time In Hours : Minutes : Seconds = ");
            calculate(elapseT);

            //         Remaining Time

            int result1 = fullTime.sec();
            int hours = 24 * 3600;
            int remainingT = hours - result1;

            Console.WriteLine();
            Console.WriteLine("Remaining Time In Seconds = " + remainingT + "s");
            Console.Write("Remaining Time In Hours : Minutes : Seconds = ");
            calculate(remainingT);

            //         Diffenrence in Time     

            Console.WriteLine();
            clockType time1 = new clockType(23, 9, 59);
            Console.Write("Full Time: ");
            time1.timeP();

            Console.WriteLine();

            clockType time2 = new clockType(9, 9, 0);
            Console.Write("Full Time: ");
            time2.timeP();
            Console.WriteLine();
            int result2 = time1.sec();
            int result3 = time2.sec();
            int finalResult = result2 - result3;

            Console.WriteLine();
            Console.WriteLine("Difference Time In Seconds = " + finalResult + "s");
            Console.Write("Difference Time In Hours : Minutes : Seconds = ");
            calculate(finalResult);

            Console.ReadKey();
        }
        static void calculate(int finalResult)
        {
            int temp = finalResult % 3600;
            int resultH = finalResult / 3600;
            int resultM = temp / 60;
            int resultS = temp % 60;

            Console.WriteLine(resultH + ":" + resultM + ":" + resultS);
            if (finalResult <= 0)
            {
                finalResult = finalResult * -1;
                resultH = resultH * -1;
                resultM = resultM * -1;
                resultS = resultS * -1;
            }
        }
    }
}
