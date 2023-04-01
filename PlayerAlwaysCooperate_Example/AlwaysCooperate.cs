using TournamentPlayer;

namespace PlayerAlwaysCooperate
{
    public class AlwaysCooperate : Player
    {
        public AlwaysCooperate() : base("Always Cooperate", new StateCooperate()) { }
    }
}