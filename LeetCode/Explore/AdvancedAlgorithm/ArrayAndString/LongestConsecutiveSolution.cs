using System.Collections.Generic;

namespace LeetCode.Explore.AdvancedAlgorithm.ArrayAndString
{
    internal class LongestConsecutiveSolution
    {
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (!pairs.ContainsKey(item))
                {
                    pairs.Add(item, 1);
                    int temp = item;
                    bool hasBig = false;
                    if (pairs.ContainsKey(temp + 1))
                    {
                        while (pairs.ContainsKey(temp + 1))
                        {
                            temp++;
                        }
                        pairs[temp]++;
                        pairs[item] = pairs[temp];
                        hasBig = true;
                    }
                    int temp2 = item;
                    if (pairs.ContainsKey(temp2 - 1))
                    {
                        while (pairs.ContainsKey(temp2 - 1))
                        {
                            temp2--;
                        }
                        if (hasBig)
                        {
                            pairs[temp] += (item - temp2);
                            pairs[temp2] = pairs[temp];
                        }
                        else
                        {
                            pairs[temp2]++;
                            pairs[item] = pairs[temp2];
                        }
                    }
                }
            }
            int max = int.MinValue;
            foreach (var item in pairs)
            {
                if (max < item.Value)
                {
                    max = item.Value;
                }
            }
            return max;
        }
    }
}
