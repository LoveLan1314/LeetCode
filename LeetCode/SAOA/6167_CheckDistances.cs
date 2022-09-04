using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class CheckDistancesSolution
    {
        public bool CheckDistances(string s, int[] distance)
        {
            var set = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if (!set.Contains(c))
                {
                    set.Add(c);
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[j] == c)
                        {
                            if (distance[c - 'a'] != j - i - 1)
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
}
