using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_8_PROBLEM_3.BL;

namespace WEEK_8_PROBLEM_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();
            Cat c = new Cat("Simba");
            Cat c2 = new Cat("Lucy");
            Dog d = new Dog("Jenny");
            Dog d2 = new Dog("Tommy");
            list.Add(c);
            list.Add(c2);
            list.Add(d);
            list.Add(d2);
            foreach(Animal a in list)
            {
                Console.WriteLine(a.toString());
                a.greets();
                a.greets(d);
            }
            Console.ReadKey();
        }
    }
}
