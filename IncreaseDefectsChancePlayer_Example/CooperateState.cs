using System;
using TournamentPlayer;

namespace IncreaseDefectsChancePlayer_Example
{
    internal class CooperateState : IState
    {
        private readonly Func<bool> shouldDefect;

        public Strategy PlayerStrategy => Strategy.Cooperate;

        public CooperateState(Func<bool> shouldDefect)
        {
            this.shouldDefect = shouldDefect;
        }

        public IState HandleState(Strategy? lastOpponentStrategy)
        {
            if (lastOpponentStrategy.HasValue && lastOpponentStrategy.Value.Equals(Strategy.Defects))
            {
                //If not cooperate that increase defect chance:
                IncreaseDefectsChancePlayer.CurrentDefectChanceValuce += IncreaseDefectsChancePlayer.IncreaseDefectChanceValue;
            }

            if (shouldDefect.Invoke())
                return new DefectState(shouldDefect);

            return this;
        }
    }
}
