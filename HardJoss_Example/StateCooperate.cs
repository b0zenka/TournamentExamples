using TournamentPlayer;

namespace HardJoss_Example
{
    internal class StateCooperate : StateRandom
    {
        public StateCooperate() : base(Strategy.Cooperate) { }
        public override IState HandleState(Strategy? lastOpponentStrategy)
        {
            if (lastOpponentStrategy == null) 
                return this;

            if (lastOpponentStrategy == Strategy.Defects || GetRandomValue() <= 0.1f)
                return new StateDefect();

            return this;
        }
    }
}
