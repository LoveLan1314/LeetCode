using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class RemoveAnagramsSolution
    {
        public IList<string> RemoveAnagrams(string[] words)
        {
            Dictionary<char, int>[] pairs = new Dictionary<char, int>[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                string item = words[i];
                var dict = new Dictionary<char, int>();
                foreach (var c in item)
                {
                    if (dict.TryGetValue(c, out var count))
                    {
                        dict[c] = count + 1;
                    }
                    else
                    {
                        dict.Add(c, 1);
                    }
                }
                pairs[i] = dict;
            }
            HashSet<int> removeIndex = new HashSet<int>();
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (removeIndex.Contains(i))
                {
                    continue;
                }
                var nextIndex = i + 1;
                while (removeIndex.Contains(nextIndex))
                {
                    nextIndex++;
                }
                if (nextIndex < words.Length)
                {
                    var currentDict = pairs[i];
                    var nextDict = pairs[nextIndex];
                    if (IsEctopic(currentDict, nextDict))
                    {
                        removeIndex.Add(nextIndex);
                        i--;
                    }
                }
            }
            var result = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (!removeIndex.Contains(i))
                {
                    result.Add(words[i]);
                }
            }
            return result;
        }

        private bool IsEctopic(Dictionary<char, int> first, Dictionary<char, int> second)
        {
            if (first.Count != second.Count)
            {
                return false;
            }
            foreach (var item in first)
            {
                if (!second.TryGetValue(item.Key, out var count) || item.Value != count)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
