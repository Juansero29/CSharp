using System;
using giCaster;
using giMyMatchData;
using giMatchDisplayTool;
using System.Threading;

namespace MatchTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            TennisCaster x = new TennisCaster();
            TennisCaster.COEFF_TEMPS = TennisCaster.Vélocité.Lent;
            Tournament t = new Tournament(x);
            t.NewMatchCreated += T_NewMatchCreated;
            t.Cast();

            Console.ReadKey();

        }

        private static void T_NewMatchCreated(object sender, MyMatch e)
        {
            Console.WriteLine("\nA match has been created \n" + e + "\n");
            DisplayMatch.Display(e);
            //COMMENT S'ABBONNER AU MATCH? LE CODE EN BAS NE LE FAIT PAS CORRECTEMENT! ON S'ABONNE A UNE RÉFERENCE EXTERNE, PAS AU MATCH DEDANS LE TOURNOI!
            //Tournament t = sender as Tournament;
            //MyMatch m = (MyMatch) t.GetMatch(e.Joueurs[0], e.Joueurs[1]);
            //m.FinishedGame += T_FinishedGame;
            //m.FinishedMatch += T_FinishedGame;
            //m.FinishedPoint += T_FinishedPoint;
            //m.FinishedSet += T_FinishedSet;

            e.FinishedGame += T_FinishedGame;
            e.FinishedMatch += T_FinishedMatch;
            e.FinishedPoint += T_FinishedPoint;
            e.FinishedSet += T_FinishedSet;
            Thread.Sleep(1000);
        }

        private static void T_FinishedGame(object sender, giMyMatchData.Args.WinnerEventArgs e)
        {
            Console.Clear();
            MyMatch m = (MyMatch)sender;
            DisplayMatch.Display(m, null, e.winnerId,e.winnerId);
            Console.WriteLine($"\nA game has finished! The winner is {m[e.winnerId]}\n");
        }

        private static void T_FinishedPoint(object sender, giMyMatchData.Args.WinnerEventArgs e)
        {
            Console.Clear();
            MyMatch m = (MyMatch)sender;
           DisplayMatch.Display(m, e.winnerId, null, e.winnerId);
            Console.WriteLine($"\nA point has been made, the point maker is {m[e.winnerId]}\n");
        }

        private static void T_FinishedSet(object sender, giMyMatchData.Args.WinnerEventArgs e)
        {
            Console.Clear();
            MyMatch m = (MyMatch)sender;
            DisplayMatch.Display(m, null, null, e.winnerId);
            Console.WriteLine($"\nA set has finished, the set winner is {m[e.winnerId]}\n");
        }

        private static void T_FinishedMatch(object sender, giMyMatchData.Args.WinnerEventArgs e)
        {
            Console.Clear();
            MyMatch m = (MyMatch)sender;
            DisplayMatch.Display(m, null, null, e.winnerId);
            Console.WriteLine($"\n\nThe match has finished! The winner is {m[e.winnerId]} ! Congrats! \n\n");
        }
    }
}
