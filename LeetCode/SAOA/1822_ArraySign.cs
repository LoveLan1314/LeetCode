namespace LeetCode.SAOA
{
    internal sealed class ArraySignSolution
    {
        public int ArraySign(int[] nums)
        {
            var count = 0;
            foreach (var item in nums)
            {
                if (item == 0)
                {
                    return 0;
                }
                else if (item < 0)
                {
                    count++;
                }
            }
            return count % 2 == 0 ? 1 : -1;
        }
    }
}
