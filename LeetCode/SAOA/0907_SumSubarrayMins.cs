﻿using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class SumSubarrayMinsSolution
    {
        public int SumSubarrayMins(int[] arr)
        {
            int n = arr.Length;
            Stack<int> monoStack = new Stack<int>();
            int[] left = new int[n];
            int[] right = new int[n];
            for (int i = 0; i < n; i++)
            {
                while (monoStack.Count > 0 && arr[i] <= arr[monoStack.Peek()])
                {
                    monoStack.Pop();
                }
                left[i] = i - (monoStack.Count == 0 ? -1 : monoStack.Peek());
                monoStack.Push(i);
            }
            monoStack.Clear();
            for (int i = n - 1; i >= 0; i--)
            {
                while (monoStack.Count > 0 && arr[i] < arr[monoStack.Peek()])
                {
                    monoStack.Pop();
                }
                right[i] = (monoStack.Count == 0 ? n : monoStack.Peek()) - i;
                monoStack.Push(i);
            }
            long ans = 0;
            const int MOD = 1000000007;
            for (int i = 0; i < n; i++)
            {
                ans = (ans + (long)left[i] * right[i] * arr[i]) % MOD;
            }
            return (int)ans;
        }
    }
}
