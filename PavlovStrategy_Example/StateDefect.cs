using System;
using TournamentPlayer;

namespace PavlovStrategy
{
    internal class StateDefect : IState
    {
        public Strategy PlayerStrategy => Strategy.Defects;

        public IState HandleState(Strategy? lastOpponentStrategy)
        {
            if (lastOpponentStrategy == null)
                throw new ArgumentNullException();

            if (lastOpponentStrategy == Strategy.Cooperate)
                return this;

            return new StateCooperate();
        }
    }
}