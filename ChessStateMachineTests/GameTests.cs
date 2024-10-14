using ChessDomain;
using ChessDomain.Moves;

namespace ChessDomainTests
{
    public class GameTests
    {
        [Fact]
        public void White_player_moves_first()
        {
            var game = new Game();

            game.PlayerMove();

            Assert.Equal(Player.WhitePlayer, game.GetState().GetPlayer());
        }

        [Fact]
        public void Black_player_moves_second()
        {
            var game = new Game();

            game.PlayerMove();
            game.PlayerMove();

            Assert.Equal(Player.BlackPlayer, game.GetState().GetPlayer());
        }
    }
}