using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class ReformatNumberSolution
    {
        public string ReformatNumber(string number)
        {
            number = number.Replace(" ", "").Replace("-", "");
            var n = number.Length;
            var mod = n % 3;
            var count = n / 3;
            if (mod == 1 || mod == 0)
            {
                count--;
            }
            var sb = new StringBuilder();
            for (int i = 0; i < number.Length; i++)
            {
                sb.Append(number[i]);
                if (count > 0)
                {
                    if (i % 3 == 2)
                    {
                        sb.Append('-');
                        count--;
                    }
                }
                else
                {
                    if (mod == 1 && i % 3 == 1)
                    {
                        sb.Append('-');
                    }
                }
            }
            return sb.ToString();
        }
    }
}
