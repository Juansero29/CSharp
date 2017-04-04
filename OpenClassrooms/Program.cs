using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using static System.Console;

namespace Exercises
{
    public class ExcercicesConsole
    {
        static void Main()
        {

            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            //Exercise5();
            //Exercise6();
            //Exercise7();
            //Exercise8();
            //Exercise8_1();
            //Exercise9();
            //Exercise10();
            //CiExercise1();
            //OpClassExo1("Juan");
            //OpClassExo2();
            //OpClassExo3();
            //OpClassExo4();
            //OpClassExo6();
            OpClassExo7();
        }

        static void Exercise1()
        {
            WriteLine("\nThis program shows a name that's written hard in the code.");
            WriteLine("Press any key to continue...");
            ReadKey();
            WriteLine("Hello");
            WriteLine("Juan Rodríguez");
            WriteLine("Press any key to exit.");
            ReadKey();
        }

        static void Exercise2()
        {
            WriteLine("\nThis program does an addition operation that's written hard in the code.");
            WriteLine("Press any key to continue...");
            ReadKey();
            WriteLine("2 + 5 = {0}", 2 + 5);
            WriteLine("Press any key to exit.");
            ReadKey();
        }

        static void Exercise3()
        {
            WriteLine("\nThis program does an division operation that's written hard in the code.");
            WriteLine("Press any key to continue...");
            ReadKey();
            WriteLine("15 / 3 = {0}", 15 / 3);
            WriteLine("Press any key to exit.");
            ReadKey();
        }

        static void Exercise4()
        {
            WriteLine("\nThis program does an addition operation that's written hard in the code.");
            WriteLine("Press any key to continue...");
            ReadKey();
            WriteLine("78 + 89 = {0}", 79 + 89);
            WriteLine("Press any key to exit.");
            ReadKey();
        }

        static void Exercise5()
        {
            WriteLine("\nThis program does different arithmetical operations that are written hard in the code.");
            WriteLine("Press any key to continue...");
            ReadKey();
            WriteLine("-1 + 4 * 6 = {0}", -1 + 4 * 6);
            WriteLine("(35 + 5) % 7 = {0}", (35 + 5) % 7);
            WriteLine("14 + -4 * 6 / 11 {0}", 14 + -4 * 6 / 11);
            WriteLine("2 + 15 / 6 * 1 - 7 % 2 {0}", 2 + 15 / 6 * 1 - 7 % 2);

            WriteLine("Press any key to exit.");
            ReadKey();
        }

        static void Exercise6()
        {
            WriteLine("\nThis program asks you for two numbers and then swaps them and prints them in screen.");
            WriteLine("Press any key to continue...");
            ReadKey();
            WriteLine("Input the First Number: ");
            var x = Convert.ToInt32(ReadLine());
            WriteLine("Input the Second Number: ");
            var y = Convert.ToInt32(ReadLine());

            var z = x;
            x = y;
            y = z;

            WriteLine("After swapping... ");
            WriteLine("First Number: {0}", x);
            WriteLine("Second Number: {0}", y);

            WriteLine("Press any key to exit.");
            ReadKey();

        }

        static void Exercise7()
        {
            WriteLine(
                "\n This program will ask you three numbers, it will multiply them and show you the result.");
            WriteLine("Press any key to continue...");
            ReadKey();
            WriteLine("Input the First Number: ");
            var x = int.Parse(ReadLine());
            WriteLine("Input the Second Number: ");
            var y = int.Parse(ReadLine());
            WriteLine("Input the Third Number: ");
            var z = int.Parse(ReadLine());

            var res = x * y * z;

            WriteLine("{0} x {1} x {2} = {3}", x, y, z, res);
            WriteLine("Press any key to exit.");
            ReadKey();
        }

        static void Exercise8()
        {
            WriteLine(
                "\n This program will print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.");
            WriteLine("Press any key to continue...");
            ReadKey();
            WriteLine("Input the First Number: ");
            var x = int.Parse(ReadLine());
            WriteLine("Input the Second Number: ");
            var y = int.Parse(ReadLine());
            var ad = x + y;
            var sub = x - y;
            var mult = x * y;
            var div = x / y;
            var mod = x % y;
            WriteLine("{0} + {1} = {2}", x, y, ad);
            WriteLine("{0} - {1} = {2}", x, y, sub);
            WriteLine("{0} x {1} = {2}", x, y, mult);
            WriteLine("{0} / {1} = {2}", x, y, div);
            WriteLine("{0} mod {1} = {2}", x, y, mod);
            WriteLine("Press any key to exit.");
            ReadKey();
        }

        static void Exercise8_1()
        {
            WriteLine(
                "\n This program will ask you two numbers and it will execute all possible arithmetical operations with them and you the result for each one.");
            WriteLine("Press any key to continue...");

            Write("Enter a number: ");
            int num1 = Convert.ToInt32(ReadLine());

            Write("Enter another number: ");
            int num2 = Convert.ToInt32(ReadLine());

            WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
            WriteLine("Press any key to exit.");
            ReadKey();
        }

        static void Exercise9()
        {
            Write(
                "\n This program will ask you a number and then it will show you its multiplication table from 0 to 10 \n");
            Write("Please, input a number: ");
            double x = Convert.ToDouble(ReadLine());
            WriteLine("-------------------------------------------------");
            WriteLine("\n The multiplication table of {0} from 0 to 10 is: \n", x);
            WriteLine("{0} x 0 = {1}", x, x * 0);
            WriteLine("{0} x 1 = {1}", x, x * 1);
            WriteLine("{0} x 2 = {1}", x, x * 2);
            WriteLine("{0} x 3 = {1}", x, x * 3);
            WriteLine("{0} x 4 = {1}", x, x * 4);
            WriteLine("{0} x 5 = {1}", x, x * 5);
            WriteLine("{0} x 6 = {1}", x, x * 6);
            WriteLine("{0} x 7 = {1}", x, x * 7);
            WriteLine("{0} x 8 = {1}", x, x * 8);
            WriteLine("{0} x 9 = {1}", x, x * 9);
            WriteLine("{0} x 10 = {1}", x, x * 10);
            WriteLine("Press any key to exit.");
            ReadKey();
        }

        static void Exercise10()
        {
            WriteLine("This program will repeat what you write until you write 'stop'.");
            string word;
            do
            {
                word = ReadLine();
                WriteLine("Variable \"word\" is {0}", word);
            } while (!word.Equals("Stop", StringComparison.OrdinalIgnoreCase));

        }

        static void CiExercise1()
        {
            WriteLine("\n--------------------------------------------------------------------------------------");
            WriteLine("      TABLE WITH CUSTOMIZED SIZE, RANDOM CONTENT AND SUMMATORY OF ITS CONTENTS.      ");
            WriteLine("--------------------------------------------------------------------------------------");
            WriteLine("\nIn this program you will create a table. Please, type the size (cells) of your table: ");
            int size = int.Parse(ReadLine());
            //Read the size from user input, convert it into a 32 integer and saving it in a variable.

            WriteLine("\nYour table will have {0} cells with random content inside.\n", size);
            WriteLine("Press any key to continue...\n");
            ReadKey();
            int[] table = new int[size];
            //Create a new table, then create a new instance of that table with the size read before.
            int sum = 0; //Initialize a variable that will contain the summatory of the table's elements.
            Random rnd = new Random();
            //Create a variable that calls a method to get a random number. (don't use it inside the for, if you do you'll get the same number multiple times)
            for (int i = 0; i < table.Length; i++) //For i, while i is smaller than the table's size, do i+1.
            {
                int num = rnd.Next(0, 100); //Save the random number in a integer variable.
                table[i] = num; //Save the generated random number in the i cell of the table.
                sum += table[i]; //Sum up the sum value with the value of the number in the i cell.

            }
            for (int i = 0; i < table.Length; i++) //Same as before.
            {
                WriteLine("In the index {0} there is the value {1}.", i, table[i]);
                //Printing in screen the index of the cell (cell number) followed by the value of that index.
            }
            WriteLine("The summatory of the table's elements is {0}", sum);
            //Printing in screen the sum of the values in these cells.
            WriteLine("Press any key to exit.");
            ReadKey();
        }

        static void OpClassExo1(string name)
        {
            WriteLine("This program has taken a string as arguments and it will print it out. ");
            WriteLine("Press any key to continue...");
            ReadKey();
            WriteLine("Hello {0}!", name);
            WriteLine("----------");
            WriteLine("Welcome to the awesome world of C#!");
            WriteLine("Press any key to exit.");
            ReadKey();
        }

        static void OpClassExo2()
        {
            WriteLine(
                "This program will say \"Good weekend *your name* !\" to you if it's the weekend. If it is not the weekend, it will tell you \"Have a good day *your name* !\" if it is not yet 18h or \"Good afternoon *your name* !\" if it's later than 18h.");
            WriteLine("Press any key to continue...");
            ReadKey();
            int hour = DateTime.Now.Hour;
            DayOfWeek day = DateTime.Now.DayOfWeek;

            if (((day == DayOfWeek.Friday) && (hour >= 18)) || (day == DayOfWeek.Saturday) || (day == DayOfWeek.Sunday) ||
                ((day == DayOfWeek.Monday) && (hour < 9))) //It's the week-end.
            {
                WriteLine("Good weekend " + Environment.UserName + "!");
            }
            else //We are in ouvrable list.
            {
                if ((hour >= 9) && (hour <= 18)) //It's the day.
                    WriteLine("Have a good day " + Environment.UserName + "!");
                else // It's the afternoon.
                    WriteLine("Good Afternoon " + Environment.UserName + "!");
            }
            WriteLine("Press any key to exit.");
            ReadKey();
        }

        static void OpClassExo3()
        {

            List<string> list = new List<string>
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
                "C'est ma bite",
                "Non",
                "Penis",
            };
            WriteLine("--------------------------------------------------------------------------------");
            WriteLine("This program has created a list containing different elements as follows...");
            WriteLine("--------------------------------------------------------------------------------");
            Write("");
            WriteLine(" \t Number of elements in the list is {0} ", list.Count);
            WriteLine(" \t Base list: ");
            WriteLine("");

            foreach (string element in list)
            {
                WriteLine("\t {0}. {1}", list.IndexOf(element), element);
            }

            WriteLine("");
            WriteLine("Press any key to continue...");
            ReadKey();
            WriteLine("");
            WriteLine("---------------------------------------------------------------------------");
            Write("Please, type an element you would like to delete from this list: ");
            string elementtodel = ReadLine();

            //for (int i = 0; i < list.Count; i++)
            //{                                     This kind of loop will successfully delete the element that contains the string "Wednesday" in the list "list". 
            //    if (list[i] == "Wednesday")       However, when i is 2 and the string is Wednesday, it will delete this element. Hence, Thursday will be now in 
            //        list.Remove(list[i]);         index 2 and i will now be 3. This means i didn't recognize Thursday as string. It jumped Thursday. So, even if
            //                                      the string in index 3 was "Wednesday" this kind of loop wouldn't delete it.
            //}
            //Try & Run this code and you'll see what I say up here.

            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] == "Wednesday")
            //        list.Remove(list[i]);
            //}

            //To avoid this problem, then we are going to read the table from the end to the start.

            if (list.Contains(elementtodel, StringComparer.OrdinalIgnoreCase)) //If the element to delete is present in the list...
            {
                for (var i = list.Count - 1; i >= 0; i--)
                {
                    if (list[i].Equals(elementtodel, StringComparison.OrdinalIgnoreCase)) //If the current element is equal than the element to delete.
                        list.Remove(list[i]); //Delete current element 
                }

                WriteLine("");
                WriteLine("----------------------------------------------------------------------------");
                WriteLine("\t Number of elements in the list is {0} ", list.Count);
                WriteLine("\t List after deletion: ");
                WriteLine("");

                foreach (string element in list)
                {
                    WriteLine("\t{0}. {1}", list.IndexOf(element), element);
                }
            }

            else //If the element to delete is not present in the list.
            {
                WriteLine("\n The element \"{0}\" is not present in this list, please write an element that exists.", elementtodel);
            }

            string decision;
            do
            {
                //If there are no elements in the list...
                if (list.Count == 0)
                {
                    WriteLine("\nThere are no more elements in this list. You can't continue eliminating.\n");
                    break;
                }
                WriteLine("\nDo you want to try again? (Y / N)");
                decision = ReadLine();

                //While the user enters something different from 'y' or 'n'...
                while (decision == null || (!decision.Equals("Y", StringComparison.OrdinalIgnoreCase) && !decision.Equals("N", StringComparison.OrdinalIgnoreCase)))
                {
                    Write("\nIncorrect input, please type 'Y' or 'N' (without the single quotes): ");
                    decision = ReadLine();
                }

                //If the user has typed 'N' because he doesn't want to delete an element...
                if (decision.Equals("N", StringComparison.OrdinalIgnoreCase))
                    break;

                //If there are no problems and user typed 'Y'.
                Write("\nPlease, type an element you would like to delete from this list: ");
                var elementtodele = ReadLine();

                if (list.Contains(elementtodele, StringComparer.OrdinalIgnoreCase)) //If the element to delete is present in the list...
                {
                    for (var i = list.Count - 1; i >= 0; i--)
                    {
                        if (list[i].Equals(elementtodele, StringComparison.OrdinalIgnoreCase)) //If the current element is equal than the element to delete.
                            list.Remove(list[i]); //Delete current element 
                    }
                    WriteLine("");
                    WriteLine("----------------------------------------------------------------------------");
                    WriteLine("\t Number of elements in the list is {0} ", list.Count);
                    WriteLine("\t List after deletion: ");
                    WriteLine("");

                    foreach (var element in list)
                        WriteLine("\t{0}. {1}", list.IndexOf(element), element);
                }

                else //If the element to delete is not present in the list.
                {
                    WriteLine("\n The element \"{0}\" is not present in this list, please write an element that exists.", elementtodele);
                }



            } while (decision.Equals("Y", StringComparison.OrdinalIgnoreCase));

            WriteLine("");
            WriteLine("You have finished editing the list! This is the final list...");
            WriteLine("");
            foreach (var element in list)
                WriteLine("\t{0}. {1}", list.IndexOf(element), element);
            WriteLine("");
            WriteLine("Press any key to exit.");
            ReadKey();
        }

        static void OpClassExo4()
        {
            //Console.WriteLine("The result is: {0}", NCOpClassExo4_AddInt(1000, 100));
            
            //List<double> myList = new List<double> {1.0, 5.5, 9.9, 2.8, 9.6};
            //Console.WriteLine("Your average is: {0}", NCOpClassExo4_ListAverage(myList));

            WriteLine("The summatory of the common numbers in both lists is: {0}", NCOpClassExo4_CreateList());
            WriteLine("Press any key to exit.");
            ReadKey();

        }


        static int NCOpClassExo4_AddInt(int a, int b)
        {
            if (b < a)
            {
                WriteLine("The second number must be higher than the first.");
                return 0;
            }
            int add = 0;
            for (int i = a; i <= b; i++)
            {
                //Console.WriteLine("add = {0} + {1}", add, i);
                add = add + i;
                //Console.WriteLine("add = {0}", add);
            }
            return add;
        }

        static double NCOpClassExo4_ListAverage(List<double> list)
        {
            double avg = 0;
            foreach (double element in list)
            {
                avg = avg + element;
            }
            avg = avg/list.Count;
            return avg;
        }

        static int NCOpClassExo4_CreateList()
        {
            List<int> multiplesthree = new List<int> ();
            for (int i = 0; i <= 100; i++)
            {
                if (i%3 == 0)
                multiplesthree.Add(i);
            }

            List<int> multiplesfive = new List<int>();
            for (int i = 0; i <= 100; i++)
            {
                if (i % 5 == 0)
                    multiplesfive.Add(i);
            }

            int add = 0;

            foreach (int number in multiplesthree) //For each multiple of three...
            {
                WriteLine("Number is {0}", number);
                if (multiplesfive.Contains(number)) //If the multiple of three is present in the multiples of five.
                {
                    WriteLine("add = {0} + {1}", add, number);
                    add = add + number; //Then add them up.
                    WriteLine("add = {0}", add);
                }
            }

            return add;

        }

        static void OpClassExo5()
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
                    if (!NCOpClassExo5_ValueIsInTable(table, num, elementsInTable)) //If the number is not in the array...
                    {
                        table[i] = num; //Put the random number in the current cell.
                        elementsInTable += 1; //Add 1 to the elements in the table.
                    }
                    else //If the number IS in the array...
                    {

                        while (NCOpClassExo5_ValueIsInTable(table, num, elementsInTable)) //While the random number is still on the table...
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

        public static bool NCOpClassExo5_ValueIsInTable(int[] table, int num, int elementsInTable)
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

        public static void OpClassExo6()
        {
            WriteLine("This is a simple game.... ");
            System.Threading.Thread.Sleep(2000);
            Clear();
            WriteLine("*Cleares Throat* HmmHmmm...");
            System.Threading.Thread.Sleep(2000);
            Clear();
            bool biggestdecision = true;
            do
            {
                int guess = -1, tries = 0;
                WriteLine("I'm thinking of a number... ok? So... yeah, you gotta guess it :) ");
                System.Threading.Thread.Sleep(2500);
                Clear();
                WriteLine("Let me think... uuhh...");
                System.Threading.Thread.Sleep(2000);
                Clear();
                Random randomness = new Random();
                int from = randomness.Next(1, 50);
                int to = randomness.Next(50, 101);
                int number = randomness.Next(from, to);
                WriteLine("Okay! I got it! :) Number is between {0} and {1}. Come on! Try to guess... I'm gonna help you I swear!", from, to);
                Write("Type your guess: ");
                bool isInt = int.TryParse(ReadLine(), out guess);
                while (!isInt)
                {
                    Write("\nDon't be messing out here kiddo! Type a number:");
                    isInt = int.TryParse(ReadLine(), out guess);
                }
                while (guess != number)
                {
                    if (guess < number)
                    {
                        WriteLine("Nope! It's higher than that...");
                        tries = tries + 1;
                    }

                    if (guess > number)
                    {
                        WriteLine("Nahuh! It's smaller...");
                        tries = tries + 1;
                    }

                    Write("Try again: ");
                    bool isNum = int.TryParse(ReadLine(), out guess);
                    while (!isNum)
                    {
                        Write("\nDon't be messing out here kiddo! Type a number:");
                        isNum = int.TryParse(ReadLine(), out guess);
                    }
                }


                WriteLine("");
                Clear();
                System.Threading.Thread.Sleep(500);
                WriteLine("Well done! You got it in {0} tries!", tries);
                WriteLine("");
                System.Threading.Thread.Sleep(5000);
                WriteLine("");
                System.Threading.Thread.Sleep(500);
                WriteLine("");
                System.Threading.Thread.Sleep(500);
                WriteLine(@"\\//  // \\  || ||    ||    || || ||\ ||");
                System.Threading.Thread.Sleep(500);
                WriteLine(@" )/  ((   )) || ||    \\ /\ // || ||\\||");
                System.Threading.Thread.Sleep(500);
                WriteLine(@"//    \\_//  \\_//     \V/\V/  || || \||");
                System.Threading.Thread.Sleep(500);
                WriteLine("");
                System.Threading.Thread.Sleep(1500);
                Clear();
                System.Threading.Thread.Sleep(200);
                WriteLine(@"               .__          __                        ___.                              ");
                System.Threading.Thread.Sleep(500);
                WriteLine(@"  ___________  |  |  __ ___/  |_     ____   __________\_ |__   ____   ____              ");
                System.Threading.Thread.Sleep(500);
                WriteLine(@" /  ___/\__  \ |  | |  |  \   __\   / ___\_/ __ \_  __ \ __ \_/ __ \ /    \             ");
                System.Threading.Thread.Sleep(500);
                WriteLine(@" \___ \  / __ \|  |_|  |  /|  |    / /_/  >  ___/|  | \/ \_\ \  ___/|   |  \            ");
                System.Threading.Thread.Sleep(500);
                WriteLine(@"/____  >(____  /____/____/ |__|    \___  / \___  >__|  |___  /\___  >___|  / /\  /\  /\ ");
                System.Threading.Thread.Sleep(500);
                WriteLine(@"     \/      \/                   /_____/      \/          \/     \/     \/  \/  \/  \/ ");

                System.Threading.Thread.Sleep(3500);
                Clear();
                System.Threading.Thread.Sleep(500);
                WriteLine(@"   ___ _        _        _        _       _        _     ___ ");
                System.Threading.Thread.Sleep(500);
                WriteLine(@"  / __( )___ __| |_   __| |_ _  _| |___  | |_  ___(_)_ _|__ \");
                System.Threading.Thread.Sleep(500);
                WriteLine(@" | (__|// -_|_-<  _| (_-<  _| || | / -_) | ' \/ -_) | ' \ /_/");
                System.Threading.Thread.Sleep(500);
                WriteLine(@"  \___| \___/__/\__| /__/\__|\_, |_\___| |_||_\___|_|_||_(_) ");
                System.Threading.Thread.Sleep(500);
                WriteLine(@"                             |__/                            ");
                System.Threading.Thread.Sleep(500);
                System.Threading.Thread.Sleep(3500);
                Clear();


                WriteLine("Do you want to play again? (Y / N)");
                string decision = ReadLine(); //While the user enters something different from 'y' or 'n'...
                while (decision == null ||
                       (!decision.Equals("Y", StringComparison.OrdinalIgnoreCase) &&
                        !decision.Equals("N", StringComparison.OrdinalIgnoreCase)))
                {
                    Write("\nUuuh! Come on! Bro, type 'Y' or 'N' (without the single quotes): ");
                    decision = ReadLine();
                }
                if (decision.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    biggestdecision = false;

                    WriteLine("\n----------------------------------------------");
                    WriteLine("            THANKS 4 PLAYING! BYE :)            ");
                    WriteLine("------------------------------------------------");
                    System.Threading.Thread.Sleep(3000);

                }
            } while (biggestdecision);
        }

        public static void OpClassExo7()
        {
            var i = 0;
            var j = 0;
            var largeur = 21;
            var hauteur = 4;
            WriteLine(@"      .--------.");
            WriteLine(@" ____/_____|___ \___");
            WriteLine(@"O    _   - |   _   ,*");
            WriteLine(@" '--(_)-------(_)--'");
            while (true)
            {
                var info = ReadKey(true);
                switch (info.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (i > 0)
                        {
                            MoveBufferArea(i, j, largeur, hauteur, i - 1, j);
                            i--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (i < WindowWidth - largeur)
                        {
                            MoveBufferArea(i, j, largeur, hauteur, i + 1, j);
                            i++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (j > 0)
                        {
                            MoveBufferArea(i, j, largeur, hauteur, i, j - 1);
                            j--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        MoveBufferArea(i, j, largeur, hauteur, i, j + 1);
                        j++;
                        break;
                }
                if (info.Key == ConsoleKey.Q)
                    break;
            }
        }
    }
}