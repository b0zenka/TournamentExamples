using System;
using TournamentPlayer;

namespace HardJoss_Example
{
    internal class StateDefect : IState
    {
        public Strategy PlayerStrategy => Strategy.Defects;

        public IState HandleState(Strategy? lastOpponentStrategy)
        {
            if (lastOpponentStrategy == null)
                throw new ArgumentNullException();

            if (lastOpponentStrategy == Strategy.Defects) 
                return this;

            return new StateCooperate();
        }
    }
}
