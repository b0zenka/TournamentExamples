using System;
using TournamentPlayer;

namespace ZDGTFT2
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

            if (forgiveChance > (1 / 8f))
                return new StateDefect();

            return this;
        }
    }
}