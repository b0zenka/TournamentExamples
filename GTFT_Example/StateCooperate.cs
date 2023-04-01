using TournamentPlayer;

namespace GTFT
{
    internal sealed class StateCooperate : StateRandom
    {
        public StateCooperate() : base(Strategy.Cooperate) { }

        public override IState HandleState(Strategy? lastOpponentStrategy)
        {
            if (lastOpponentStrategy == null || lastOpponentStrategy == Strategy.Cooperate)
                return this;

            var forgiveChance = GetRandomValue();

            if (forgiveChance > (1 / 3f))
                return new StateDefect();

            return new StateCooperateForgive();
        }
    }
}