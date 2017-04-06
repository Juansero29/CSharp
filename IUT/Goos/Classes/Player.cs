using System;
using System.Linq;
using System.Threading;
using static System.Console;

namespace Goos
{
    class Player
    {
        public int TurnsPlayed { get; private set; }
        public string Name { get; private set; }
        internal int CurrentSpace { get; set; }
        internal bool IsBlocked { get; set; }
        private int SuspendedTurns { get; set; }
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
                Thread.Sleep(50);
                Speak("Hop!");
                LastValuePlayed[0] = rnd.Next(1, 7);
                LastValuePlayed[1] = rnd.Next(1, 7);
                Speak($"I rolled the dices and I got {LastValuePlayed.Sum()}");
                return LastValuePlayed.Sum();
            }
            else
            {
                if (SuspendedTurns > 0)
                {
                    Speak("I'm blocked and I can't play.");
                    SuspendedTurns--;
                }
                return 0;
            }
        }

        public void MovePawn(int diceResult)
        {

            int finalResult = diceResult + CurrentSpace;
            if (finalResult > Board.NUMBER_OF_SPACES)
            {
                finalResult = (Board.NUMBER_OF_SPACES * 2) - finalResult;

            }

            CurrentSpace = finalResult;

            Speak($"I'm moving to the space #{CurrentSpace}");
            Thread.Sleep(50);
        }
      

        private void Speak(String msg)
        {
            WriteLine($"{Name}: {msg}");
        }

        internal void BlockTwoTurns()
        {
            if (SuspendedTurns == 0)
            {
                IsBlocked = false;
            }
            SuspendedTurns = 2;
            IsBlocked = true;
        }
    }
}
