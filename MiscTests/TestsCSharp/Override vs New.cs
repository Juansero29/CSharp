using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTS
{
    class Base
    {
        public virtual void WhoIAm()
        {
            Console.WriteLine("WhoIAm() : I'm the base method.");
        }

        public virtual void WhoIAm2()
        {
            Console.WriteLine("WhoIAm2() : I'm the base method.");
        }
    }

    class Derived : Base
    {
        public override void WhoIAm()
        {
            Console.WriteLine("WhoIAm() : I'm the derived method.");
        }

        public new void WhoIAm2()
        {
            Console.WriteLine("WhoIAm2() : I'm the derived method.");
        }


    }
}
