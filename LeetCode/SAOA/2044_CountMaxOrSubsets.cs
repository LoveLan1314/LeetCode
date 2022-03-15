namespace LeetCode.SAOA
{
    internal sealed class CountMaxOrSubsetsSolution
    {
        private int[] _nums;
        private int _maxOr;
        private int _cnt;

        public int CountMaxOrSubsets(int[] nums)
        {
            _nums = nums;
            _maxOr = 0;
            _cnt = 0;
            DFS(0, 0);
            return _cnt;
        }

        private void DFS(int pos, int orVal)
        {
            if (pos == _nums.Length)
            {
                if (orVal > _maxOr)
                {
                    _maxOr = orVal;
                    _cnt = 1;
                }
                else if (orVal == _maxOr)
                {
                    _cnt++;
                }
                return;
            }
            DFS(pos + 1, orVal | _nums[pos]);
            DFS(pos + 1, orVal);
        }
    }
}
