using System;

namespace LeetCode.SAOA
{
    internal sealed class FindClosestSolution
    {
        public int FindClosest(string[] words, string word1, string word2)
        {
            int n = words.Length;
            int ans = n;
            int index1 = -1;
            int index2 = -1;
            for (int i = 0; i < n; i++)
            {
                if (words[i].Equals(word1))
                {
                    index1 = i;
                }
                else if (words[i].Equals(word2))
                {
                    index2 = i;
                }
                if (index1 > 0 && index2 > 0)
                {
                    ans = Math.Min(ans, Math.Abs(index2 - index1));
                }
            }
            return ans;
        }
    }
}
