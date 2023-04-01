using System;
using TournamentPlayer;

namespace TitForTwoTats
{
    internal class StateThree : IState
    {
        public Strategy PlayerStrategy => Strategy.Defects;

        public IState HandleState(Strategy? lastOpponentStrategy)
        {
            if (lastOpponentStrategy == null)
                throw new ArgumentNullException(nameof(lastOpponentStrategy));

            if (lastOpponentStrategy.Value == Strategy.Defects)
                return this;

            return new StateOne();
        }
    }
}