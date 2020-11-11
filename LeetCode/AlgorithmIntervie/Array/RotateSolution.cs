namespace LeetCode.AlgorithmIntervie.Array
{
    internal sealed class RotateSolution
    {
        public void Rotate(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0 || k % nums.Length == 0)
            {
                return;
            }

            int turns = k % nums.Length;
            int middle = nums.Length - turns;

            Reverse(nums, 0, middle - 1);
            Reverse(nums, middle, nums.Length - 1);
            Reverse(nums, 0, nums.Length - 1);
        }

        private void Reverse(int[] arr, int s, int e)
        {
            while (s < e)
            {
                int temp = arr[s];
                arr[s] = arr[e];
                arr[e] = temp;

                s++;
                e--;
            }
        }
    }
}
