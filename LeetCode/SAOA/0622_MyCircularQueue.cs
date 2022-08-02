namespace LeetCode.SAOA
{
    internal sealed class MyCircularQueue
    {
        private int _start;
        private int _end;
        private readonly int[] _data;
        private readonly int _capacity;

        public MyCircularQueue(int k)
        {
            _start = 0;
            _end = 0;
            _capacity = k + 1;
            _data = new int[_capacity];
        }

        public bool EnQueue(int value)
        {
            if (IsFull())
            {
                return false;
            }
            else
            {
                _data[_end] = value;
                _end = (_end + 1) % _capacity;
                return true;
            }
        }

        public bool DeQueue()
        {
            if (IsEmpty())
            {
                return false;
            }
            else
            {
                _start = (_start + 1) % _capacity;
                return true;
            }
        }

        public int Front()
        {
            if (IsEmpty())
            {
                return -1;
            }
            else
            {
                return _data[_start];
            }
        }

        public int Rear()
        {
            if (IsEmpty())
            {
                return -1;
            }
            else
            {
                return _data[(_end - 1 + _capacity) % _capacity];
            }
        }

        public bool IsEmpty()
        {
            return _start == _end;
        }

        public bool IsFull()
        {
            return (_end + 1) % _capacity == _start;
        }
    }
}
