using TournamentPlayer;

namespace GRIM
{
    internal class StateCooperate : IState
    {
        public Strategy PlayerStrategy => Strategy.Cooperate;

        public IState HandleState(Strategy? lastOpponentStrategy)
        {
            if (lastOpponentStrategy == null || lastOpponentStrategy.Value == Strategy.Cooperate)
                return this;

            return new StateDefect();
        }
    }
}