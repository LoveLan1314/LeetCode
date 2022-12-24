using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class _1754_LargestMergeSolution
    {
        public string LargestMerge(string word1, string word2)
        {
            var sb = new StringBuilder();
            int i = 0, j = 0;
            while (i < word1.Length || j < word2.Length)
            {
                if (i < word1.Length && word1[i..].CompareTo(word2[j..]) > 0)
                {
                    sb.Append(word1[i]);
                    i++;
                }
                else
                {
                    sb.Append(word2[j]);
                    j++;
                }
            }
            return sb.ToString();
        }
    }
}
