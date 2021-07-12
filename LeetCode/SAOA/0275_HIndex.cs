namespace LeetCode.SAOA
{
    internal sealed class HIndexSolution
    {
        public int HIndex(int[] citations)
        {
            int n = citations.Length;
            int left = 0;
            int right = n - 1;
            while (left <= right)
            {
                int mid = (right - left) / 2 + left;
                if (citations[mid] >= n - mid)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return n - left;
        }
    }
}
