using System.Collections.Generic;
using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class UniqueMorseRepresentationsSolution
    {
        private readonly string[] _data =
            new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..",
                ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...",
                "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

        public int UniqueMorseRepresentations(string[] words)
        {
            HashSet<string> result = new HashSet<string>();
            foreach (var item in words)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var c in item)
                {
                    sb.Append(_data[c - 97]);
                }
                var s = sb.ToString();
                if (!result.Contains(s))
                {
                    result.Add(s);
                }
            }
            return result.Count;
        }
    }
}
