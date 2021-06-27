using LeetCode.SAOA;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test.SAOA
{
    [TestClass]
    public sealed class SnakesAndLaddersTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            SnakesAndLaddersSolution solution = new();
            Assert.IsTrue(solution.SnakesAndLadders(new int[][]
            {
                new int[] {-1,-1,-1,-1,-1,-1,},
                new int[] {-1, -1, -1, -1, -1, -1,},
                new int[] {-1, -1, -1, -1, -1, -1},
                new int[] { -1, 35, -1, -1, 13, -1 },
                new int[] { -1, -1, -1, -1, -1, -1 },
                new int[] { -1, 15, -1, -1, -1, -1 }
            }) == 4);
        }

        [TestMethod]
        public void TestMethod2()
        {
            SnakesAndLaddersSolution solution = new();
            Assert.IsTrue(solution.SnakesAndLadders(new int[][]
            {
                new int[] {-1,-1,-1},
                new int[] {-1,9,8},
                new int[] {-1,8,9},
            }) == 1);
        }


        [TestMethod]
        public void TestMethod3()
        {
            SnakesAndLaddersSolution solution = new();
            Assert.IsTrue(solution.SnakesAndLadders(new int[][]
            {
                new int[] {1,1,-1},
                new int[] {1,1,1},
                new int[] {-1,1,1},
            }) == -1);
        }


        [TestMethod]
        public void TestMethod4()
        {
            SnakesAndLaddersSolution solution = new();
            Assert.IsTrue(solution.SnakesAndLadders(new int[][]
            {
                new int[] {-1,-1,19,10,-1},
                new int[] {2,-1,-1,6,-1},
                new int[] {-1,17,-1,19,-1},
                new int[] {25,-1,20,-1,-1},
                new int[] {-1,-1,-1,-1,15},
            }) == 2);
        }
    }
}
