using TournamentPlayer;

namespace RandomPlayer
{
    public class Random : Player
    {
        public Random() : base("Random", new StateCooperate()) { }
    }
}