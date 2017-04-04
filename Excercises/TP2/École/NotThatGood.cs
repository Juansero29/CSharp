using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUT
{
    class NotThatGood : Student
    {
        public NotThatGood(string firstname, string lastName) : base(lastName, firstname) //Constructor
        {
            min = 0;
            max = 4;
        }
        public new string DoYouWork()
        {
            string answer = "Yeah, but I don't do that good...";
            return answer;
        }

        public new void Works()
        {
            if(min+max%2==0)
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
