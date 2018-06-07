using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.LinkedList
{
    class IsPalindromeSolution
    {
        public bool IsPalindrome(ListNode head)
        {
            if(head == null)
            {
                return true;
            }

            ListNode slow = head;
            ListNode fast = head;
            while(fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            slow.next = Reverse(slow.next);
            ListNode pre = head;
            while(slow.next != null)
            {
                slow = slow.next;
                if(pre.val != slow.val)
                {
                    return false;
                }
                pre = pre.next;
            }
            return true;
        }

        private ListNode Reverse(ListNode head)
        {
            if (head == null || head.next == null)
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
