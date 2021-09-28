using System;
using System.Linq;

namespace CodingDojo.Greed
{
    public class Greed
    {
        private readonly ScorerRepository _scorerRepository;

        public Greed()
        {
            _scorerRepository = new ScorerRepository();
        }

        public int Score(int[] values)
        {
            if (values == null || values.Length == 0 || values.Length > 6 || values.Any(x => x > 6) ||
                values.Any(x => x < 1))
                throw new ArgumentException();
            var scorers = _scorerRepository.GetScorers();
            int final = 0;
            int[] unusedValues = values;
            foreach (var scorer in scorers.OrderBy(x => x.Index))
            {
                var result = scorer.Check(unusedValues);
                final += result.Score;
                unusedValues = result.UnusedValues;
            }
            return final;
        }
    }
}
