using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class FrequencySortSolution1
    {
        public int[] FrequencySort(int[] nums)
        {
            var pairs = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (pairs.ContainsKey(num))
                {
                    pairs[num]++;
                }
                else
                {
                    pairs.Add(num, 1);
                }
            }
            var list = new List<int>();
            foreach (int num in nums)
            {
                list.Add(num);
            }
            list.Sort((a, b) =>
            {
                int cnt1 = pairs[a], cnt2 = pairs[b];
                return cnt1 != cnt2 ? cnt1 - cnt2 : b - a;
            });
            return list.ToArray();
        }
    }
}
