
namespace Goos
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();
            Player p0 = new Player("Gerben");
            Player p1 = new Player("Juan");
            Player p2 = new Player("Toto");

            //b pourrait accepter plusieurs joueurs dans cette méthode.
            g.AddPlayer(p0);
            g.AddPlayer(p1);
            g.AddPlayer(p2);

            g.Start();

        }
    }
}
