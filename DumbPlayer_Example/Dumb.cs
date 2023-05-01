using TournamentPlayer;

namespace DumbPlayer_Example
{
    public class Dumb : Player
    {
        public Dumb() : base("Dumb", new CooperateState())
        {
        }
    }
}
