using TournamentPlayer;

namespace DumbPlayer_Example
{
    internal class CooperateState : IState
    {
        public Strategy PlayerStrategy => Strategy.Cooperate;

        public IState HandleState(Strategy? lastOpponentStrategy)
        {
            if (lastOpponentStrategy.HasValue && !lastOpponentStrategy.Value.Equals(PlayerStrategy))
                return this;

            return new DefectState();
        }
    }
}
