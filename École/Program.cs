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

    class Test {
        static public void Main(string[] s) {
            
            Student[] studentArray = {
                new Good("Lola", "Chelou"),
                new NotThatGood("Juan", "Rodríguez")
            };

            Teacher teacher0 = new Teacher("Marc", "Chevaldonné");
            WriteLine("*Student {0} says...* Teacher {1}! Grade me!", studentArray[0].name, teacher0.name);
            WriteLine("*Student {0} says...* Teacher {1}! Grade me!", studentArray[1].name, teacher0.name);
            WriteLine("*Teacher {0} says...* {1}! Do you work?", teacher0.name, studentArray[0].name);
            WriteLine("*Student {0} says...* {1}, now grade me!", studentArray[0].name, studentArray[0].DoYouWork());
            WriteLine("*Student {0} says...* {1}, now grade me!", studentArray[1].name, studentArray[1].DoYouWork());
            WriteLine("*Teacher {0} says...* Okay okay! I'm gonna grade you {1}!", teacher0.name, studentArray[0].name);
            teacher0.Grade(studentArray);
            WriteLine("I'm on it!");
            WriteLine("Okay I got your grade {0}! Your grade is {1}", studentArray[0].name, studentArray[0].grade);
            WriteLine("*Student {0} says...* I want to get better! Motivate me {1}!", studentArray[0].name, teacher0.name);
            WriteLine("*Teacher {0} says...* Okay, okay I will motivate you {1}!", teacher0.name, studentArray[0].name);
            teacher0.Motivate(studentArray);
            WriteLine("*Teacher {0} says...* {1}! Do you work?", teacher0.name, studentArray[0].name);
            WriteLine("*Student {0} says...* {1}, now grade me!", studentArray[0].name, studentArray[0].DoYouWork());
            WriteLine("*Teacher {0} says...* Okay okay! I'm gonna grade you {1}!", teacher0.name, studentArray[0].name);
            int[] grades = teacher0.Grade(studentArray);
            WriteLine("Okay I got your grades ! Your grades are :");
            foreach(int grade in grades)
            {
                WriteLine(grade);
            }

            ReadKey(true);
        }

    }
}
