using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUT
{
    abstract class Teacher : Person
    {

        public Teacher(string firstname, string lastName) : base(lastName, firstname) { }
        public void Motivate(Student[] studentsArray)
        {
            foreach (Student s in studentsArray)
            {
                s.Works();
            }
        }

        public virtual int[] Grade(Student[] studentsArray)
        {
            int[] grades = new int[studentsArray.Length];
            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = studentsArray[i].grade;
            }
            return grades;
        }
        public string asks4Coffee (ICoffee someone){
            return $"{name} {lastName} asks for a coffee.\n{someone.prepareCoffee()}";
            }
    }
}
