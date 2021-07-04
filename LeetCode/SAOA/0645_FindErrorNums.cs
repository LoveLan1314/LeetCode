namespace LeetCode.SAOA
{
    internal sealed class FindErrorNumsSolution
    {
        public int[] FindErrorNums(int[] nums)
        {
            int[] data = new int[nums.Length + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                data[nums[i]]++;
            }
            int num1 = 0;
            int num2 = 0;
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] == 0)
                {
                    num2 = i;
                }
                if (data[i] == 2)
                {
                    num1 = i;
                }
            }
            return new int[] { num1, num2 };
        }
    }
}
