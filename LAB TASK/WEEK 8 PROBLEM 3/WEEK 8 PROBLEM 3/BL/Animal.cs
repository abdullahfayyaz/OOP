using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_8_PROBLEM_3.BL
{
    class Animal
    {
        protected string name;
        public Animal(string name)
        {
            this.name = name;
        }
        public virtual string toString()
        {
            return "Animal: " + name;
        }
        public virtual void greets()
        {
            Console.WriteLine("Greets");
        }
        public virtual void greets(Dog another)
        {
            Console.WriteLine("Woooof");
        }
    }
}
