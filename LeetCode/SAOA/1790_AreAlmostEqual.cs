using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class AreAlmostEqualSolution
    {
        public bool AreAlmostEqual(string s1, string s2)
        {
            var difference = new List<int>();
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    if (difference.Count == 2)
                    {
                        return false;
                    }
                    else
                    {
                        difference.Add(i);
                    }
                }
            }
            if (difference.Count == 0)
            {
                return true;
            }
            //如果为1返回false
            if (difference.Count != 2)
            {
                return false;
            }
            return s1[difference[0]] == s2[difference[1]] && s1[difference[1]] == s2[difference[0]];
        }
    }
}
