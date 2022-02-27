using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class OptimalDivisionSolution
    {
        public string OptimalDivision(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0].ToString();
            }
            if (nums.Length == 2)
            {
                return nums[0].ToString() + "/" + nums[1].ToString();
            }
            StringBuilder sb = new StringBuilder();
            sb.Append(nums[0]);
            sb.Append("/(");
            for (int i = 1; i < nums.Length; i++)
            {
                sb.Append(nums[i]);
                sb.Append('/');
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append(')');
            return sb.ToString();
        }
    }
}
