using LeetCode.SAOA;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test.SAOA
{
    [TestClass]
    public sealed class SlidingPuzzleTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            SlidingPuzzleSolution solution = new SlidingPuzzleSolution();
            Assert.IsTrue(solution.SlidingPuzzle(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 0, 5 } }) == 1);
        }
    }
}
