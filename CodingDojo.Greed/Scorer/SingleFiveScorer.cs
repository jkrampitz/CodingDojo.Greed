using System.Linq;

namespace CodingDojo.Greed.Scorer
{
    class SingleFiveScorer : IScorer
    {
        public int Index => 0;

        public ScorerResult Check(int[] values)
        {
            var result = new ScorerResult(0, values);
            if (values.Count(x => x == 5) == 1)
            {
                result = new ScorerResult(50, values.Where(val => val != 5).ToArray());
            }
            return result;
        }
    }
}
