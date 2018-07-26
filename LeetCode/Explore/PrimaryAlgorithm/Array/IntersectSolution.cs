using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm
{
    class IntersectSolution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> pairs1 = ChangeArrayToDictionary(nums1);
            Dictionary<int, int> pairs2 = ChangeArrayToDictionary(nums2);
            List<int> result = new List<int>();
            foreach (var item in pairs1)
            {
                if (pairs2.ContainsKey(item.Key))
                {
                    AddItemToList(result, item.Key, System.Math.Min(item.Value, pairs2[item.Key]));
                }
            }
            return result.ToArray();
        }

        private Dictionary<int, int> ChangeArrayToDictionary(int[] nums)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (pairs.ContainsKey(item))
                {
                    pairs[item] = pairs[item] + 1;
                }
                else
                {
                    pairs.Add(item, 1);
                }
            }
            return pairs;
        }

        private void AddItemToList(List<int> list,int item,int count)
        {
            for (int i = 0; i < count; i++)
            {
                list.Add(item);
            }
        }
    }
}
