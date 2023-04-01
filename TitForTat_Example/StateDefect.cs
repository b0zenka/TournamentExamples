using System;
using TournamentPlayer;

namespace TitForTat
{
    internal class StateDefect : IState
    {
        public Strategy PlayerStrategy => Strategy.Defects;

        public IState HandleState(Strategy? lastOpponentStrategy)
        {
            if (lastOpponentStrategy == null)
                throw new ArgumentNullException(nameof(lastOpponentStrategy));

            if (lastOpponentStrategy.Value == Strategy.Cooperate)
                return new StateCooperate();

            return this;
        }
    }
}