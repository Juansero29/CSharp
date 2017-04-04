using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUT
{
    public class Person

    {
        public string lastName { get; set; }
        public string name { get; set; }
        public Person(string lastName, string name)
        {
            this.lastName = lastName;
            this.name = name;
        }
    }
}
