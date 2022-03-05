using System;

namespace LeetCode.SAOA
{
    internal sealed class FindLUSlengthSolution
    {
        public int FindLUSlength(string a, string b)
        {
            return a != b ? Math.Max(a.Length, b.Length) : -1;
        }
    }
}
