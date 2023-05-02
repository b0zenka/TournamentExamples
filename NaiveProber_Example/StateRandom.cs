using System;
using TournamentPlayer;

namespace NaiveProber_Example
{
    internal abstract class StateRandom : IState
    {
        private readonly Random random;
        public Strategy PlayerStrategy { get; }

        protected StateRandom(Strategy playerStrategy)
        {
            PlayerStrategy = playerStrategy;
            random = new Random();
        }

        public abstract IState HandleState(Strategy? lastOpponentStrategy);

        protected double GetRandomValue() => random.NextDouble();
    }
}
