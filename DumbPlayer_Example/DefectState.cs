using TournamentPlayer;

namespace DumbPlayer_Example
{
    internal class DefectState : IState
    {
        public Strategy PlayerStrategy => Strategy.Defects;

        public IState HandleState(Strategy? lastOpponentStrategy)
        {
            if (lastOpponentStrategy.HasValue && !lastOpponentStrategy.Value.Equals(PlayerStrategy))
                return this;

            return new CooperateState();
        }
    }
}
