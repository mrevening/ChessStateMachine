namespace ChessDomain.Moves
{
    public class BlackMove : Move
    {
        private readonly Player _player;
        public BlackMove() { _player = Player.BlackPlayer; }

        public Player GetPlayer() => _player;
        public void PerformMove(Game game)
        {
            game.SetState(new WhiteMove());
        }
    }
}
