using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUT
{
    class Trickster : Student, ICoffee
    {
        public Trickster(string firstName, string lastName) : base(firstName, lastName){
        }
        public override void Works()
        {
            min++;
            max++;
        }
        public override string DoYouWork() {
            return "With pleasure!";
        }
        public string prepareCoffee() {
            return $"Here's a good coffee! Don't forget it came from {name} {lastName}";
        }
        public void Cheat() {
            Console.WriteLine($"\n{name} {lastName} has cheated.\n");
            min = min * 2;
            max = max * 2;
        }

    }
}
