using System;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class MinimumTimeRequiredSolution
    {
        public int MinimumTimeRequired(int[] jobs, int k)
        {
            Array.Sort(jobs);
            Array.Reverse(jobs);
            int l = jobs[0];
            int r = jobs.Sum();
            while (l < r)
            {
                int mid = (l + r) >> 1;  //向左移位1，即为除2的效果
                if (Check(jobs, k, mid))
                {
                    r = mid;
                }
                else
                {
                    l = mid + 1;
                }
            }
            return l;
        }

        private bool Check(int[] jobs, int k, int limit)
        {
            int[] workloads = new int[k];
            return Backtrack(jobs, workloads, 0, limit);
        }

        private bool Backtrack(int[] jobs, int[] workloads, int i, int limit)
        {
            if (i >= jobs.Length)
            {
                return true;
            }
            int cur = jobs[i];
            for (int j = 0; j < workloads.Length; j++)
            {
                if (workloads[j] + cur <= limit)
                {
                    workloads[j] += cur;
                    if (Backtrack(jobs, workloads, i + 1, limit))
                    {
                        return true;
                    }
                    workloads[j] -= cur;
                }
                //如果经过上述计算，当前工人并未分配工作
                //或者当前工作正好使当前工作的工作量达到上限，却并没有返回，说明后续还有其他工作
                //这两种情况说明无法满足要求，无需尝试继续分配工作
                if (workloads[j] == 0 || workloads[j] + cur == limit)
                {
                    break;
                }
            }
            return false;
        }
    }
}
