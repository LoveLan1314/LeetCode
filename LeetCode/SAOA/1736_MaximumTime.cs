using System.Linq;
using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class MaximumTimeSolution
    {
        public string MaximumTime(string time)
        {
            StringBuilder sb = new StringBuilder();
            char[] array = time.ToArray();
            if (array[0] == '?')
            {
                if (array[1] != '?' && array[1] > '3')
                {
                    sb.Append('1');
                }
                else
                {
                    sb.Append('2');
                }
            }
            else
            {
                sb.Append(array[0]);
            }
            if (array[1] == '?')
            {
                if (sb[0] == '2')
                {
                    sb.Append('3');
                }
                else
                {
                    sb.Append('9');
                }
            }
            else
            {
                sb.Append(array[1]);
            }
            sb.Append(array[2]);
            if (array[3] == '?')
            {
                sb.Append('5');
            }
            else
            {
                sb.Append(array[3]);
            }
            if (array[4] == '?')
            {
                sb.Append('9');
            }
            else
            {
                sb.Append(array[4]);
            }
            return sb.ToString();
        }
    }
}
