namespace LeetCode.SAOA
{
    internal sealed class XorQueriesSolution
    {
        public int[] XorQueries(int[] arr, int[][] queries)
        {
            int n = arr.Length;
            int[] pre = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                pre[i] = pre[i - 1] ^ arr[i - 1];
            }
            int resLen = queries.Length;
            int[] result = new int[resLen];
            for (int i = 0; i < resLen; i++)
            {
                result[i] = pre[queries[i][0]] ^ pre[queries[i][1] + 1];
            }
            return result;
        }
    }
}
