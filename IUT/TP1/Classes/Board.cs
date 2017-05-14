using System;
using System.Linq;

namespace Goose
{
    class Board
    {

        internal static readonly int numberOfSpaces = 64; //Total number of spaces in the board.

        internal static int NUMBER_OF_SPACES { get { return numberOfSpaces - 1; } }

        Space[] Spaces = new Space[numberOfSpaces];

        public Board()
        {
            FillSpaces();
        }

        private void FillSpaces()
        {
            for (int i = 0; i < Spaces.Length; i++)
            {
                Spaces[i] = new Space();

                if (i == 9)
                {
                    Spaces[i] = new TeleportSpace();
                }

                if (i == 19)
                {
                    Spaces[i] = new HotelSpace();
                }

                if (i == 31)
                {
                    Spaces[i] = new BlockedSpace();
                }

                if (i == 42) {
                    Spaces[i] = new TeleportSpace();
                }

                if (i == 52)
                {
                    Spaces[i] = new BlockedSpace();
                }

                if (i == 58)
                {
                    Spaces[i] = new TeleportSpace();
                }
            }
            //Fills up every space of the array with the corresponding spaces.
        }

        public void ActivateSpace(Player p, int index)
        {
            Spaces[index].Activate(p, p.LastValuePlayed);
        }

    }
}
