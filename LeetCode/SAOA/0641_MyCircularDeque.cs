﻿namespace LeetCode.SAOA
{
    internal sealed class MyCircularDeque
    {
        private readonly int[] elements;
        private int rear, front;
        private readonly int capacity;

        public MyCircularDeque(int k)
        {
            capacity = k + 1;
            rear = front = 0;
            elements = new int[k + 1];
        }

        public bool InsertFront(int value)
        {
            if (IsFull())
            {
                return false;
            }
            front = (front - 1 + capacity) % capacity;
            elements[front] = value;
            return true;
        }

        public bool InsertLast(int value)
        {
            if (IsFull())
            {
                return false;
            }
            elements[rear] = value;
            rear = (rear + 1) % capacity;
            return true;
        }

        public bool DeleteFront()
        {
            if (IsEmpty())
            {
                return false;
            }
            front = (front + 1) % capacity;
            return true;
        }

        public bool DeleteLast()
        {
            if (IsEmpty())
            {
                return false;
            }
            rear = (rear - 1 + capacity) % capacity;
            return true;
        }

        public int GetFront()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return elements[front];
        }

        public int GetRear()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return elements[(rear - 1 + capacity) % capacity];
        }

        public bool IsEmpty()
        {
            return rear == front;
        }

        public bool IsFull()
        {
            return (rear + 1) % capacity == front;
        }
    }
}
