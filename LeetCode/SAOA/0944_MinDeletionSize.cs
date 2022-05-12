namespace LeetCode.SAOA
{
    internal sealed class MinDeletionSizeSolution
    {
        public int MinDeletionSize(string[] strs)
        {
            int n = strs[0].Length;
            int m = strs.Length;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    if (strs[j][i] > strs[j + 1][i])
                    {
                        count++;
                        break;
                    }
                }
            }
            return count;
        }
    }
}
