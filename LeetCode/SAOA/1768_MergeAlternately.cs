using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class MergeAlternatelySolution
    {
        public string MergeAlternately(string word1, string word2)
        {
            var m = word1.Length;
            var n = word2.Length;
            int i = 0, j = 0;
            var sb = new StringBuilder();
            while (i < m || j < n)
            {
                if (i < m)
                {
                    sb.Append(word1[i]);
                    i++;
                }
                if (j < n)
                {
                    sb.Append(word2[j]);
                    j++;
                }
            }
            return sb.ToString();
        }
    }
}
