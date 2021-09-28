using System.Collections.Generic;
using CodingDojo.Greed.Scorer;

namespace CodingDojo.Greed
{
    public class ScorerRepository
    {
        public List<IScorer> GetScorers()
        {
            return new List<IScorer>
            {
                new SingleOneScorer(),
                new SingleFiveScorer(),
                new MoreThenThreeScorer(),
                new StraightScorer(),
                new ThreePairScorer()
            };
        }
    }
}
