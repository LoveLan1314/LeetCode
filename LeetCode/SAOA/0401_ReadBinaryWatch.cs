using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SAOA
{
    internal sealed class ReadBinaryWatchSolution
    {
        public IList<string> ReadBinaryWatch(int turnedOn)
        {
            var ans = new List<string>();
            for (int h = 0; h < 12; ++h)
            {
                for (int m = 0; m < 60; ++m)
                {
                    if (BitCount(h) + BitCount(m) == turnedOn)
                    {
                        ans.Add(h + ":" + (m < 10 ? "0" : "") + m);
                    }
                }
            }
            return ans;
        }

        private int BitCount(int i)
        {
            i -= (i >> 1) & 0x55555555;
            i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
            i = (i + (i >> 4)) & 0x0f0f0f0f;
            i += i >> 8;
            i += i >> 16;
            return i & 0x3f;
        }
    }
}
