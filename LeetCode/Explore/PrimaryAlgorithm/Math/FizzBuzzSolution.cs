using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.Math
{
    class FizzBuzzSolution
    {
        public IList<string> FizzBuzz(int n)
        {
            List<string> list = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                string str = "";
                if (i % 3 == 0)
                {
                    str += "Fizz";
                }
                if (i % 5 == 0)
                {
                    str += "Buzz";
                }
                if (string.IsNullOrEmpty(str))
                {
                    str = i.ToString();
                }
                list.Add(str);
            }
            return list;
        }
    }
}
