using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUT
{
    class Cool : Teacher, ICoffee
    {
        public Cool(string firstname, string lastName) : base(firstname, lastName)
        {
        }
        public string prepareCoffee()
        {
            return $"Here's a coffee from your partner {name} {lastName}";
        }

        public override int[] Grade(Student[] studentsArray)
        {
            int[] grades = new int[studentsArray.Length];
            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = studentsArray[i].grade;
            }

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] < 20) {
                    grades[i] += 1;
                }
            }

            return grades;
        }
    }
}
