using TournamentPlayer;

namespace RandomPlayer
{
    internal abstract class RandomState : IState
    {
        private readonly System.Random random;
        public Strategy PlayerStrategy { get; }

        public RandomState(Strategy playerStrategy)
        {
            PlayerStrategy = playerStrategy;
            random = new System.Random();
        }

        public abstract IState HandleState(Strategy? lastOpponentStrategy);

        protected double GetRandomValue() => random.NextDouble();
    }
}