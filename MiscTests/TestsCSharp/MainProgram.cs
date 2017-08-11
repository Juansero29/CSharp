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
            Base brd = new Rederived();
            Derived drd = new Rederived();
            Rederived rd = new Rederived();

            b.WhoIAm();
            b.WhoIAm2();
            d.WhoIAm();
            d.WhoIAm2();
            bd.WhoIAm();

            /* Behavior changes only with the new keyword on a 
             * method that has the same name that the one on the
             * base class. 
             */
            bd.WhoIAm2(); // Behavior changes with this call. Base method gets called.

            brd.WhoIAm2(); // Base method gets called.
            drd.WhoIAm2(); // Derived method gets called.
            rd.WhoIAm2(); // Rederived method gets called.


            /* - With 'virtual/override' we call the dynamic type 
             * of the object's instance: type at the right of the
             * declaration.
             * 
             * - With 'new' we call the static type of the object's
             * instance: type at the left of the declaration.
             */

        }
    }
}
