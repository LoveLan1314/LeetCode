using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.LinkedList
{
    class ReverseListSolution
    {
        public ListNode ReverseList(ListNode head)
        {
            if(head == null || head.next == null)
            {
                return head;
            }
            ListNode cur = head;
            ListNode newH = null;
            while (cur != null)
            {
                ListNode tmp = cur.next;
                cur.next = newH;
                newH = cur;
                cur = tmp;
            }
            return newH;
        }
    }
}
