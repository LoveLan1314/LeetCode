using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class MovingAverage
    {
        private readonly Queue<int> _list = new Queue<int>();
        private readonly int _size;

        public MovingAverage(int size)
        {
            _size = size;
        }

        public double Next(int val)
        {
            if (_list.Count == _size)
            {
                _list.Dequeue();
            }
            _list.Enqueue(val);
            return (double)_list.Sum() / _list.Count;
        }
    }
}
