
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
        public virtual void Activate(Player p, int diceResult)
        {

        }
    }

    class BlockedSpace : Space
    {
        private Player BlockedPlayer { get; set; }

        public BlockedSpace() : base(){}

        public override void Activate(Player p, int diceResult)
        {
            if(p != null)
            {
                base.Activate(p, diceResult);
                if (BlockedPlayer == null)
                {
                    BlockedPlayer = p;
                }
                if (p != BlockedPlayer)
                {
                    BlockedPlayer.IsBlocked = false;
                    p.IsBlocked = true;
                    BlockedPlayer = p;
                }

            }
        }
     }

    class HotelSpace : Space
    {
        public HotelSpace() : base() { }

        public override void Activate(Player p, int diceResult)
        {
            base.Activate(p, diceResult);
            p.BlockTwoTurns();
        }
    }

    class TeleportSpace : Space
    {

    }
}
