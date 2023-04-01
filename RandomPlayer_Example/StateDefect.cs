using TournamentPlayer;

namespace RandomPlayer
{
    internal class StateDefect : RandomState
    {
        public StateDefect() : base(Strategy.Defects) { }

        public override IState HandleState(Strategy? lastOpponentStrategy)
        {
            if (GetRandomValue() <= .5f)
                return new StateCooperate();

            return this;
        }
    }
}