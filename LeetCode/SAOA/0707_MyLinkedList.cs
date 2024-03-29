﻿using System;

namespace LeetCode.SAOA
{
    internal sealed class MyLinkedList
    {
        private int size;
        private readonly ListNode head;
        private readonly ListNode tail;

        public MyLinkedList()
        {
            size = 0;
            head = new ListNode(0);
            tail = new ListNode(0);
            head.next = tail;
            tail.prev = head;
        }

        public int Get(int index)
        {
            if (index < 0 || index >= size)
            {
                return -1;
            }
            ListNode curr;
            if (index + 1 < size - index)
            {
                curr = head;
                for (int i = 0; i <= index; i++)
                {
                    curr = curr.next;
                }
            }
            else
            {
                curr = tail;
                for (int i = 0; i < size - index; i++)
                {
                    curr = curr.prev;
                }
            }
            return curr.val;
        }

        public void AddAtHead(int val)
        {
            AddAtIndex(0, val);
        }

        public void AddAtTail(int val)
        {
            AddAtIndex(size, val);
        }

        public void AddAtIndex(int index, int val)
        {
            if (index > size)
            {
                return;
            }
            index = Math.Max(0, index);
            ListNode pred, succ;
            if (index < size - index)
            {
                pred = head;
                for (int i = 0; i < index; i++)
                {
                    pred = pred.next;
                }
                succ = pred.next;
            }
            else
            {
                succ = tail;
                for (int i = 0; i < size - index; i++)
                {
                    succ = succ.prev;
                }
                pred = succ.prev;
            }
            size++;
            ListNode toAdd = new ListNode(val);
            toAdd.prev = pred;
            toAdd.next = succ;
            pred.next = toAdd;
            succ.prev = toAdd;
        }

        public void DeleteAtIndex(int index)
        {
            if (index < 0 || index >= size)
            {
                return;
            }
            ListNode pred, succ;
            if (index < size - index)
            {
                pred = head;
                for (int i = 0; i < index; i++)
                {
                    pred = pred.next;
                }
                succ = pred.next.next;
            }
            else
            {
                succ = tail;
                for (int i = 0; i < size - index - 1; i++)
                {
                    succ = succ.prev;
                }
                pred = succ.prev.prev;
            }
            size--;
            pred.next = succ;
            succ.prev = pred;
        }

        private sealed class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode prev;

            public ListNode(int val)
            {
                this.val = val;
            }
        }
    }
}
