using LeetCode.Explore.PrimaryAlgorithm.String;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test.SAOA
{
    [TestClass]
    public sealed class StrStrTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            StrStrSolution solution = new StrStrSolution();
            Assert.IsTrue(solution.StrStr("aaa", "aaaa") == -1);
        }
    }
}
