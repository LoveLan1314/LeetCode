using System.Collections.Generic;

namespace LeetCode.Explore.IntermediateAlgorithm.BackTracing
{
    internal class SubsetsSolution
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            BackTrack(result, new List<int>(), nums, 0);
            return result;
        }

        private void BackTrack(List<IList<int>> list, List<int> temp, int[] nums, int j)
        {
            list.Add(new List<int>(temp));
            for (int i = j; i < nums.Length; i++)
            {
                temp.Add(nums[i]);
                BackTrack(list, temp, nums, i + 1);
                temp.RemoveAt(temp.Count - 1);
            }
        }
    }
}
