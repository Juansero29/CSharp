using giMatchData;
using giCaster;
using System;
using System.Collections.Generic;
using giMyMatchData.Args;

namespace giMyMatchData
{
    public class Tournament
    {
        public IEnumerable<IMatch> Matchs
        {
            get { return matchs; }
        }
        private List<IMatch> matchs = new List<IMatch>();
        private TennisCaster mTennisCaster;
        public event EventHandler<MyMatch> NewMatchCreated;

        public Tournament(TennisCaster tenniscaster)
        {

            mTennisCaster = tenniscaster;
            mTennisCaster.PointGagné += TenniscasterPointWon;
        }

        public void Cast()
        {
            mTennisCaster.Cast();
        }

        private void AddMatch(string player1, string player2)
        {
            IMatch m = new MyMatch(player1, player2);
            matchs.Add(m);
            OnNewMatchAdded((MyMatch) m);
        }

        public IMatch GetMatch(string player1, string player2)
        {
            foreach (IMatch m in Matchs)
            {
                if (m[0].Equals(player1) && m[1].Equals(player2) || m[1].Equals(player1) && m[0].Equals(player2))
                {
                    return m;
                }
            }
            AddMatch(player1, player2);
            return new Match(player1, player2);
        }



        public void OnNewMatchAdded(MyMatch m)
        {
            NewMatchCreated?.Invoke(this, m);
        }

        private void TenniscasterPointWon(object sender, TennisCaster.PointGagnéEventArgs e)
        {
            IMatch match = GetMatch(e.Vainqueur, e.Perdant);
            match.AddPt(match.Joueurs.IndexOf(e.Vainqueur));
        }

    }
}
