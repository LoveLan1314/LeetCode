using System;
using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class PickSolution
    {
        readonly Random _rand;
        readonly IList<int> _arr;
        readonly int[][] _rects;

        public PickSolution(int[][] rects)
        {
            _rand = new Random();
            _arr = new List<int>
            {
                0
            };
            this._rects = rects;
            foreach (int[] rect in rects)
            {
                int a = rect[0], b = rect[1], x = rect[2], y = rect[3];
                _arr.Add(_arr[_arr.Count - 1] + (x - a + 1) * (y - b + 1));
            }
        }

        public int[] Pick()
        {
            int k = _rand.Next(_arr[_arr.Count - 1]);
            int rectIndex = BinarySearch(_arr, k + 1) - 1;
            k -= _arr[rectIndex];
            int[] rect = _rects[rectIndex];
            int a = rect[0], b = rect[1], y = rect[3];
            int col = y - b + 1;
            int da = k / col;
            int db = k - col * da;
            return new int[] { a + da, b + db };
        }

        private int BinarySearch(IList<int> arr, int target)
        {
            int low = 0, high = arr.Count - 1;
            while (low <= high)
            {
                int mid = (high - low) / 2 + low;
                int num = arr[mid];
                if (num == target)
                {
                    return mid;
                }
                else if (num > target)
                {
                    high = mid - 1;
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
