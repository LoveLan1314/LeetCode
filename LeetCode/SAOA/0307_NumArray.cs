namespace LeetCode.SAOA
{
    internal sealed class NumArray
    {
        private readonly int[] _segmentTree;
        private readonly int _n;

        public NumArray(int[] nums)
        {
            _n = nums.Length;
            _segmentTree = new int[nums.Length * 4];
            Build(0, 0, _n - 1, nums);
        }

        public void Update(int index, int val)
        {
            Change(index, val, 0, 0, _n - 1);
        }

        public int SumRange(int left, int right)
        {
            return Range(left, right, 0, 0, _n - 1);
        }

        private void Build(int node, int s, int e, int[] nums)
        {
            if (s == e)
            {
                _segmentTree[node] = nums[s];
                return;
            }
            int m = s + (e - s) / 2;
            Build(node * 2 + 1, s, m, nums);
            Build(node * 2 + 2, m + 1, e, nums);
            _segmentTree[node] = _segmentTree[node * 2 + 1] + _segmentTree[node * 2 + 2];
        }

        private void Change(int index, int val, int node, int s, int e)
        {
            if (s == e)
            {
                _segmentTree[node] = val;
                return;
            }
            int m = s + (e - s) / 2;
            if (index <= m)
            {
                Change(index, val, node * 2 + 1, s, m);
            }
            else
            {
                Change(index, val, node * 2 + 2, m + 1, e);
            }
            _segmentTree[node] = _segmentTree[node * 2 + 1] + _segmentTree[node * 2 + 2];
        }

        private int Range(int left, int right, int node, int s, int e)
        {
            if (left == s && right == e)
            {
                return _segmentTree[node];
            }
            int m = s + (e - s) / 2;
            if (right <= m)
            {
                return Range(left, right, node * 2 + 1, s, m);
            }
            else if (left > m)
            {
                return Range(left, right, node * 2 + 2, m + 1, e);
            }
            else
            {
                return Range(left, m, node * 2 + 1, s, m) + Range(m + 1, right, node * 2 + 2, m + 1, e);
            }
        }
    }
}
