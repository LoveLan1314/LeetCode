namespace LeetCode.SAOA
{
    internal sealed class LongestContinuousSubstringSolution
    {
        public int LongestContinuousSubstring(string s)
        {
            var result = 0;
            var current = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1] + 1)
                {
                    current++;
                }
                else
                {
                    if (current > result)
                    {
                        result = current;
                    }
                    current = 1;
                }
            }
            if (current > result)
            {
                result = current;
            }
            return result;
        }
    }
}
