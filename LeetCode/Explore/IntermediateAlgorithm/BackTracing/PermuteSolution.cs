using System.Collections.Generic;

namespace LeetCode.Explore.IntermediateAlgorithm.BackTracing
{
    internal class PermuteSolution
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            BackTrack(result, new List<int>(), nums);
            return result;
        }

        private void BackTrack(List<IList<int>> list, List<int> temp, int[] nums)
        {
            if (temp.Count == nums.Length)
            {
                list.Add(new List<int>(temp));
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (temp.Contains(nums[i]))
                    {
                        continue;
                    }
                    temp.Add(nums[i]);
                    BackTrack(list, temp, nums);
                    temp.RemoveAt(temp.Count - 1);
                }
            }
        }
    }
}
