using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.IntermediateAlgorithm.Math
{
    internal class FractionToDecimalSolution
    {
        public string FractionToDecimal(long numerator, long denominator)
        {
            if (numerator == 0)
            {
                return "0";
            }
            StringBuilder sb = new StringBuilder();
            if (numerator < 0 ^ denominator < 0)
            {
                sb.Append("-");
            }
            numerator = System.Math.Abs(numerator);
            denominator = System.Math.Abs(denominator);

            sb.Append(numerator / denominator);
            long remainder = numerator % denominator;
            if (remainder == 0)
            {
                return sb.ToString();
            }
            sb.Append(".");

            Dictionary<long, int> remainders = new Dictionary<long, int>();
            int pos = sb.Length;
            int addPos = 0;
            bool flag = false;
            while (remainder != 0 && !flag)
            {
                if (remainders.ContainsKey(remainder))
                {
                    addPos = remainders[remainder];
                    flag = true;
                    continue;
                }
                remainders[remainder] = pos++;
                sb.Append(10 * remainder / denominator);
                remainder = 10 * remainder % denominator;
            }
            if (flag)
            {
                sb.Insert(addPos, "(");
                sb.Append(")");
            }
            return sb.ToString();
        }
    }
}
