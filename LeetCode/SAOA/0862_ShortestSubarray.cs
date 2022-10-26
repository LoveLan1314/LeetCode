using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class ShortestSubarraySolution
    {
        public int ShortestSubarray(int[] nums, int k)
        {
            var n = nums.Length;
            var list = new List<int>() { 0 };
            int min = int.MaxValue;
            //本来用的int，但最后一个用例过不了，改为long过了
            long[] newNums = new long[n + 1];
            newNums[0] = 0;
            for (int i = 1; i < n + 1; i++)
            {
                newNums[i] = newNums[i - 1] + nums[i - 1];
            }
            for (int i = 1; i < n + 1; i++)
            {
                //使用队列元素，从前往后比较找最小长度
                while (list.Any() && newNums[i] - newNums[list[0]] >= k)
                {
                    min = Math.Min(i - list[0], min);
                    list.RemoveAt(0);
                }
                //添加队列元素，从后往前排出比当前值大的索引，保证list里的索引对应值是递增的
                while (list.Any() && newNums[i] < newNums[list[list.Count() - 1]])
                {
                    list.RemoveAt(list.Count - 1);
                }
                list.Add(i);
            }
            return min == int.MaxValue ? -1 : min;
        }
    }
}
