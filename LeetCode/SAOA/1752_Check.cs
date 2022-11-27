namespace LeetCode.SAOA
{
    internal sealed class CheckSllution
    {
        public bool Check(int[] nums)
        {
            bool existDesc = false;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[i - 1])
                {
                    if (existDesc)
                    {
                        return false;
                    }
                    else
                    {
                        existDesc = true;
                    }
                }
            }
            if (existDesc)
            {
                return nums[0] >= nums[^1];
            }
            else
            {
                return true;
            }
        }
    }
}
