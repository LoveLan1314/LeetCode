namespace ConsoleApplication.Algorithms.Fifty
{
    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class RemoveNthNodeFromEndofList
    {
        public ListNode Calc(ListNode head, int n)
        {
            if (head == null || head.next == null)
            {
                return null;
            }
            ListNode faster = head;
            ListNode slower = head;
            for (int i = 0; i < n; i++)
            {
                faster = faster.next;
            }
            if (faster == null)
            {
                head = head.next;
                return head;
            }
            while (faster.next != null)
            {
                slower = slower.next;
                faster = faster.next;
            }
            slower.next = slower.next.next;
            return head;
        }
    }

}