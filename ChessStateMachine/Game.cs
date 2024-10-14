using ChessDomain.Moves;

namespace ChessDomain
{
    public class Game
    {
        private Move _currentState;

        public Game()
        {
            _currentState = new WhiteMove();
        }

        public void SetState(Move state) => _currentState = state;
        public Move GetState() => _currentState;

        public void PlayerMove()
        {
            _currentState.PerformMove(this);
        }
    }
}
