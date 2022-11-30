using System;
using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class FreqStack
    {
        private readonly IDictionary<int, int> _freq = new Dictionary<int, int>();
        private readonly IDictionary<int, Stack<int>> _group = new Dictionary<int, Stack<int>>();
        private int _maxFreq;

        public FreqStack()
        {

        }

        public void Push(int val)
        {
            if (!_freq.ContainsKey(val))
            {
                _freq.Add(val, 1);
            }
            else
            {
                _freq[val]++;
            }
            if (!_group.ContainsKey(_freq[val]))
            {
                _group.Add(_freq[val], new Stack<int>());
            }
            _group[_freq[val]].Push(val);
            _maxFreq = Math.Max(_maxFreq, _freq[val]);

        }

        public int Pop()
        {
            int val = _group[_maxFreq].Peek();
            _freq[val]--;
            _group[_maxFreq].Pop();
            if (_group[_maxFreq].Count == 0)
            {
                _maxFreq--;
            }
            return val;
        }
    }
}
