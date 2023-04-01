using TournamentPlayer;

namespace TitForTwoTats
{
    internal class StateOne : IState
    {
        public Strategy PlayerStrategy => Strategy.Cooperate;

        public IState HandleState(Strategy? lastOpponentStrategy)
        {
            if (lastOpponentStrategy == null || lastOpponentStrategy.Value == Strategy.Cooperate)
                return this;

            return new StateTwo();
        }
    }
}