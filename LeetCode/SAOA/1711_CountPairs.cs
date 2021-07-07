using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class CountPairsSolution
    {
        public int CountPairs(int[] deliciousness)
        {
            const int MOD = 1000000007;
            int maxSum = deliciousness.Max() * 2;
            int pairs = 0;
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            int n = deliciousness.Length;
            for (int i = 0; i < n; i++)
            {
                int val = deliciousness[i];
                for (int sum = 1; sum <= maxSum; sum <<= 1)
                {
                    dictionary.TryGetValue(sum - val, out int count);
                    pairs = (pairs + count) % MOD;
                }
                if (dictionary.ContainsKey(val))
                {
                    dictionary[val]++;
                }
                else
                {
                    dictionary.Add(val, 1);
                }
            }
            return pairs;
        }
    }
}
