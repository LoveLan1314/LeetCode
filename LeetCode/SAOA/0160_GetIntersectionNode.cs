using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class GetIntersectionNodeSolution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            HashSet<ListNode> set = new HashSet<ListNode>();
            ListNode temp = headA;
            while (temp != null)
            {
                set.Add(temp);
                temp = temp.next;
            }

            temp = headB;
            while (temp != null)
            {
                if (set.Contains(temp))
                {
                    return temp;
                }
                temp = temp.next;
            }
            return null;
        }

        public ListNode GetIntersectionNode1(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
            {
                return null;
            }

            ListNode pA = headA, pB = headB;
            while (pA != pB)
            {
                pA = pA == null ? headB : pA.next;
                pB = pB == null ? headA : pB.next;
            }
            return pA;
        }
    }
}
