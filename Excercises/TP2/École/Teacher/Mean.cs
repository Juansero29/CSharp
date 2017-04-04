using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUT
{
    class Mean : Teacher
    {
        public Mean(string firstname, string lastName) : base(firstname, lastName)
        {
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
                if (grades[i] > 0) { }
                grades[i] -= 1;
            }

            return grades;
        }
    }
}
