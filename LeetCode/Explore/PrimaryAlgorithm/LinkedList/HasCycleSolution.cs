﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.LinkedList
{
    class HasCycleSolution
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return false;
            }
            ListNode fast = head;
            ListNode slow = head;
            while(slow != null && fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if(fast == slow)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
