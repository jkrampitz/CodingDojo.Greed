using System.Collections.Generic;
using System.Linq;

namespace CodingDojo.Greed.Scorer
{
    public class MoreThenThreeScorer : IScorer
    {
        public int Index => 1;
        public ScorerResult Check(int[] values)
        {
            var ununsedValues = values;
            var score = 0;
            foreach (var multiplicator in Multiplicators)
            {
                var count = ununsedValues.Count(x => x == multiplicator.Key);
                switch (count)
                {
                    case 3:
                        score += multiplicator.Value;
                        break;
                    case 4:
                        score += multiplicator.Value * 2;
                        break;
                    case 5:
                        score += multiplicator.Value * 4;
                        break;
                    case 6:
                        score += multiplicator.Value * 8;
                        break;
                }
                if(count >= 3)
                    ununsedValues = ununsedValues.Where(val => val != multiplicator.Key).ToArray();
            }
           
            return new ScorerResult(score, ununsedValues);
        }

        private Dictionary<int, int> Multiplicators = new Dictionary<int, int>()
        {
            {1, 1000},
            {2, 200},
            {3, 300},
            {4, 400},
            {5, 500},
            {6, 600}
        };

    }
}
