using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTS
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            OverridevsNew();
        }

        static void OverridevsNew()
        {
            Base b = new Base();
            Derived d = new Derived();
            Base bd = new Derived();
            b.WhoIAm();
            b.WhoIAm2();
            d.WhoIAm();
            d.WhoIAm2();
            bd.WhoIAm();
            bd.WhoIAm2();
        }
    }
}
