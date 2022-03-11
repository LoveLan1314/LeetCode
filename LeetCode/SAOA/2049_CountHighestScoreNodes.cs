using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class CountHighestScoreNodesSolution
    {
        private long _maxScore = 0;
        private int _cnt = 0;
        private int _n;
        private IList<int>[] _children;

        public int CountHighestScoreNodes(int[] parents)
        {
            _n = parents.Length;
            _children = new IList<int>[_n];
            for (int i = 0; i < _n; i++)
            {
                _children[i] = new List<int>();
            }
            for (int i = 0; i < _n; i++)
            {
                int p = parents[i];
                if (p != -1)
                {
                    _children[p].Add(i);
                }
            }
            DFS(0);
            return _cnt;
        }

        private int DFS(int node)
        {
            long score = 1;
            int size = _n - 1;
            foreach (int c in _children[node])
            {
                int t = DFS(c);
                score *= t;
                size -= t;
            }
            if (node != 0)
            {
                score *= size;
            }
            if (score == _maxScore)
            {
                _cnt++;
            }
            else if (score > _maxScore)
            {
                _maxScore = score;
                _cnt = 1;
            }
            return _n - size;
        }
    }
}
