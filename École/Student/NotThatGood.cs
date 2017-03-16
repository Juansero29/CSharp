using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUT
{
    class NotThatGood : Student
    {
        public NotThatGood(string firstname, string lastName) : base(firstname, lastName) //Constructor
        {
            min = 0;
            max = 4;
        }
        public override string DoYouWork()
        {
            string answer = "Yeah, but I don't do that good...";
            return answer + min + " " + max;
        }

        public override void Works()
        {
            if (max < 20)
            {
                if (min + max % 2 == 0)
                {
                    min++;
                }
                else
                {
                    max++;
                }
            }
        }
    }
}
