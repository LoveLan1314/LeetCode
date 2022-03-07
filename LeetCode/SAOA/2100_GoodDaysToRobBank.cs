using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class GoodDaysToRobBankSolution
    {
        public IList<int> GoodDaysToRobBank(int[] security, int time)
        {
            int n = security.Length;
            //前i天警卫连续非递增的天数
            int[] left = new int[n];
            //后i天警卫连续非递减的天数
            int[] right = new int[n];
            for (int i = 1; i < n; i++)
            {
                if (security[i] <= security[i - 1])
                {
                    left[i] = left[i - 1] + 1;
                }
                if (security[n - i - 1] <= security[n - i])
                {
                    right[n - i - 1] = right[n - i] + 1;
                }
            }

            IList<int> ans = new List<int>();
            for (int i = time; i < n - time; i++)
            {
                if (left[i] >= time && right[i] >= time)
                {
                    ans.Add(i);
                }
            }
            return ans;
        }
    }
}
