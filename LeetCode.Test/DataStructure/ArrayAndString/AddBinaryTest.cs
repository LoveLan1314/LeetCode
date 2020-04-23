using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.DataStructure.ArrayAndString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test.DataStructure.ArrayAndString
{
    [TestClass]
    public sealed class AddBinaryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var solution = new AddBinarySolution();
            var result = solution.AddBinary("11", "1");
            Assert.IsTrue(result == "100");
        }

        [TestMethod]
        public void TestMethod2()
        {
            var solution = new AddBinarySolution();
            var result = solution.AddBinary("1010", "1011");
            Assert.IsTrue(result == "10101");
        }
    }
}
