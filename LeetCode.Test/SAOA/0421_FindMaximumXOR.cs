using LeetCode.SAOA;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test.SAOA
{
    [TestClass]
    public sealed class FindMaximumXORTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            FindMaximumXORSolution solution = new FindMaximumXORSolution();
            Assert.IsTrue(solution.FindMaximumXOR(new int[] { 1, 2, 4 }) == 6);
        }
    }
}
