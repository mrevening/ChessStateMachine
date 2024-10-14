namespace ChessDomain
{
    public interface Move
    {
        public Player GetPlayer();
        public void PerformMove(Game game);
    }
}
