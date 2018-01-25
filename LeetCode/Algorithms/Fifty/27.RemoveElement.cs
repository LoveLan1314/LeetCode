namespace ConsoleApplication.Algorithms.Fifty
{
    class RemoveElement
    {
        public int calc(int[] nums,int val){
            int removeCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == val){
                    removeCount++;
                }
                else{
                    nums[i - removeCount] = nums[i];
                }
            }
            return nums.Length - removeCount;
        }
    }
}