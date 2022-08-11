using System.Collections.Generic;
using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class ReformatSolution
    {
        public string Reformat(string s)
        {
            var charList = new List<char>();
            var numberList = new List<char>();
            foreach (var item in s)
            {
                if (char.IsDigit(item))
                {
                    numberList.Add(item);
                }
                else
                {
                    charList.Add(item);
                }
            }
            List<char> big, small;
            if (charList.Count > numberList.Count)
            {
                big = charList;
                small = numberList;
            }
            else
            {
                big = numberList;
                small = charList;
            }
            if (big.Count - small.Count > 1)
            {
                return "";
            }
            var sb = new StringBuilder();
            int i = 0;
            for (; i < small.Count; i++)
            {
                sb.Append(big[i]);
                sb.Append(small[i]);
            }
            if (i == big.Count - 1)
            {
                sb.Append(big[i]);
            }
            return sb.ToString();
        }
    }
}
