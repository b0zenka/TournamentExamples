using TournamentPlayer;

namespace PlayerAlwaysCooperate
{
    internal class StateCooperate : IState
    {
        public Strategy PlayerStrategy => Strategy.Cooperate;

        public IState HandleState(Strategy? lastOpponentStrategy)
        {
            return this;
        }
    }
}