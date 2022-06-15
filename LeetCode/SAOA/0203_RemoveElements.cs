namespace LeetCode.SAOA
{
    internal sealed class RemoveElementsSolution1
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            var node = head;
            ListNode prev = null;
            while (node != null)
            {
                if (node.val == val)
                {
                    if (node == head)
                    {
                        head = node.next;
                    }
                    else
                    {
                        prev.next = node.next;
                    }
                }
                else
                {
                    prev = node;
                }
                node = node.next;
            }
            return head;
        }

        public ListNode RemoveElements1(ListNode head, int val)
        {
            if (head == null)
            {
                return head;
            }
            head.next = RemoveElements1(head.next, val);
            return head.val == val ? head.next : head;
        }
    }
}
