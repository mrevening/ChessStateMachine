namespace ChessDomain.Moves
{
    public class WhiteMove : Move
    {
        private readonly Player _player;
        public WhiteMove() { _player = Player.WhitePlayer; }

        public Player GetPlayer() => _player;
        public void PerformMove(Game game)
        {
            game.SetState(new BlackMove());
        }
    }
}
