using System;
using System.Collections.Generic;
using System.Text;

namespace TP4
{
    class Student
    {
        public String Name { get; set; }
        public int Min { get; set; }

        public int Max { get; set; }

        public Student MyProperty { get; set; }

        public static Student[] Students = { new Student("Juansero", 8, 18), new Student("Toto", 2, 17), new Student("Stard", 10, 12) };

        public Student(String name, int min, int max)
        {
            if (min > max) { throw new Exception("The minimal grade can't be higher than the maximal grade"); }
            if (name == null) { throw new Exception("The name cannot be null. .l. "); }
            if (min < 0) { min = 0; }
            if (max > 20) { max = 20; }

            Name = name;
            Min = min;
            Max = max;
        }

    }
}
