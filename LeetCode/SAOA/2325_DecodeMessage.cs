using System.Collections.Generic;
using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class _2325_DecodeMessage
    {
        public string DecodeMessage(string key, string message)
        {
            var pairs = new Dictionary<char, char>();
            var index = 0;
            foreach (char item in key)
            {
                if (item != ' ' && !pairs.ContainsKey(item))
                {
                    pairs.Add(item, (char)(97 + index));
                    index++;
                }
            }
            var sb = new StringBuilder();
            foreach (char item in message)
            {
                if (item == ' ')
                {
                    sb.Append(item);
                }
                else
                {
                    sb.Append(pairs[item]);
                }
            }
            return sb.ToString();
        }
    }
}
