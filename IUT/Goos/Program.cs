
namespace Goos
{
    class Program
    {
        static void Main(string[] args)
        {
            Board b = new Board();
            Player p0 = new Player("Gerben");
            Player p1 = new Player("Juan");
            Player p2 = new Player("Toto");

            //b pourrait accepter plusieurs joueurs dans cette méthode.
            b.AddPlayer(p0);
            b.AddPlayer(p1);
            b.AddPlayer(p2);


            b.Start();

        }
    }
}
