using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingDojo.Greed.Tests
{
    [TestClass]
    public class GreedTests
    {
        private readonly Greed _greed;

        public GreedTests()
        {
            _greed = new Greed();
        }

        [TestMethod]
        [DataRow(new int[] { 1 }, 100)]
        [DataRow(new int[] { 1,2 }, 100)]
        [DataRow(new int[] { 1, 5 }, 150)]
        public void Score(int[] values, int expectedResult)
        {
            var result = _greed.Score(values);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
