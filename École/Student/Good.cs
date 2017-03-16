using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUT
{
    class Good : Student
    {
        public Good(string firstname, string lastName) : base(firstname, lastName)
        {
            min = 8;
            max = 12;
        }
        public new string DoYouWork()
        {
            string answer = "Yep!";
            return answer + min + " " + max;
        }

        public override void Works()
        {
            if (max < 20)
            {
                max++;
                min++;
                max++;
                min++;
            }
        }
    }
}
