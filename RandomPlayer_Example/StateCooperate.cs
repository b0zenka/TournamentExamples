using TournamentPlayer;

namespace RandomPlayer
{
    internal class StateCooperate : RandomState
    {
        public StateCooperate() : base(Strategy.Cooperate) { }

        public override IState HandleState(Strategy? lastOpponentStrategy)
        {
            if (GetRandomValue() <= .5f)
                return new StateDefect();

            return this;
        }
    }
}