using System;

namespace LeetCode.SAOA
{
    internal sealed class MaximumRequestsSolution
    {
        private int[] _delta;
        private int _ans = 0, _cnt = 0, _zero, _n;

        public int MaximumRequests(int n, int[][] requests)
        {
            _delta = new int[n];
            _zero = n;
            _n = n;
            DFS(requests, 0);
            return _ans;
        }

        private void DFS(int[][] requests, int pos)
        {
            if (pos == requests.Length)
            {
                if (_zero == _n)
                {
                    _ans = Math.Max(_ans, _cnt);
                }
                return;
            }

            // 不选 requests[pos]
            DFS(requests, pos + 1);

            // 选 requests[pos]
            int z = _zero;
            ++_cnt;
            int[] r = requests[pos];
            int x = r[0], y = r[1];
            _zero -= _delta[x] == 0 ? 1 : 0;
            --_delta[x];
            _zero += _delta[x] == 0 ? 1 : 0;
            _zero -= _delta[y] == 0 ? 1 : 0;
            ++_delta[y];
            _zero += _delta[y] == 0 ? 1 : 0;
            DFS(requests, pos + 1);
            --_delta[y];
            ++_delta[x];
            --_cnt;
            _zero = z;
        }
    }
}
