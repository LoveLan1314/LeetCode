using System;
using System.Collections.Generic;
using System.Linq;

class ThreeSumClosest
{
    public int Calc(int[] nums, int target)
    {
        int len = nums.Length;
        Array.Sort(nums);
        int min = int.MaxValue;
        int result = 0;
        for (int i = 0; i < len; i++)
        {
            int begin = i + 1;
            int end = len - 1;
            while (begin < end)
            {
                int sum = nums[i] + nums[begin] + nums[end];
                int balance = Math.Abs(target - sum);
                if (balance == 0)
                {
                    return sum;
                }
                else if (balance < min)
                {
                    result = sum;
                    min = balance;
                }
                if (sum < target)
                {
                    begin++;
                }
                if (sum > target)
                {
                    end--;
                }
            }
        }
        return result;
    }
}