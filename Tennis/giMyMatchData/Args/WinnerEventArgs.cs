namespace giMyMatchData.Args
{
    public class WinnerEventArgs
    {
        public int winnerId { get; private set; }

        public WinnerEventArgs(int winnerId)
        {
            this.winnerId = winnerId;
        }
    }
}
