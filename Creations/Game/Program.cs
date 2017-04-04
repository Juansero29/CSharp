using System;
using static System.Console;

namespace Test
{
    class Program
    {
        private static void Main(string[] args)
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
    }
}

