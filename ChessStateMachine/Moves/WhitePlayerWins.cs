namespace ChessDomain.Moves
{
    public class WhitePlayerWins : Move
    {
        private readonly Player _player;
        public WhitePlayerWins() { _player = Player.WhitePlayer; }

        public Player GetPlayer() => _player;
        public void PerformMove(Game game)
        {
            game.SetState(new WhiteMove());
        }
    }
}
