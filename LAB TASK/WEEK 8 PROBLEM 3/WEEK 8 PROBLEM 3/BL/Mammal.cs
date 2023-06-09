using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_8_PROBLEM_3.BL
{
    class Mammal : Animal
    {
        public Mammal(string name) : base(name)
        {
           
        }
        public override string toString()
        {
            return "Mamaml Name: " + name;
        }
        public override void greets()
        {
            Console.WriteLine("Greets");
        }
        public override void greets(Dog another)
        {
            Console.WriteLine("");
        }
    }
}
