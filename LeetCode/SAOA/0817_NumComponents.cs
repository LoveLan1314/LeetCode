using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class NumComponentsSolution
    {
        public int NumComponents(ListNode head, int[] nums)
        {
            var set = nums.ToHashSet();
            var count = 0;
            var prevExists = false;
            while (head != null)
            {
                if (set.Contains(head.val))
                {
                    if (!prevExists)
                    {
                        count++;
                        prevExists = true;
                    }
                }
                else
                {
                    prevExists = false;
                }
                head = head.next;
            }
            return count;
        }
    }
}
