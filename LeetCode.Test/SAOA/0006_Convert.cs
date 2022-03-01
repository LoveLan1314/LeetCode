using LeetCode.SAOA;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test.SAOA
{
    [TestClass]
    public sealed class ConvertTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var solution = new ConvertSolution();
            Assert.IsTrue(solution.Convert("PAYPALISHIRING", 4) == "PINALSIGYAHRPI");
        }
    }
}
