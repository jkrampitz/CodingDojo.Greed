using System;
using System.Collections.Generic;
using System.Text;

namespace CodingDojo.Greed
{
    public class ScorerResult
    {
        public int Score { get; }
        public int[] UnusedValues { get; }

        public ScorerResult(int score, int[] unusedValues)
        {
            Score = score;
            UnusedValues = unusedValues;
        }
    }
}
