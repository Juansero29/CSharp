using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUT
{
    class Crawler : Good, ICoffee
    {
        public Crawler(string firstName, string lastName) : base(firstName, lastName) {
        }

        public string DoyouWork() {
            return "For sure dear!";
        }

        public string prepareCoffee() {
            return $"Here's a coffee and don't forget it came from {name} {lastName}";
        }
    }
}
