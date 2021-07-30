using System;

namespace LeetCode.SAOA
{
    internal sealed class TitleToNumberSolution
    {
        public int TitleToNumber(string columnTitle)
        {
            int result = 0;
            int length = columnTitle.Length;
            foreach (var item in columnTitle)
            {
                result += (int)((item - 65 + 1) * Math.Pow(26, length - 1));
                length--;
            }
            return result;
        }
    }
}
