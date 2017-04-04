using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUT
{
    class Cheater : Student, ICheater
    {
        public Cheater(string firstname, string lastname) : base(firstname, lastname)
        {
        }

        public void Cheat()
        {
            min = 15;
            max = 15;
        }
        public override void Works()
        {
        }
    }
}
