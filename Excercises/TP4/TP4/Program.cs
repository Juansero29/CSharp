using System;
using static System.Console;

namespace TP4
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t0 = new Teacher("Marc", delegate (int min, int max, int number) { return number; });
            Teacher t1 = new Teacher("Pascale", delegate (int min, int max, int number)
            {
                return -(Math.Pow(number - min, 2) / (max - min) + min);
            });


            Teacher t2 = new Teacher("Provot", delegate (int min, int max, int number)
            {
                return Math.Pow(number - min, 2) / (max - min) + min;
            });

            Student s = new Student("Tata", 0, 20);


            WriteLine(t0.Grade(s));
            WriteLine(t1.Grade(s));
            WriteLine(t2.Grade(s));


        }

        public static double LinearRepartition(int min, int max, int number)
        {
            return number;
        }


        public static double NegativeSquaredRepartition(int min, int max, int number)
        {
            return -(Math.Pow(number - min, 2) / (max - min) + min);
        }


        public static double SquaredRepartition(int min, int max, int number)
        {
            return Math.Pow(number - min, 2) / (max - min) + min;
        }
    }
}