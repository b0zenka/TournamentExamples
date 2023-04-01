using System;
using TournamentPlayer;

namespace GTFT
{
    internal sealed class StateDefect : StateRandom
    {
        public StateDefect() : base(Strategy.Defects) { }

        public override IState HandleState(Strategy? lastOpponentStrategy)
        {
            if (lastOpponentStrategy == null)
                throw new ArgumentNullException();

            if (lastOpponentStrategy == Strategy.Cooperate)
                return new StateCooperate();

            var forgiveChance = GetRandomValue();

            if (forgiveChance <= (1 / 3f))
                return new StateCooperateForgive();

            return this;
        }
    }
}