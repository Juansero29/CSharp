using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUT
{
    class Lazy : Student
    {
        private static Random random = new Random();
        public Lazy(string firstname, string lastName) : base(firstname, lastName)
        {
            min = 0;
            max = 0;
        }

        public override void Works()
        {
            int g = random.Next(0, 2);
            if (g == 1)
            {
                min++;
                max++;
            }
        }
    }
}
