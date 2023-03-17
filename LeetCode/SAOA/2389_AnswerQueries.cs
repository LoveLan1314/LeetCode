using System;

namespace LeetCode.SAOA
{
    internal sealed class _2389_AnswerQueriesSolution
    {
        public int[] AnswerQueries(int[] nums, int[] queries)
        {
            int n = nums.Length;
            int m = queries.Length;
            Array.Sort(nums);
            int[] result = new int[m];
            for (int i = 0; i < m; i++)
            {
                int max = queries[i];
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += nums[j];
                    if (sum > max)
                    {
                        result[i] = j;
                        break;
                    }
                    if (j == n - 1)
                    {
                        result[i] = n;
                    }
                }
            }
            return result;
        }

        public int[] AnswerQueries1(int[] nums, int[] queries)
        {
            int n = nums.Length, m = queries.Length;
            Array.Sort(nums);
            int[] f = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                f[i + 1] = f[i] + nums[i];
            }
            int[] answer = new int[m];
            for (int i = 0; i < m; i++)
            {
                answer[i] = BinarySearch(f, queries[i]) - 1;
            }
            return answer;
        }

        private int BinarySearch(int[] f, int target)
        {
            int low = 1, high = f.Length;
            while (low < high)
            {
                int mid = low + (high - low) / 2;
                if (f[mid] > target)
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return low;
        }
    }
}
