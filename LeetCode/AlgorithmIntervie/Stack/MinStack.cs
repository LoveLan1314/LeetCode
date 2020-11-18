using System.Collections.Generic;

namespace LeetCode.AlgorithmIntervie.Stack
{
    internal sealed class MinStack
    {
        private readonly Stack<int> _stack = new Stack<int>();
        //此处存储的都是最小值数组，也可以同步存储每个值对应的最小值
        private readonly Stack<int> _min = new Stack<int>();

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
