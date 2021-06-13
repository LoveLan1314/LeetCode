namespace LeetCode.SAOA
{
    internal sealed class FirstBadVersionSolution : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            int left = 1;
            int right = n;
            while (left < right)
            {
                int mid = left + (right - left) / 2; // 防止计算时溢出  采用(right + left)/2 可能有溢出风险
                if (IsBadVersion(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }
    }
}
