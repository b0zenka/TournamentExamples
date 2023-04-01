using System;
using TournamentPlayer;

namespace ZDGTFT2
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

            if (forgiveChance <= (1 / 4f))
                return new StateCooperateForgive();

            return this;
        }
    }
}