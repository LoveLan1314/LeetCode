using LeetCode.SAOA;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test.SAOA
{
    [TestClass]
    public sealed class OpenLockTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            OpenLockSolution solution = new OpenLockSolution();
            Assert.IsTrue(solution.OpenLock(new string[] { "0201", "0101", "0102", "1212", "2002" }, "0202") == 6);
        }
    }
}
