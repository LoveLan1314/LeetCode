using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.LinkedList
{
    class RemoveNthFromEndSolution
    {
        public ListNode RemoveNthFromEnd(ListNode head,int n)
        {
            ListNode faster = head;
            ListNode slower = head;
            for (int i = 0; i < n; i++)
            {
                faster = faster.next;
            }
            if(faster == null)
            {
                head = head.next;
                return head;
            }
            while(faster.next != null)
            {
                slower = slower.next;
                faster = faster.next;
            }
            slower.next = slower.next.next;
            return head;
        }
    }
}
