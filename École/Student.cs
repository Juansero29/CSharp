using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUT
{
    class Student : Person
    {
        private static Random random = new Random();
        public int max { get; set; } //Field
        public int min { get; set; } //Field
        public int grade
        {
            get
            {
                int g = random.Next(min, max+1);
                Debug.WriteLine($"{name} min: {min}, max: {max}, grade: {g}");
                return g;
            }
        }
        public Student(string firstname, string lastName) : base(lastName, firstname)
        {
        }

        public void Works()
        {
            max ++;
            min ++;
        }

        public string DoYouWork()
        {
            string answer;
            if (grade <= 5)
            {
                answer = "A little...";
                return answer;
            }
            if (grade <= 10)
            {
                answer = "A lot!";
                return answer;
            }
            if (grade <= 15)
            {
                answer = "With passion!";
                return answer;
            }
            if (grade > 15)
            {
                answer = "I'm crazy about it!";
                return answer;
            }
            return answer = "You're nobody to ask me that!";
        }
    }
}
