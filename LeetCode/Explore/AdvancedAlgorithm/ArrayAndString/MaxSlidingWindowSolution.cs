using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.AdvancedAlgorithm.ArrayAndString
{
    class MaxSlidingWindowSolution
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0)
            {
                return new int[0];
            }
            LinkedList<int> deque = new LinkedList<int>();
            int[] res = new int[nums.Length + 1 - k];
            for (int i = 0; i < nums.Length; i++)
            {
                // 每当新数进来时，如果发现队列头部的数的下标，是窗口最左边数的下标，则扔掉
                if (deque.Count > 0 && deque.First.Value == i - k)
                {
                    deque.RemoveFirst();
                }
                // 把队列尾部所有比新数小的都扔掉，保证队列是降序的
                while (deque.Count > 0 && nums[deque.Last.Value] < nums[i])
                {
                    deque.RemoveLast();
                }
                // 加入新数
                deque.AddLast(i);
                // 队列头部就是该窗口内第一大的
                if ((i + 1) >= k)
                {
                    res[i + 1 - k] = nums[deque.First.Value];
                }
            }
            return res;
        }
    }
}
