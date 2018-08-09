using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.IntermediateAlgorithm.LinkedList
{
    class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }
            int val = l1.val + l2.val;
            ListNode list = new ListNode(val % 10);
            ListNode first = list;
            int target = val / 10;
            while (l1.next != null || l2.next != null)
            {
                if (l1.next == null)
                {
                    l2 = l2.next;
                    val = l2.val + target;
                }
                else if (l2.next == null)
                {
                    l1 = l1.next;
                    val = l1.val + target;
                }
                else
                {
                    l1 = l1.next;
                    l2 = l2.next;
                    val = l1.val + l2.val + target;
                }
                list.next = new ListNode(val % 10);
                list = list.next;
                target = val / 10;
            }
            if (target != 0)
            {
                list.next = new ListNode(target);
            }
            return first;
        }
    }
}
