namespace LeetCode.SAOA
{
    internal sealed class RemoveElementsSolution
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode prev = null;
            ListNode temp = head;
            while (temp != null)
            {
                if (temp.val == val)
                {
                    if (prev == null)
                    {
                        head = head.next;
                    }
                    else
                    {
                        prev.next = temp.next;
                    }
                }
                else
                {
                    prev = temp;
                }
                temp = temp.next;
            }
            return head;
        }

        public ListNode RemoveElements1(ListNode head, int val)
        {
            ListNode dummyHead = new ListNode(0)
            {
                next = head
            };
            ListNode temp = dummyHead;
            while (temp.next != null)
            {
                if (temp.next.val == val)
                {
                    temp.next = temp.next.next;
                }
                else
                {
                    temp = temp.next;
                }
            }
            return dummyHead.next;
        }
    }
}
