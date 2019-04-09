namespace LeetCode.Explore.AdvancedAlgorithm.LinkedList
{
    internal class SortListSolution
    {
        public ListNode SortList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            };
            QsortList(head, null);
            return head;
        }

        private void QsortList(ListNode head, ListNode tail)
        {
            if (head != tail && head.next != tail)
            {
                ListNode mid = PartitionList(head, tail);
                QsortList(head, mid);
                QsortList(mid.next, tail);
            }
        }

        private ListNode PartitionList(ListNode low, ListNode high)
        {
            int key = low.val;
            ListNode loc = low;
            for (ListNode i = low.next; i != high; i = i.next)
            {
                if (i.val < key)
                {
                    loc = loc.next;
                    Swap(i, loc);
                }
            }
            Swap(loc, low);
            return loc;
        }

        private void Swap(ListNode left, ListNode right)
        {
            int temp = right.val;
            right.val = left.val;
            left.val = temp;
        }
    }
}
