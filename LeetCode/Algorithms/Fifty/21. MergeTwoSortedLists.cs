namespace ConsoleApplication.Algorithms.Fifty
{
    class MergeTwoSortedLists
    {
        ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if(l1 == null) return l2;
            if(l2 == null) return l1;
            ListNode tmp = null;
            if(l1.val > l2.val){
                tmp = l2;
                tmp.next = MergeTwoLists(l1,l2.next);
            }
            else{
                tmp = l1;
                tmp.next = MergeTwoLists(l1.next,l2);
            }
            return tmp;
        }
    }
}