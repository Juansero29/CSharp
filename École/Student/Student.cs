using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUT
{
    abstract class Student : Person
    { 
        private static Random random = new Random();
        protected int max { get; set; } //Field
        protected int min { get; set; } //Field
        public int grade
        {
            get
            {
                int g = random.Next(min, max + 1);
                return g;
            }
            set { }
        }
        public Student(string firstname, string lastName) : base(lastName, firstname) //Constructor
        {
        }

        public abstract void Works();

        public virtual string DoYouWork()
        {
            string answer;
            if (grade <= 5)
            {
                answer = "A little...";
                return answer + min + " " + max;
            }
            else if (grade <= 10)
            {
                answer = "A lot!";
                return answer + min + " " + max;
            }
            else if (grade <= 15)
            {
                answer = "With passion!";
                return answer+min+" "+max;
            }
            else
            {
                answer = "I'm crazy about it!";
                return answer + min + " " + max;
            }
        }
    }
}
