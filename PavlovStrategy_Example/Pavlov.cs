using TournamentPlayer;

namespace PavlovStrategy
{
    public class Pavlov : Player
    {
        public Pavlov() : base("Pavlov", new StateCooperate()) { }
    }
}