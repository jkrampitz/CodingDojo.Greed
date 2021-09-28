using System.Linq;

namespace CodingDojo.Greed.Scorer
{
    public class SingleOneScorer : IScorer
    {
        public int Index => 0;

        public ScorerResult Check(int[] values)
        {
            var result = new ScorerResult(0, values);
            if (values.Count(x => x == 1) == 1)
            {
                result = new ScorerResult(100, values.Where(val => val != 1).ToArray());
            }
            return result;
        }
    }
}
