using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Complementary
{
    class Program
    {
        static void Main(string[] args)
        {
        }


        static void Exo1_01()
        {
            WriteLine("\n--------------------------------------------------------------------------------------");
            WriteLine("      ARRAY WITH CUSTOMIZED SIZE, RANDOM CONTENT AND NO REPEATED ELEMENTS IN A RANGE    ");
            WriteLine("----------------------------------------------------------------------------------------");
            WriteLine("\nWith this program, you'll create an array with random content inside. You will define the range of the generated random numbers (from a to b) and the size of the array.");
            WriteLine("\nThe numbers inside the array will not repeat: a number won't be twice in the array.");
            WriteLine("\nSince numbers won't repeat, the size of the array can't be bigger than the possible numbers in the range you defined.");
            WriteLine("\ne.g If your range goes from 1 to 10, there are only 10 possible numbers to put inside the array being different from each other, hence, the maximum size must be 10.");
            WriteLine("----------------------------------------------------------------------------------------");
            int a = 0, b = 0, size = 0;
            bool bigdecision = true;
            while (bigdecision)
            {
                WriteLine("\n----------------------------------------------------------------------------------------");
                WriteLine("\nPress a key to start creating your array.");
                ReadKey(true);

                WriteLine("\n\n-------------------------------------------------");
                WriteLine("You're creating the range of the random numbers.");
                WriteLine("-------------------------------------------------");
                WriteLine("\nPlease, input the number where your range starts at: ");
                while (!int.TryParse(ReadLine(), out a))
                {
                    WriteLine("Wrong input. Please, enter an integer.");
                }

                WriteLine("\nPlease, input the number where your range will finish: ");
                while (!int.TryParse(ReadLine(), out b) || b < a)
                {

                    Write("\nWrong input. Please, enter an integer bigger than the number where your range starts ({0}): ", a);
                }


                WriteLine("\n\n---------------------------");
                WriteLine("You're creating your array.");
                WriteLine("---------------------------");
                WriteLine("\nNote that there are {0} different possible numbers at the range you have chosen", (b - a) + 1);
                WriteLine("\nPlease, type the number of cells of your array.");
                bool isInt = int.TryParse(ReadLine(), out size);
                while ((!isInt) || size > ((b - a) + 1))
                {
                    if (size > ((b - a) + 1))
                    {
                        WriteLine("\nWrong input. Please, enter a size lower or equal to {0}.", (b - a) + 1);
                    }
                    if (!isInt)
                    {
                        WriteLine("\nWrong input. Please, enter an integer.");
                    }
                    isInt = int.TryParse(ReadLine(), out size);

                }
                WriteLine("\n---------------------------");
                WriteLine("You're finishing your array.");
                WriteLine("---------------------------");

                WriteLine("\nYour array will have {0} cells with random content inside. Each number will be different from each other and will be higher or equal to {1} but smaller or equal to {2}\n", size, a, b);

                WriteLine("\nIs this okay? If this is okay, type 'Y'. If you want to start from zero, type 'N'");
                string decision = ReadLine();
                //While the user enters something different from 'y' or 'n'...
                while (decision == null || (!decision.Equals("Y", StringComparison.OrdinalIgnoreCase) && !decision.Equals("N", StringComparison.OrdinalIgnoreCase)))
                {
                    Write("\nIncorrect input, please type 'Y' or 'N' (without the single quotes): ");
                    decision = ReadLine();
                }
                if (decision.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    bigdecision = false;
                }
                else
                {
                    bigdecision = true;
                }
            }


            int[] table = new int[size]; //Create a new table, then create a new instance of that table with the size read before. //Maximum size must be one less than the last element of the range.
            Random rnd = new Random(); //Create a variable that calls a method to get a random number.
            int elementsInTable = 0; //Initialize table elements at zero.


            do
            {
                for (int i = 0; i < table.Length; i++) //For each element in the table while it's not the end of the table...
                {
                    int num = rnd.Next(a, b + 1); // Generate a random number from 1 to 49.
                    if (!Exo5_ValueIsInTable(table, num, elementsInTable)) //If the number is not in the array...
                    {
                        table[i] = num; //Put the random number in the current cell.
                        elementsInTable += 1; //Add 1 to the elements in the table.
                    }
                    else //If the number IS in the array...
                    {

                        while (Exo5_ValueIsInTable(table, num, elementsInTable)) //While the random number is still on the table...
                        {
                            num = rnd.Next(a, b + 1); //Choose another random number.
                        } //If it got here, it found a random number in the correct range that it's still not in the table, so it can add it.
                        table[i] = num; //Put the random number in the current cell.
                        elementsInTable += 1; //Add 1 to the elements in the table.
                    }
                }

            }
            while (elementsInTable < table.Length); // Do all that stuff while the number of elements in the table it's less than the array's length.

            WriteLine("\n----------------------------------------");
            WriteLine("          THIS IS YOUR ARRAY            ");
            WriteLine("----------------------------------------");
            for (int i = 0; i < table.Length; i++) //Go trough the array and print its elements.
            {
                //UNCOMMENT IF YOU WANT TO HAVE A SORTED ARRAY.
                //Array.Sort(table); //Sort out the array in order that we can verify there are no repeated items. (If the size of the array it's 47, then all numbers from 1 to 49 must be inside).
                WriteLine("In the index {0} there is the value {1}.", i, table[i]); //Printing in screen the index of the cell (cell number) followed by the value of that index.
            }
            string decisionSort = "";
            WriteLine("Do you want to sort your array? (Y / N)");
            decisionSort = ReadLine();
            while (decisionSort == null || (!decisionSort.Equals("Y", StringComparison.OrdinalIgnoreCase) && !decisionSort.Equals("N", StringComparison.OrdinalIgnoreCase)))
            {
                Write("\nIncorrect input, please type 'Y' or 'N' (without the single quotes): ");
                decisionSort = ReadLine();
            }
            if (decisionSort.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                WriteLine("\n---------------------------------------");
                WriteLine("       THIS IS YOUR SORTED ARRAY        ");
                WriteLine("----------------------------------------");
                for (int i = 0; i < table.Length; i++) //Go trough the array and print its elements.
                {

                    Array.Sort(table); //Sort out the array in order that we can verify there are no repeated items. (If the size of the array it's 47, then all numbers from 1 to 49 must be inside).
                    WriteLine("In the index {0} there is the value {1}.", i, table[i]); //Printing in screen the index of the cell (cell number) followed by the value of that index.
                }

            }

            WriteLine("\n-----------------------------------------------");
            WriteLine("                WE ARE FINISHED!                ");
            WriteLine("------------------------------------------------");
            WriteLine("\n Press any key to continue...");
            ReadKey(true);

        }

        static void Exo1_02()
        {
            int[,] ArrayForTP = new int[5, 6];
            int i, j, number, som = 0;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    WriteLine("Write the number you want in line {0} and column {1}", i, j);
                    while (!int.TryParse(ReadLine(), out number))
                    {
                        WriteLine("Wrong input. Please, enter an integer.");
                    }
                    ArrayForTP[i, j] = number;
                }

            }
            WriteLine("Your array is: ");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    som += ArrayForTP[i, j];
                    Write("{0}\t\t", ArrayForTP[i, j]);
                }
                WriteLine();
            }
            WriteLine("The addition of the array's values is {0}.", som);
            ReadKey();
        }

        static void Exo1_03()
        {
            int[,] tabPascal = new int[20, 20];
            int i, j;
            for (i = 0; i < 0; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    tabPascal[i, j] = 0;
                }
            }
            tabPascal[0, 0] = 1;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    tabPascal[i, j] = tabPascal[i - 1, j - 1] + tabPascal[i - 1, j];
                    Write("{0}\t", tabPascal[i, j]);
                }
                WriteLine();
                WriteLine();
            }

            ReadKey();

        }

        static void Exo1_04()
        {
            int a, b, size, choice;
            float c;
            WriteLine("---------------------");
            WriteLine("  AVAIBLE EXCERCISES ");
            WriteLine("---------------------");
            WriteLine("1. Static method with two arguments that returns the addition of the two values.");
            WriteLine("2. Static method with three arguments, one of which is an 'out' integer, doesn't return anything.");
            WriteLine("3. Static method that takes an array as arguments and returns the addition of the array's elements.");
            WriteLine("4. Static method that takes an undetermined nunmber of integers as arguments and returns the addition of the arguments.");
            WriteLine("\nWhich excercise do you want to execute?");
            while (!int.TryParse(ReadLine(), out choice) || choice > 4 || choice < 0)
            {
                WriteLine("Wrong input. Please, enter a valid option.");
            }
            switch (choice)
            {
                case 1:
                    Write("\n\nEnter A: ");
                    while (!int.TryParse(ReadLine(), out a))
                    {
                        WriteLine("Wrong input. Please, enter an integer.");
                    }
                    Write("Enter B: ");
                    while (!int.TryParse(ReadLine(), out b))
                    {
                        WriteLine("Wrong input. Please, enter an integer.");
                    }
                    c = HelpProgram.Exo1_04_01(a, b);
                    Write("C = " + c);
                    ReadKey(true);
                    break;
                case 2:
                    Write("\n\nEnter A: ");
                    while (!int.TryParse(ReadLine(), out a))
                    {
                        WriteLine("Wrong input. Please, enter an integer.");
                    }
                    Write("Enter B: ");
                    while (!int.TryParse(ReadLine(), out b))
                    {
                        WriteLine("Wrong input. Please, enter an integer.");
                    }
                    HelpProgram.Exo1_04_02(a, b, out c); //If we passed a reference to 'c', we would need to initialiaze 'c' at 0.
                    Write("C = " + c);
                    ReadKey(true);
                    break;
                case 3:
                    WriteLine("\n\nEnter the size of the array. (it will contain random integers inside smaller than one thousand.)");
                    while (!int.TryParse(ReadLine(), out size))
                    {
                        WriteLine("Wrong input. Please, enter an integer.");
                    }
                    int[] tab = new int[size];
                    WriteLine();
                    Write("This is your array: ");
                    Random rand = new Random();
                    for (int i = 0; i < tab.Length; i++)
                    {
                        int num = rand.Next(1, 1001);
                        tab[i] = num;
                        Write("\n" + tab[i] + "\n");
                    }
                    WriteLine();
                    size = HelpProgram.Exo01_04_03(tab);
                    WriteLine("The addition of the elements in the array makes {0}.", size);
                    ReadKey();
                    break;
                case 4:
                    int sum;
                    sum = HelpProgram.Exo01_04_04(5, 8, 9, 10, 20, 19);
                    Write(sum);
                    ReadKey();
                    break;
            }

        }
        static void Exo01_05()
        {
            int un = 3, un1 = 2, un2 = 1, i = 0;
            while (un <= 10000)
            {
                un = HelpProgram.Exo01_05_01(ref un2, ref un1);
                un2 = un1;
                un1 = un;
                i++;
                WriteLine("Un: " + un + "  i: " + i);
            }
            Write(i);
            ReadKey();
        }

        static void Exo01_06()
        {
            int i = 0, big = 0;
            int[] tab = new int[3];
            foreach (var cell in tab)
            {
                WriteLine("Write a number: ");
                HelpProgram.readInteger(ref tab[i]);
                if (tab[i] > big)
                {
                    big = tab[i];
                }
                i++;
            }
            WriteLine("The biggest number is {0}", big);
            ReadKey();
        }

        static void Exo01_07()
        {
            int numbersToAdd = 0, add = 0, i;
            HelpProgram.readInteger(ref numbersToAdd);
            int[] tab = new int[numbersToAdd];
            for (i = 0; i < tab.Length; i++)
            {
                tab[i] = i + 1;
            }
            foreach (var number in tab)
            {
                add += number;
            }
            Write("The addition of the first {0} integers equals {1}", numbersToAdd, add);
            ReadKey();
        }

        static void Exo01_08()
        {

            int[] integersArray = { 12, 45, 35, 54, 20 };
            for (int i = 0; i < integersArray.Length; i++)
            {
                integersArray[i] += 1;
            }
            // Impossible to modify value being read by the foreach loop
        }

        static void Exo01_09()
        {
            Car renault = new Car();
            WriteLine("Current speed is " + renault.Speed + "Km per hour.");
            ReadKey(true);
            renault.speedUp();
            WriteLine("Current speed is " + renault.Speed + "Km per hour.");
            ReadKey(true);
            renault.speedUp();
            renault.speedUp();
            renault.speedUp();
            renault.speedUp(1000);
            WriteLine("Current speed is " + renault.Speed + "Km per hour.");
            ReadKey(true);
            renault.slowDown();
            renault.slowDown();
            renault.slowDown();
            renault.slowDown();
            renault.slowDown();
            renault.slowDown();
            WriteLine("Current speed is " + renault.Speed + "Km per hour.");
            ReadKey(true);
        }


        public static bool Exo5_ValueIsInTable(int[] table, int num, int elementsInTable)
        {
            for (int element = 0; element < elementsInTable; element++) // For each element in the array.
            {
                if (table[element] == num) //If the current element its the same than the element we were searching for...
                {
                    return true; //Return true since it's indeed in the array.
                }
            }
            return false;

        }

    }

    class Car
    {
        public int Speed { get; private set; }
        public void speedUp()
        {
            if (Speed <= 128)
            {
                Speed = Speed + 2;
            }
        }
        public void speedUp(int faster)
        {
            if (Speed <= 130 - faster)
            {
                Speed = Speed + faster;
            }
            else { Speed = 130; }
        }
        public void slowDown()
        {
            if (Speed >= 2)
            {
                Speed = Speed - 2;
            }

        }
    }

    public class HelpProgram
    {

        public static float Exo1_04_01(int a, int b)
        {
            float c;
            c = a + b;
            return c;
        }
        public static void Exo1_04_02(int a, int b, out float c)
        {
            c = a + b;
        }
        public static int Exo01_04_03(int[] arr)
        {
            int add = 0;
            foreach (var integer in arr)
            {
                add += integer;
            }
            return add;
        }

        public static int Exo01_04_04(params int[] tab)
        {
            int add = 0;
            foreach (var integer in tab)
            {
                add += integer;
            }
            return add;
        }

        public static int Exo01_05_01(ref int un1, ref int un2)
        {
            int un;
            un = un1 + un2;
            return un;
        }

        public static void readInteger(ref int integer)
        {
            while (!int.TryParse(ReadLine(), out integer))
            {
                WriteLine("Wrong input. Please, enter an integer.");
            }


        }
    }

}
