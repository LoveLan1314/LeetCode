using LeetCode.DataStructure.ArrayAndString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test.DataStructure.ArrayAndString
{
    [TestClass]
    public class FindDiagonalOrderTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var solution = new FindDiagonalOrderSolution();
            var result = solution.FindDiagonalOrder(new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6},
                new int[] { 7, 8, 9}
            });
            var rightResult = new int[] { 1, 2, 4, 7, 5, 3, 6, 8, 9 };
            Assert.IsTrue(result.Length == rightResult.Length);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.IsTrue(result[i] == rightResult[i]);
            }
        }
    }
}
