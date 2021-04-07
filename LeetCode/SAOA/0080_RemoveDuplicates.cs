namespace LeetCode.SAOA
{
    internal sealed class RemoveDuplicatesSolution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int result = nums.Length;
            int prevNum = int.MinValue;
            int numberCount = 0;
            int breakCount = 0;
            for (int i = 0; i < nums.Length - breakCount; i++)
            {
                int num = nums[i + breakCount];
                if (num == prevNum)
                {
                    if (numberCount == 2)
                    {
                        do
                        {
                            breakCount++;
                            result--;
                            if (i == nums.Length - breakCount)
                            {
                                return result;
                            }
                            num = nums[i + breakCount];
                        } while (num == prevNum);
                        prevNum = num;
                        numberCount = 1;
                    }
                    else
                    {
                        numberCount++;
                    }
                }
                else
                {
                    prevNum = num;
                    numberCount = 1;
                }
                nums[i] = num;
            }
            return result;
        }

        public int RemoveDuplicates2(int[] nums)
        {
            int length = nums.Length;
            if (length < 2)
            {
                return length;
            }
            int slow = 2, fast = 2;
            while (fast < length)
            {
                if (nums[slow - 2] != nums[fast])
                {
                    nums[slow] = nums[fast];
                    slow++;
                }
                fast++;
            }
            return slow;
        }
    }
}
