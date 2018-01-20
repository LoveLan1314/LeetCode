namespace ConsoleApplication.Algorithms.Fifty
{
    class SwapNodesInPairs
    {
        public ListNode SwapPairs(ListNode head){
            ListNode fackHead = new ListNode(-1);
            fackHead.next = head;
            ListNode ptr1 = fackHead;
            ListNode ptr2 = head;
            ListNode nextStart;
            while(ptr2 != null && ptr2.next != null){
                nextStart = ptr2.next.next;
                ptr2.next.next = ptr2;
                ptr1.next = ptr2.next;
                ptr2.next = nextStart;
                ptr1 = ptr2;
                ptr2 = ptr2.next;
            }
            return fackHead.next;
        }
    }
}