using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class ArrayStringsAreEqualSolution
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            return Join(word1).Equals(Join(word2));
        }

        private string Join(string[] words)
        {
            StringBuilder ret = new StringBuilder();
            foreach (string s in words)
            {
                ret.Append(s);
            }
            return ret.ToString();
        }
    }
}
