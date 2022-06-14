using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class GetValidT9WordsSolution
    {
        public IList<string> GetValidT9Words(string num, string[] words)
        {
            var pairs = new List<List<char>>() {
                new List<char>(){ 'a', 'b', 'c' },
                new List<char>(){ 'd', 'e', 'f' },
                new List<char>(){ 'g', 'h', 'i' },
                new List<char>(){ 'j', 'k', 'l' },
                new List<char>(){ 'm', 'n', 'o' },
                new List<char>(){ 'p', 'q', 'r', 's' },
                new List<char>(){ 't', 'u', 'v' },
                new List<char>(){ 'w', 'x', 'y', 'z' },
            };
            var result = new List<string>();
            foreach (var word in words)
            {
                bool isMatch = true;
                for (int i = 0; i < word.Length; i++)
                {
                    if (!pairs[num[i] - 50].Contains(word[i]))
                    {
                        isMatch = false;
                        break;
                    }
                }
                if (isMatch)
                {
                    result.Add(word);
                }
            }
            return result;
        }
    }
}
