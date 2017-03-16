using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUT
{
    class Teacher : Person
    {

        public Teacher(string firstname, string lastName) : base(lastName, firstname) { }
        public void Motivate(Student[] studentsArray)
        {
            foreach (Student s in studentsArray)
            {
                s.Works();
            }
        }

        public int[] Grade(Student[] studentsArray)
        {
            int[] grades = new int[studentsArray.Length];
            //Random rand = new Random();
            for(int i=0; i<grades.Length; i++)
            {
                grades[i] = studentsArray[i].grade;
            }

            return grades;
        }
    }
}
