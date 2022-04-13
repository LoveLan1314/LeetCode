using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class RandomizedSet
    {
        private readonly Dictionary<int, int> _pairs = new Dictionary<int, int>();
        private readonly List<int> _list = new List<int>();

        public RandomizedSet()
        {

        }

        public bool Insert(int val)
        {
            if (_pairs.ContainsKey(val))
            {
                return false;
            }
            _list.Add(val);
            _pairs.Add(val, _list.Count - 1);
            return true;
        }

        public bool Remove(int val)
        {
            if (!_pairs.ContainsKey(val))
            {
                return false;
            }
            var index = _pairs[val];
            var last = _list.Last();
            _list[index] = last;
            _pairs[last] = index;
            _list.RemoveAt(_list.Count - 1);
            _pairs.Remove(val);
            return true;
        }

        public int GetRandom()
        {
            var random = new Random();
            var index = random.Next(_list.Count);
            return _list[index];
        }
    }
}
