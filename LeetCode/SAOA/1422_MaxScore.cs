using System;

namespace LeetCode.SAOA
{
    internal sealed class MaxScoreSolution
    {
        public int MaxScore(string s)
        {
            var result = 0;
            for (int i = 1; i < s.Length; i++)
            {
                var sum = 0;
                for (int j = 0; j < i; j++)
                {
                    if (s[j] == '0')
                    {
                        sum++;
                    }
                }
                for (int j = i; j < s.Length; j++)
                {
                    if (s[j] == '1')
                    {
                        sum++;
                    }
                }
                result = Math.Max(result, sum);
            }
            return result;
        }
    }
}
