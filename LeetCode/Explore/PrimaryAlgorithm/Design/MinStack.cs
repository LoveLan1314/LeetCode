using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.Design
{
    class MinStack
    {
        Stack<int> _stack = new Stack<int>();
        Stack<int> _min = new Stack<int>();
        public MinStack()
        {

        }

        public void Push(int x)
        {
            _stack.Push(x);
            if (_min.Count == 0 || x <= _min.Peek())
            {
                _min.Push(x);
            }
        }

        public void Pop()
        {
            int x = _stack.Pop();
            if (x == _min.Peek())
            {
                _min.Pop();
            }
        }

        public int Top()
        {
            return _stack.Peek();
        }

        public int GetMin()
        {
            return _min.Peek();
        }
    }
}
