using System;
using System.Collections.Generic;
using System.Text;

namespace CodingDojo.Greed
{
    public interface IScorer
    {
        ScorerResult Check(int[] values);
        int Index { get; }
    }
}
