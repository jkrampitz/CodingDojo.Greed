using System.Linq;

namespace CodingDojo.Greed.Scorer
{
    public class StraightScorer : IScorer
    {
        public int Index => 5;
        public ScorerResult Check(int[] values)
        {
            var result = new ScorerResult(0, values);
            if (values.OrderBy(x => x).SequenceEqual(new int[] {1, 2, 3, 4, 5, 6}))
                result = new ScorerResult(1200, new int[0]);
            return result;
        }

        
    }
}
