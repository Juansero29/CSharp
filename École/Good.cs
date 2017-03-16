using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUT
{
    class Good : Student
    {
        public Good(string firstname, string lastName) : base(lastName, firstname)
        {
            min = 8;
            max = 12;
        }
        public new string DoYouWork()
        {
            string answer = "Yep!";
            return answer;
        }

        public new void Works()
        {
            base.Works();
            base.Works();
        }
    }
}
