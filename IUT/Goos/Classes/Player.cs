using System;
using System.Linq;
using System.Threading;
using static System.Console;

namespace Goose
{
    class Player
    {
        public int TurnsPlayed { get; private set; }
        public string Name { get; private set; }
        internal int CurrentSpace { get; set; }
        internal bool IsBlocked { get; set; }
        internal int SuspendedTurns { get; private set; }
        public int[] LastValuePlayed { get; private set; }

        private static readonly Random rnd = new Random();

        public Player(String name)
        {
            LastValuePlayed = new int[2];
            Name = name;
        }

        public void Play()
        {
            Speak($"It's my turn, I'm at the space {CurrentSpace}.");
            int result = RollDice();
            MovePawn(result);
            TurnsPlayed++;
        }

        public int RollDice()
        {
            if (!IsBlocked)
            {
                Thread.Sleep(500);
                Speak("Hop!");
                LastValuePlayed[0] = rnd.Next(1, 7);
                LastValuePlayed[1] = rnd.Next(1, 7);
                Speak($"I rolled the dices and I got {LastValuePlayed.Sum()}");
            }
            else
            {
                Speak("I'm blocked and I can't play.");
                if (SuspendedTurns > 0)
                {
                    SuspendedTurns--;
                }
                LastValuePlayed[0] = 0;
                LastValuePlayed[1] = 0;
            }
            return LastValuePlayed.Sum();
        }

        public void MovePawn(int diceResult)
        {

            int finalResult = diceResult + CurrentSpace;
            if (finalResult > Board.NUMBER_OF_SPACES)
            {
                finalResult = (Board.NUMBER_OF_SPACES * 2) - finalResult;

            }
            if (finalResult != CurrentSpace)
            {
                CurrentSpace = finalResult;
                Speak($"I'm moving to the space #{CurrentSpace}");
            }
            Thread.Sleep(500);
        }


        private void Speak(String msg)
        {
            WriteLine($"{Name}: {msg}");
        }

        internal void BlockTwoTurns()
        {
            if (LastValuePlayed.Sum() != 0)
            {
                SuspendedTurns = 2;
                IsBlocked = true;
            }
            else if (SuspendedTurns == 0)
            {
                IsBlocked = false;
            }
        }
    }
}
