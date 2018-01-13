using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication.Algorithms.Fifty
{
    class FourSum
    {
        public IList<IList<int>> Calc(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            int len = nums.Length;
            if (len < 4)
            {
                return result;
            }
            Array.Sort(nums);
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    int begin = j + 1;
                    int end = len - 1;
                    while (begin < end)
                    {
                        int sum = nums[i] + nums[j] + nums[begin] + nums[end];
                        if (sum == target)
                        {
                            if (!result.Any(x => x[0] == nums[i] && x[1] == nums[j] &&
                             x[2] == nums[begin] && x[3] == nums[end]))
                            {
                                List<int> list = new List<int>();
                                list.Add(nums[i]);
                                list.Add(nums[j]);
                                list.Add(nums[begin]);
                                list.Add(nums[end]);
                                result.Add(list);
                            }
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
                        else if (sum < target)
                        {
                            begin++;
                        }
                        else
                        {
                            end--;
                        }
                    }
                }
            }
            return result;
        }
    }
}