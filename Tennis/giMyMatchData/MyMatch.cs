using System;
using giMyMatchData.Args;
using giMatchData;

namespace giMyMatchData
{
    public class MyMatch : Match
    {

        public MyMatch(string player1, string player2) : base(player1, player2)
        {

        }

        public event EventHandler<WinnerEventArgs> FinishedPoint;
        public event EventHandler<WinnerEventArgs> FinishedGame;
        public event EventHandler<WinnerEventArgs> FinishedSet;
        public event EventHandler<WinnerEventArgs> FinishedMatch;

        public override void AddPt(int id)
        {
            base.AddPt(id);
            OnPointFini(id);
            if (Fini)
            {
                OnMatchFini(id);
            }
        }


        protected override void OnJeuFini(int winnerId)
        {

            base.OnJeuFini(winnerId);
            FinishedGame?.Invoke(this, new WinnerEventArgs(winnerId));
            if (Fini)
            {
                OnMatchFini(winnerId);
            }

        }

        protected override void OnSetFini(int winnerId)
        {
            base.OnSetFini(winnerId);
            FinishedSet?.Invoke(this, new WinnerEventArgs(winnerId));
            if (Fini)
            {
                OnMatchFini(winnerId);
            }
        }

        protected override void OnPointFini(int vainqueurId)
        {
            base.OnPointFini(vainqueurId);
            FinishedPoint?.Invoke(this, new WinnerEventArgs(vainqueurId));
            if (Fini)
            {
                OnMatchFini(vainqueurId);
            }
        }

        protected override void OnMatchFini(int vainqueurId)
        {
            base.OnMatchFini(vainqueurId);
            FinishedMatch?.Invoke(this, new WinnerEventArgs(vainqueurId));
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (this == obj) return true;
            if (GetType() != obj.GetType()) return false;
            MyMatch other = (MyMatch)obj;
            if (!other.Joueurs[0].Equals(Joueurs[0]) || !other.Joueurs[1].Equals(Joueurs[1])) return false;
            return other.Fini.Equals(Fini);
        }
    }
}
