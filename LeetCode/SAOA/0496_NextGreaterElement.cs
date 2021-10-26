namespace LeetCode.SAOA
{
    internal sealed class NextGreaterElementSolution
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            for (int i = 0; i < nums1.Length; i++)
            {
                int value = nums1[i];
                bool findRepeat = false;
                bool find = false;
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (findRepeat)
                    {
                        if (nums2[j] > value)
                        {
                            find = true;
                            nums1[i] = nums2[j];
                            break;
                        }
                    }
                    else
                    {
                        if (nums2[j] == value)
                        {
                            findRepeat = true;
                        }
                    }
                }
                if (!find)
                {
                    nums1[i] = -1;
                }
            }
            return nums1;
        }
    }
}
