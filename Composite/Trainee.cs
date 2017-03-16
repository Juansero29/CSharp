using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Trainee : Employee
    {
        public Trainee(string name) : base(name)
        {
        }

        public override void Works(String tab = "\t") {
            Console.WriteLine($"{tab}My name is {name} and I start working now...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"{tab}My name is {name} and I have finished my work.");
        }
    }
}
