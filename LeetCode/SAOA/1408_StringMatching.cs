using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class StringMatchingSolution
    {
        public IList<string> StringMatching(string[] words)
        {
            var ret = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (i != j && words[j].Contains(words[i]))
                    {
                        ret.Add(words[i]);
                        break;
                    }
                }
            }
            return ret;
        }
    }
}
