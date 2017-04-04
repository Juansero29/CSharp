using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex_19
{
    class Program
    {
        static void Main(string[] args)
        {
    
            WriteLine("You are about to build a person.");
            WriteLine("What is its name? :");
            string name = ReadLine();
            WriteLine("Does it wear glasses? (type 'True' or 'False'): ");
            bool answer;
            while (!bool.TryParse(ReadLine(), out answer))
            {
                WriteLine("Wrong input. Please, write 'True' or 'False'");
            }
            WriteLine("How many teeth have you lost ? ");
            uint integer;
            while (!uint.TryParse(ReadLine(), out integer))
            {
                WriteLine("Wrong input. Please, enter an integer.");
            }
            WriteLine("What is you birth date?");
            DateTime date = new DateTime();
            while (!DateTime.TryParseExact(ReadLine(), "dd'/'MM'/'yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date))
            {
                WriteLine("Wrong input. Please, enter a date with the format 'dd/MM/yyyy' ");
            }
            WriteLine("How many time have you lost ? ");
            TimeSpan time = new TimeSpan();
            while (!TimeSpan.TryParseExact(ReadLine(), "hh':'mm':'ss", System.Globalization.CultureInfo.InvariantCulture, out time))
            {
                WriteLine("Wrong input. Please, enter a time with the format 'hh:mm:ss' ");
            }
            Person pedrito = new Person(name, answer, integer, date, time);

            if (pedrito == null) {
                WriteLine("You can't follow instructions.");
            }
            else
            {
                WriteLine("Your person has been created! I'm gonna show it to you...");
                WriteLine();
                WriteLine(pedrito);
            }
            ReadKey(true);
        }
    }
}
