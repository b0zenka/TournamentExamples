using System;
using TournamentPlayer;

namespace IncreaseDefectsChancePlayer_Example
{
    public class IncreaseDefectsChancePlayer : Player
    {
        private static float currentDefectChanceValuce = 0.01f;
        private static readonly Random random = new Random();

        public static float IncreaseDefectChanceValue => .25f;
        public static float CurrentDefectChanceValuce
        {
            get => currentDefectChanceValuce;
            set => currentDefectChanceValuce = value.Clamp01();
        }

        public IncreaseDefectsChancePlayer() : base("Increase Defects Chance", new CooperateState(ShouldDefect)) { }

        private static bool ShouldDefect()
        {
            return random.NextDouble() <= CurrentDefectChanceValuce;
        }
    }
}
