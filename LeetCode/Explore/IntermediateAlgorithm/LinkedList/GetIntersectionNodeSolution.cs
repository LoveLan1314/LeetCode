using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.IntermediateAlgorithm.LinkedList
{
    class GetIntersectionNodeSolution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
            {
                return null;
            }
            ListNode p = headA;
            ListNode q = headB;
            void ToListNodeEnd()
            {
                while (p != null && q != null)
                {
                    p = p.next;
                    q = q.next;
                }
                if (p == null)
                {
                    p = headB;
                }
                else
                {
                    q = headA;
                }
            }
            ToListNodeEnd();
            ToListNodeEnd();
            while (p != null && q != null)
            {
                if (p == q)
                {
                    return p;
                }
                p = p.next;
                q = q.next;
            }
            return null;
        }
    }
}
