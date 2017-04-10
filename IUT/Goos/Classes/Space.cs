using System.Linq;
using static System.Console;

namespace Goos
{
    class Space
    {

        //Dans le constructeur on peut savoir si une case est spéciale ou pas.
        //Dans le constructeur de jeu on pourrait indiquer les cases qu'on veut rendre spéciales.  
        public Space()
        {
        }

        //Méthode qui permet de déclencher les actions spécifiques à cette case.
        public virtual void Activate(Player p, int[] diceResult)
        {
        }
    }

    class BlockedSpace : Space
    {
        private Player BlockedPlayer { get; set; }

        public BlockedSpace() : base() { }

        public override void Activate(Player p, int[] diceResult)
        {
            if (p != null)
            {
                base.Activate(p, diceResult);
                if (BlockedPlayer == null)
                {
                    BlockedPlayer = p;
                    p.IsBlocked = true;
                }
                if (p != BlockedPlayer)
                {
                    BlockedPlayer.IsBlocked = false;
                    BlockedPlayer = p;
                }

                p.IsBlocked = true;

            }
        }
    }

    class HotelSpace : Space
    {
        public HotelSpace() : base() { }

        public override void Activate(Player p, int[] diceResult)
        {
            base.Activate(p, diceResult);

            p.BlockTwoTurns();
        }
    }

    class TeleportSpace : Space
    {
        public TeleportSpace() : base() { }

        public override void Activate(Player p, int[] diceResult)
        {
            base.Activate(p, diceResult);

            if (p.TurnsPlayed == 1 && p.LastValuePlayed[0] == 6 && p.LastValuePlayed[1] == 3)
            {
                WriteLine($"Player {p.Name} has been moved to case 26. (they played 6 and 3 in their first turn)");
                p.CurrentSpace = 26;
            }

            if (p.TurnsPlayed == 1 && p.LastValuePlayed[0] == 4 && p.LastValuePlayed[1] == 5)
            {
                WriteLine($"Player {p.Name} has been moved to case 53! (they played 4 and 5 in their first turn)");
                p.CurrentSpace = 53;
            }

            if (p.CurrentSpace == 6)
            {
                WriteLine($"Player {p.Name} has been moved to case 12! (they arrived at space # 6)");
                p.CurrentSpace = 12;
            }

            if (p.CurrentSpace == 42)
            {
                WriteLine($"Player {p.Name} has been moved to case 30! (they arrived at space # 42, there's a laberynth! )");
                p.CurrentSpace = 30;
            }

            if (p.CurrentSpace == 58)
            {
                WriteLine($"Player {p.Name} has died! Moving to space 0 (they arrived at space # 58! )");
                p.CurrentSpace = 0;
            }
        }
    }
}
