using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.IntermediateAlgorithm.LinkedList
{
    class OddEvenListSolution
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null || head.next == null || head.next.next == null)
            {
                return head;
            }
            ListNode first = head;
            ListNode eventList = new ListNode(0);
            ListNode eventFirst = eventList;
            while (head.next != null)
            {
                eventList.next = head.next;
                eventList = eventList.next;
                head.next = head.next.next;
                eventList.next = null;
                if(head.next != null)
                {
                    head = head.next;
                }
            }
            head.next = eventFirst.next;
            return first;
        }
    }
}
