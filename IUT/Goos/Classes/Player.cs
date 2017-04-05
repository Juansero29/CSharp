using System;
using System.Threading;
using static System.Console;

namespace Goos
{
    class Player
    {
        public string Name { get; private set; }
        internal int CurrentSpace { get; set; }
        internal bool IsBlocked { get; set; }
        private int SuspendedTurns { get; set; }
        public int LastValuePlayed { get; private set; }

        private static readonly Random rnd = new Random();

        public Player(String name)
        {
            Name = name;
        }

        public void Play()
        {
            Speak($"It's my turn, I'm at the space {CurrentSpace}.");
            int result = RollDice(); 
            MovePlayer(result);
        }

        public int RollDice()
        {
            if (!IsBlocked)
            {
                Thread.Sleep(50);
                Speak("Hop!");
                LastValuePlayed = rnd.Next(1, 6) + rnd.Next(1, 6);
                Speak($"I rolled the dices and I got {LastValuePlayed}");
                return LastValuePlayed;
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

        public void MovePlayer(int diceResult)
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
