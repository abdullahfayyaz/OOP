using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_8_PROBLEM_3.BL
{
    class Cat : Mammal
    {
        public Cat(string name) : base(name)
        {

        }
        public override void greets()
        {
            Console.WriteLine("Meow");
        }
        public override string toString()
        {
            return "Cat Name: " + name;
        }
    }
}
