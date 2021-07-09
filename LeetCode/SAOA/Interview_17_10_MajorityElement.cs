namespace LeetCode.SAOA
{
    internal sealed class MajorityElementSolution
    {
        public int MajorityElement(int[] nums)
        {
            int result = -1;
            int count = 0;
            foreach (var num in nums)
            {
                if (count == 0)
                {
                    result = num;
                }
                if (num == result)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            count = 0;
            foreach (var num in nums)
            {
                if (num == result)
                {
                    count++;
                }
            }
            return count * 2 > nums.Length ? result : -1;
        }
    }
}
