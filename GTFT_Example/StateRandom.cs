using System;
using TournamentPlayer;

namespace GTFT
{
    internal abstract class StateRandom : IState
    {
        private readonly Random random;
        public Strategy PlayerStrategy { get; }

        public StateRandom(Strategy playerStrategy)
        {
            PlayerStrategy = playerStrategy;
            random = new Random();
        }

        public abstract IState HandleState(Strategy? lastOpponentStrategy);

        protected double GetRandomValue() => random.NextDouble();
    }
}