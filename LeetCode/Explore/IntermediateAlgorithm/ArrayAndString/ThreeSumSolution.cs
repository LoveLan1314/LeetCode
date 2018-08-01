using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.IntermediateAlgorithm.ArrayAndString
{
    class ThreeSumSolution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            int len = nums.Length;
            if (len < 3)
            {
                return result;
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
                        result.Add(new List<int>()
                        {
                            nums[i],
                            nums[begin],
                            nums[end]
                        });
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
            return result;
        }
    }
}
