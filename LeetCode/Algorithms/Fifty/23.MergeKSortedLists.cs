namespace ConsoleApplication.Algorithms.Fifty
{
    class MergeKSortedLists
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            return Partition(lists, 0, lists.Length - 1);
        }

        ListNode Partition(ListNode[] lists, int start, int end)
        {
            if (start == end)
            {
                return lists[start];
            }
            if (start < end)
            {
                int mid = (start + end) / 2;
                ListNode l1 = Partition(lists, start, mid);
                ListNode l2 = Partition(lists, mid + 1, end);
                return MergeTwoLists(l1, l2);
            }
            return null;
        }

        ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            ListNode tmp = null;
            if (l1.val > l2.val)
            {
                tmp = l2;
                tmp.next = MergeTwoLists(l1, l2.next);
            }
            else
            {
                tmp = l1;
                tmp.next = MergeTwoLists(l1.next, l2);
            }
            return tmp;
        }
    }
}