using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class SumPrefixScoresSolution
    {
        public int[] SumPrefixScores(string[] words)
        {
            var result = new int[words.Length];
            var set = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
                var count = 0;
                for (int j = 0; j < word.Length; j++)
                {
                    var realword = word.Substring(0, j + 1);
                    if (set.TryGetValue(realword, out var realwordCount))
                    {
                        count += realwordCount;
                    }
                    else
                    {
                        realwordCount = 0;
                        for (int k = 0; k < words.Length; k++)
                        {
                            if (words[k].StartsWith(realword))
                            {
                                realwordCount++;
                            }
                        }
                        set.Add(realword, realwordCount);
                        count += realwordCount;
                    }
                }
                result[i] = count;
            }
            return result;
        }
    }
}
