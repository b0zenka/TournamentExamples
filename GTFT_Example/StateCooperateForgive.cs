using System;
using TournamentPlayer;

namespace GTFT
{
    internal sealed class StateCooperateForgive : StateRandom
    {
        public StateCooperateForgive() : base(Strategy.Cooperate) { }

        public override IState HandleState(Strategy? lastOpponentStrategy)
        {
            if (lastOpponentStrategy == null)
                throw new ArgumentNullException();

            if (lastOpponentStrategy == Strategy.Cooperate)
                return new StateCooperate();

            var forgiveChance = GetRandomValue();

            if (forgiveChance > (1 / 3f))
                return new StateDefect();

            return this;
        }
    }
}