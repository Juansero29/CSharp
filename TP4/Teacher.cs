using System;
using System.Collections.Generic;
using System.Text;

namespace TP4
{
    class Teacher
    {

        public String Name { get; set; }

        public delegate double Repartition(int min, int max, int number);
        private Repartition myFunc;


        /*How to pass a delegate on the main program as a parameter ?
        * Simply pass a function on the main program where the delegate should be
        * (a function that accomplishes the delegate's characteristics).
        */
        public Teacher(String name, Repartition myFunc)
        {
            Name = name;
            this.myFunc = myFunc;
        }

        public double Grade(Student s)
        {
            Random rand = new Random();
            double d = myFunc(s.Min, s.Max, rand.Next(s.Min, s.Max));
            return d < 0 ? 0 : d > 20 ? 20 : d;
        }
    }
}
