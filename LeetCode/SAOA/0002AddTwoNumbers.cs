namespace LeetCode.SAOA
{
    internal sealed class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            var root = result;
            bool needAdd = false;
            do
            {
                int value = 0;
                if (l1 != null)
                {
                    value += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    value += l2.val;
                    l2 = l2.next;
                }
                if (needAdd)
                {
                    value++;
                    needAdd = false;
                }
                if (value >= 10)
                {
                    needAdd = true;
                    value -= 10;
                }
                result.next = new ListNode(value);
                result = result.next;
            } while (l1 != null || l2 != null);
            if (needAdd)
            {
                result.next = new ListNode(1);
            }
            return root.next;
        }
    }
}
