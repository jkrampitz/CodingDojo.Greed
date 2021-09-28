using System.Linq;

namespace CodingDojo.Greed.Scorer
{
    public class ThreePairScorer : IScorer
    {
        public int Index => 5;
        public ScorerResult Check(int[] values)
        {
            var result = new ScorerResult(0, values);
            int pairs = 0;
            for (int i = 1; i <= 6; i++)
            {
                if (values.Count(x => x == i) == 2)
                    pairs++;
            }

            if (pairs == 3)
                result = new ScorerResult(800, new int[0]);
            return result;
        }
    }
}
