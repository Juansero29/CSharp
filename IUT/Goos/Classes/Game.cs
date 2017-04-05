﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goos
{
    class Game
    {

        private static readonly int NUMBER_OF_PLAYERS = 4; //Total number of possible players.

        Board Board = new Board();
   
        Player[] Players = new Player[NUMBER_OF_PLAYERS];
        private bool IsFinished;
        private Player NextPlayer { get; set; }
        private int Index
        {
            get { return mIndex; }
            set { mIndex = value % NUMBER_OF_PLAYERS; } //Index will always be a value between 0 and NUMBER_OF_PLAYERS - 1, so we can get elements from the 'Players' array.
        }
        private int mIndex; //Variable to control the value of 'Index'.

        public void Start()
        {
            Player FirstPlayer = DoTheFirstRound(Players);
            Index = Array.IndexOf(Players, FirstPlayer); //Gets the index of the FirstPlayer to make him play.

            //The first player plays and is moved accordingly to his result
            Console.WriteLine("\n -- STARTING GAME -- \n");
            NextPlayer = Players[Index];
            MovePlayer(NextPlayer, NextPlayer.Play());
            Console.WriteLine("\n");

            while (!IsFinished) //While the game is not finished...
            {

                NextPlayer = Players[Index]; //The next player is the player at the Index's value.
                if (NextPlayer != null)
                {
                    MovePlayer(NextPlayer, NextPlayer.Play()); //If it isn't null, we make him Play and we move him.
                }
                else
                {
                    Index++; //If it is null, we skip it.
                }
                if (NextPlayer != null && NextPlayer.CurrentSpace >= Board.NUMBER_OF_SPACES)
                {
                    IsFinished = true; //Game is finished when NextPlayer is not null and his current space is equal to the last space avaible.
                    Console.WriteLine($"\n -- GAME FINISHED! WINNER IS {NextPlayer.Name}  -- \n");
                }
                Console.WriteLine("\n");
            }
        }

        //Moves a player to +diceResult spaces from his current space.
        public void MovePlayer(Player p, int diceResult)
        {
            p.CurrentSpace = p.CurrentSpace + diceResult;
            Index++; //We now the next player in the array must play, so we increment the Index of one...
        }


        //Adds a player to the game.
        public void AddPlayer(Player p)
        {
            Players[Index] = p;
            Index++;
        }


        //Makes all the players play once and returns the player who had the highest number.
        private Player DoTheFirstRound(Player[] players)
        {
            Console.WriteLine("\n -- DOING DECISION ROUND -- \n");
            Player mStartingPlayer = null;
            int[] results = new int[4];
            foreach (Player p in Players)
            {
                if (p != null)
                {
                    p.Play(); //We make everyone roll the dices...
                }
            }

            for (int i = 0; i < results.Length; i++)
            {
                if (Players[i] != null)
                {
                    results[i] = Players[i].LastValuePlayed; //We stock the last values in an array.
                }
            }

            for (int i = 0; i < results.Length; i++)
            {
                if (Players[i] != null && Players[i].LastValuePlayed == results.Max()) //We get the max number in the array and compare it to each of the player's last value played in order to get the right player.
                {
                    mStartingPlayer = Players[i]; //We stock the player in a variable to return...
                }
            }
            Console.WriteLine("\n -- FINISHING DECISION ROUND -- \n");
            return mStartingPlayer; //We return the variable.
        }
    }
}
