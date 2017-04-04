using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace IUT {
    // Private : Allows to read but not to write. (Writing only in the same class or in child classes)
    // Protected : Allows to read and to write on herited classes only.
    // Public : Everybody's hooker.

    class B20 {
        static public void Main(string[] s) {
            
            Crawler crawler0 = new Crawler("Smurf", "Crawler");
            Cool teacher0 = new Cool("Roger", "Rabbit");
            Trickster trickster0 = new Trickster("Smurf", "Trickster");
            Student[] studentArray = {
                new Good("Smurf", "Good"),
                new NotThatGood("Smurf", "Not that good"),
                new Lazy("Smurf","Lazy"),
                new Cheater("Smurf", "Cheater"),
                new Trickster("Smurf", "Trickster"),
                new Crawler("Smurf", "Crawler")
        };
            int[] gradesArray= new int[studentArray.Length];

            WriteLine("*Teacher {0} says...* Okay okay! I'm gonna grade you!", teacher0.name);
            gradesArray = teacher0.Grade(studentArray);
            studentArray[2].grade = 4;
            DisplayGrades(teacher0, gradesArray, studentArray);
            WriteLine();
            teacher0.Motivate(studentArray);
            teacher0.Motivate(studentArray);
            teacher0.Motivate(studentArray);
            teacher0.Motivate(studentArray);
            teacher0.Motivate(studentArray);
            WriteLine("*Teacher {0} says...* Okay okay! I'm gonna grade you!", teacher0.name);
            teacher0.Grade(studentArray);
            gradesArray = teacher0.Grade(studentArray);
            DisplayGrades(teacher0, gradesArray, studentArray);
            WriteLine();
            teacher0.Motivate(studentArray);
            teacher0.Motivate(studentArray);
            teacher0.Motivate(studentArray);
            teacher0.Motivate(studentArray);
            teacher0.Motivate(studentArray);
            WriteLine("*Teacher {0} says...* Okay okay! I'm gonna grade you!", teacher0.name);
            gradesArray = teacher0.Grade(studentArray);
            DisplayGrades(teacher0, gradesArray, studentArray);
            WriteLine();
            WriteLine("Roger Rabbit is sick.");
            WriteLine();
            Mean teacher1 = new Mean("Harvey", "Dent");
            teacher1.Motivate(studentArray);
            teacher1.Motivate(studentArray);
            teacher1.Motivate(studentArray);
            teacher1.Motivate(studentArray);
            teacher1.Motivate(studentArray);
            gradesArray = teacher1.Grade(studentArray);
            DisplayGrades(teacher1, gradesArray, studentArray);
            WriteLine();
            //WriteLine($"{teacher1.asks4Coffee(studentArray[4])}"); //Array from a class that contains an instantiation of a sub-class that implements an interface. 
            WriteLine($"{teacher1.asks4Coffee(crawler0)}");
            WriteLine();
            WriteLine($"{teacher1.asks4Coffee(teacher0)}");
            trickster0.Cheat();
            WriteLine($"{teacher0.asks4Coffee(trickster0)}");
            gradesArray = teacher1.Grade(studentArray);
            DisplayGrades(teacher1, gradesArray, studentArray);
            ReadKey(true);
        }

        static void DisplayGrades(Teacher teacher, int[] gradesArray, Student[] studentArray) {

            WriteLine("Grades from teacher {0} {1}", teacher.name, teacher.lastName);
            int i=0;
            string answer;
            foreach (int grade in gradesArray) {
                answer = studentArray[i].DoYouWork();
                WriteLine("{0} {1} : {2}/20 ; Do you work? {3}", studentArray[i].name, studentArray[i].lastName, gradesArray[i], answer);
                i++;
            }
        }

    }
}
