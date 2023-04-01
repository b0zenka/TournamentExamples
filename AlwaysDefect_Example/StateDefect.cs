using TournamentPlayer;

namespace AlwaysDefect
{
    internal class StateDefect : IState
    {
        public Strategy PlayerStrategy => Strategy.Defects;

        public IState HandleState(Strategy? lastOpponentStrategy)
        {
            return this;
        }
    }
}