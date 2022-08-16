using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class OrderedStream
    {
        private readonly string[] _stream;
        private int _ptr;

        public OrderedStream(int n)
        {
            _stream = new string[n + 1];
            _ptr = 1;
        }

        public IList<string> Insert(int idKey, string value)
        {
            _stream[idKey] = value;
            IList<string> res = new List<string>();
            while (_ptr < _stream.Length && _stream[_ptr] != null)
            {
                res.Add(_stream[_ptr]);
                ++_ptr;
            }
            return res;
        }
    }
}
