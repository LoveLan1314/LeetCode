using LeetCode.SAOA;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test.SAOA
{
    [TestClass]
    public sealed class FindTargetSumWaysTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            FindTargetSumWaysSolution solution = new();
            Assert.IsTrue(solution.FindTargetSumWays1(new int[] { 1, 1, 1, 1, 1, }, 3) == 5);
        }
    }
}
