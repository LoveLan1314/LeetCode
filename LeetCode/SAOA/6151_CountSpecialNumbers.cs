using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class CountSpecialNumbersSolution
    {
        public int CountSpecialNumbers(int n)
        {
            var count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (IsSpecialInteger(i))
                {
                    count++;
                }
            }
            return count;
        }

        private bool IsSpecialInteger(int i)
        {
            var str = i.ToString();
            var set = new HashSet<char>();
            foreach (var item in str)
            {
                if (set.Contains(item))
                {
                    return false;
                }
                else
                {
                    set.Add(item);
                }
            }
            return true;
        }
    }
}
