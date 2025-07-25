using System;

namespace LeetCode._2025
{
    internal sealed class TrapSolution
    {
        public int Trap(int[] height)
        {
            int n = height.Length;
            if (n == 0)
            {
                return 0;
            }

            int[] leftMax = new int[n];
            leftMax[0] = height[0];
            for (int i = 1; i < n; i++)
            {
                leftMax[i] = Math.Max(leftMax[i - 1], height[i]);
            }

            int[] rightMax = new int[n];
            rightMax[n - 1] = height[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                rightMax[i] = Math.Max(rightMax[i + 1], height[i]);
            }

            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                ans += Math.Min(leftMax[i], rightMax[i]) - height[i];
            }
            return ans;
        }
    }
}