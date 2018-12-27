using System.Collections.Generic;

namespace LeetCode.Explore.IntermediateAlgorithm.Other
{
    internal class LeastIntervalSolution
    {
        public int LeastInterval(char[] tasks, int n)
        {
            List<int> cnt = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            foreach (var item in tasks)
            {
                cnt[item - 'A']++;
            }
            cnt.Sort();
            int i = 25;
            int mx = cnt[25];
            int len = tasks.Length;
            while (i >= 0 && cnt[i] == mx)
            {
                i--;
            }
            return System.Math.Max(len, (mx - 1) * (n + 1) + 25 - i);
        }
    }
}
