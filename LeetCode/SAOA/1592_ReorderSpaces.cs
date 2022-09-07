using System.Collections.Generic;
using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class ReorderSpacesSolution
    {
        public string ReorderSpaces(string text)
        {
            var spaceCount = 0;
            var words = new List<string>();
            StringBuilder word = new StringBuilder();
            foreach (var item in text)
            {
                if (item == ' ')
                {
                    spaceCount++;
                    if (word.Length > 0)
                    {
                        words.Add(word.ToString());
                        word = new StringBuilder();
                    }
                }
                else
                {
                    word.Append(item);
                }
            }
            if (word.Length > 0)
            {
                words.Add(word.ToString());
            }
            var eachSpaceCount = words.Count == 1 ? 0 : spaceCount / (words.Count - 1);
            var lastSpaceCount = eachSpaceCount == 0 ? spaceCount : spaceCount - eachSpaceCount * (words.Count - 1);
            var sb = new StringBuilder();
            for (int i = 0; i < words.Count; i++)
            {
                sb.Append(words[i]);
                if (i == words.Count - 1)
                {
                    for (int j = 0; j < lastSpaceCount; j++)
                    {
                        sb.Append(' ');
                    }
                }
                else
                {
                    for (int j = 0; j < eachSpaceCount; j++)
                    {
                        sb.Append(' ');
                    }
                }
            }
            return sb.ToString();
        }
    }
}
