using System;
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
        [DataRow(new int[] { 1, 1 }, 0)]
        [DataRow(new int[] { 5 }, 50)]
        [DataRow(new int[] { 5, 5 }, 0)]
        [DataRow(new int[] { 1, 2 }, 100)]
        [DataRow(new int[] { 1, 5 }, 150)]
        [DataRow(new int[] { 1, 1, 1 }, 1000)]
        [DataRow(new int[] { 2, 2, 2 }, 200)]
        [DataRow(new int[] { 3, 3, 3 }, 300)]
        [DataRow(new int[] { 4, 4, 4 }, 400)]
        [DataRow(new int[] { 5, 5, 5 }, 500)]
        [DataRow(new int[] { 5, 2, 5, 4, 5 }, 500)]
        [DataRow(new int[] { 6, 6, 6 }, 600)]
        [DataRow(new int[] { 6, 5, 5, 6, 6, 5 }, 1100)]
        [DataRow(new int[] { 6, 6, 6, 1 }, 700)]
        [DataRow(new int[] { 4, 4, 4, 4 }, 800)]
        [DataRow(new int[] { 4, 4, 4, 4, 4 }, 1600)]
        [DataRow(new int[] { 4, 4, 4, 4, 4, 5 }, 1650)]
        [DataRow(new int[] { 4, 4, 4, 4, 5, 1 }, 950)]
        [DataRow(new int[] { 3, 3, 3, 3, 3, 3 }, 2400)]
        [DataRow(new int[] { 1, 1, 4, 4, 5, 5 }, 800)]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, 1200)]
        public void Score(int[] values, int expectedResult)
        {
            var result = _greed.Score(values);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow(null)]
        [DataRow(new int[] { })]
        [DataRow(new int[] {1, 2, 3, 4, 5, 6, 6})]
        [DataRow(new int[] {1, 7})]
        [DataRow(new int[] { 1, -7 })]
        [DataRow(new int[] { 0 })]
        public void InvalidValues_Throws_Exception(int[] values)
        {
            _greed.Score(values);
        }
    }
}
