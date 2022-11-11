using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class HalvesAreAlikeSolution
    {
        public bool HalvesAreAlike(string s)
        {
            var count = s.Length;
            var mid = count / 2;
            var leftCount = 0;
            var rightCount = 0;
            var set = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            for (int i = 0; i < mid; i++)
            {
                if (set.Contains(s[i]))
                {
                    leftCount++;
                }
            }
            for (int i = mid; i < count; i++)
            {
                if (set.Contains(s[i]))
                {
                    rightCount++;
                }
            }
            return leftCount == rightCount;
        }
    }
}
