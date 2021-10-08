using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class FindRepeatedDnaSequencesSolution
    {
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            const int l = 10;
            IList<string> result = new List<string>();
            Dictionary<string, int> pairs = new Dictionary<string, int>();
            int n = s.Length;
            for (int i = 0; i <= n - l; i++)
            {
                string subStr = s.Substring(i, l);
                if (pairs.ContainsKey(subStr))
                {
                    pairs[subStr]++;
                }
                else
                {
                    pairs.Add(subStr, 1);
                }
                if (pairs[subStr] == 2)
                {
                    result.Add(subStr);
                }
            }
            return result;
        }
    }
}
