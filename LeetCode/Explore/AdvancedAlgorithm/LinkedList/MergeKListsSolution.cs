using System.Collections.Generic;

namespace LeetCode.Explore.AdvancedAlgorithm.LinkedList
{
    internal class MergeKListsSolution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0)
            {
                return null;
            }
            PriorityQueue<ListNode> heap = new PriorityQueue<ListNode>(new ListNodePriorityComparer());
            foreach (var item in lists)
            {
                if (item != null)
                {
                    heap.Push(item);
                }
            }

            ListNode newHead = null;
            ListNode p = null;
            while (heap.Count != 0)
            {
                ListNode q = heap.Top();
                heap.Pop();
                if (q.next != null)
                {
                    heap.Push(q.next);
                }
                if (newHead == null)
                {
                    newHead = q;
                    p = q;
                }
                else
                {
                    p.next = q;
                    p = p.next;
                }
            }
            return newHead;
        }
    }

    /// <summary>
    /// 倒序排序，数字小的优先级更高
    /// </summary>
    internal class ListNodePriorityComparer : IComparer<ListNode>
    {
        public int Compare(ListNode x, ListNode y)
        {
            if (x.val > y.val)
            {
                return -1;
            }
            if (x.val < y.val)
            {
                return 1;
            }
            return 0;
        }
    }
}
