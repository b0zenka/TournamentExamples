using System;
using TournamentPlayer;

namespace TitForTwoTats
{
    internal class StateTwo : IState
    {
        public Strategy PlayerStrategy => Strategy.Cooperate;

        public IState HandleState(Strategy? lastOpponentStrategy)
        {
            if (lastOpponentStrategy == null)
                throw new ArgumentNullException(nameof(lastOpponentStrategy));

            if (lastOpponentStrategy.Value == Strategy.Cooperate)
                return new StateOne();

            return new StateThree();
        }
    }
}