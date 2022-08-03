using System;
using System.Linq;
using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class OrderlyQueueSolution
    {
        public string OrderlyQueue(string s, int k)
        {
            if (k == 1)
            {
                var smallest = s;
                var sb = new StringBuilder(s);
                int n = s.Length;
                for (int i = 1; i < n; i++)
                {
                    var c = sb[0];
                    sb.Remove(0, 1);
                    sb.Append(c);
                    var newStr = sb.ToString();
                    if (newStr.CompareTo(smallest) < 0)
                    {
                        smallest = newStr;
                    }
                }
                return smallest;
            }
            else
            {
                var arr = s.ToArray();
                Array.Sort(arr);
                return new string(arr);
            }
        }
    }
}
