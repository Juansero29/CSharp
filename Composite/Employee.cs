using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    abstract class Employee
    {
        public string name { get; set; }

        public Employee(string name) {
            this.name = name;
        }
        public abstract void Works(String tab = "\t");
    }
}
