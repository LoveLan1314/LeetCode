﻿using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class Offer52_GetIntersectionNodeSolution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            HashSet<ListNode> set = new HashSet<ListNode>();
            while (headA != null)
            {
                set.Add(headA);
                headA = headA.next;
            }

            while (headB != null)
            {
                if (set.Contains(headB))
                {
                    return headB;
                }
                headB = headB.next;
            }
            return null;
        }
    }
}
