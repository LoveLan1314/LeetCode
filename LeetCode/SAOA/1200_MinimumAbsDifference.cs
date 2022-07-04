using System;
using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class MinimumAbsDifferenceSolution
    {
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            IList<IList<int>> result = new List<IList<int>>();
            var balance = int.MaxValue;
            Array.Sort(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var currentBalance = arr[i + 1] - arr[i];
                if (currentBalance < balance)
                {
                    result = new List<IList<int>>()
                    {
                        new List<int>(){ arr[i], arr[i + 1] }
                    };
                    balance = currentBalance;
                }
                else if (currentBalance == balance)
                {
                    result.Add(new List<int>() { arr[i], arr[i + 1] });
                }
            }
            return result;
        }
    }
}
