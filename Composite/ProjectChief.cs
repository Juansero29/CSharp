using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class ProjectChief : Employee
    {
        Employee[] slaves;

        public ProjectChief(string name, params Employee[] slaves) : base(name)
        {
            this.slaves = slaves;
        }

        public override void  Works(String tab = "\t")
        {
            StringBuilder sb = new StringBuilder(tab);
            Console.WriteLine($"{sb}My name is {name} and I delegate my work to my slaves");
            sb.Append(tab);
            foreach (Employee slave in slaves) {
                slave.Works(sb.ToString());
            }
            Console.WriteLine($"{sb.Remove(0,1)}My name is {name} and I (well... my slaves) have finished working.");
        }
        
    }
}
