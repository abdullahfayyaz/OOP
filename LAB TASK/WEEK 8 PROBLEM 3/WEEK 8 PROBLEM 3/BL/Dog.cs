using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_8_PROBLEM_3.BL
{
    class Dog : Mammal
    {
        public Dog(string name) : base(name)
        {

        }
        public override void greets()
        {
            Console.WriteLine("Woof");
        }
        public override void greets(Dog another)
        {
            Console.WriteLine("Woooof");
            Console.WriteLine();
        }
        public override string toString()
        {
            return "Dog Name: " + name;
        }
    }
}
