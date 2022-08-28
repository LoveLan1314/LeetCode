using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SAOA
{
    internal sealed class PreimageSizeFZFSolution
    {
        public int PreimageSizeFZF(int k)
        {
            return (int)(Help(k + 1) - Help(k));
        }

        private long Help(int k)
        {
            long r = 5L * k;
            long l = 0;
            while (l <= r)
            {
                long mid = (l + r) / 2;
                if (Zeta(mid) < k)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
            return r + 1;
        }

        private long Zeta(long x)
        {
            long res = 0;
            while (x != 0)
            {
                res += x / 5;
                x /= 5;
            }
            return res;
        }
    }
}
