using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SAOA
{
    internal sealed class OneEditAwaySolution
    {
        public bool OneEditAway(string first, string second)
        {
            int m = first.Length, n = second.Length;
            if (n - m == 1)
            {
                return OneInsert(first, second);
            }
            else if (m - n == 1)
            {
                return OneInsert(second, first);
            }
            else if (m == n)
            {
                bool foundDifference = false;
                for (int i = 0; i < m; i++)
                {
                    if (first[i] != second[i])
                    {
                        if (!foundDifference)
                        {
                            foundDifference = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool OneInsert(string shorter, string longer)
        {
            int length1 = shorter.Length;
            int length2 = longer.Length;
            int index1 = 0, index2 = 0;
            while (index1 < length1 && index2 < length2)
            {
                if (shorter[index1] == longer[index2])
                {
                    index1++;
                }
                index2++;
                if (index2 - index1 > 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
