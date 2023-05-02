using System;
using TournamentPlayer;

namespace NaiveProber_Example
{
    internal class StateDefect : StateRandom
    {
        public StateDefect() : base(Strategy.Defects) { }

        public override IState HandleState(Strategy? lastOpponentStrategy)
        {
            if (lastOpponentStrategy == null)
                throw new ArgumentNullException();

            if (lastOpponentStrategy == Strategy.Defects || GetRandomValue() <= 0.1f) 
                return this;

            return new StateCooperate();
        }
    }
}
