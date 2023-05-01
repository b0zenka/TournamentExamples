using System;
using TournamentPlayer;

namespace IncreaseDefectsChancePlayer_Example
{
    internal class DefectState : IState
    {
        private readonly Func<bool> shouldDefect;

        public Strategy PlayerStrategy => Strategy.Defects;

        public DefectState(Func<bool> shouldDefect)
        {
            this.shouldDefect = shouldDefect;
        }

        public IState HandleState(Strategy? lastOpponentStrategy)
        {
            if (lastOpponentStrategy.HasValue && lastOpponentStrategy.Value.Equals(Strategy.Defects))
            {
                //If defects that increase defect chance:
                IncreaseDefectsChancePlayer.CurrentDefectChanceValuce += IncreaseDefectsChancePlayer.IncreaseDefectChanceValue;
            }

            if (shouldDefect.Invoke())
                return this;

            return new CooperateState(shouldDefect);
        }
    }
}
