using System;
using System.Collections.Generic;

namespace ConsoleApplication.Algorithms.Fifty
{
    class ThreeSum
    {
        public IList<IList<int>> Calc(int[] nums)
        {
            List<IList<int>> res = new List<IList<int>>();
            int len = nums.Length;
            if (len < 3)
            {
                return res;
            }
            Array.Sort(nums);
            for (int i = 0; i < len; i++)
            {
                if (nums[i] > 0) break;
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                int begin = i + 1;
                int end = len - 1;
                while (begin < end)
                {
                    int sum = nums[i] + nums[begin] + nums[end];
                    if (sum == 0)
                    {
                        List<int> list = new List<int>();
                        list.Add(nums[i]);
                        list.Add(nums[begin]);
                        list.Add(nums[end]);
                        res.Add(list);
                        begin++;
                        end--;
                        while (begin < end && nums[begin] == nums[begin - 1])
                        {
                            begin++;
                        }
                        while (begin < end && nums[end] == nums[end + 1])
                        {
                            end--;
                        }
                    }
                    else if (sum > 0)
                    {
                        end--;
                    }
                    else
                    {
                        begin++;
                    }
                }
            }
            return res;
        }
    }
}