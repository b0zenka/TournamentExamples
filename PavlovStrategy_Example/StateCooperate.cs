using TournamentPlayer;

namespace PavlovStrategy
{
    internal class StateCooperate : IState
    {
        public Strategy PlayerStrategy => Strategy.Cooperate;

        public IState HandleState(Strategy? lastOpponentStrategy)
        {
            if (lastOpponentStrategy == null || lastOpponentStrategy == Strategy.Cooperate)
                return this;

            return new StateDefect();
        }
    }
}