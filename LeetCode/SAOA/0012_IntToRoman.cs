using System;
using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class IntToRomanSolution
    {
        private readonly Tuple<int, string>[] valueSymbols = new Tuple<int, string>[]
        {
            new Tuple<int, string>(1000, "M"),
            new Tuple<int, string>(900, "CM"),
            new Tuple<int, string>(500, "D"),
            new Tuple<int, string>(400, "CD"),
            new Tuple<int, string>(100, "C"),
            new Tuple<int, string>(90, "XC"),
            new Tuple<int, string>(50, "L"),
            new Tuple<int, string>(40, "XL"),
            new Tuple<int, string>(10, "X"),
            new Tuple<int, string>(9, "IX"),
            new Tuple<int, string>(5, "V"),
            new Tuple<int, string>(4, "IV"),
            new Tuple<int, string>(1, "I")
        };

        public string IntToRoman(int num)
        {
            StringBuilder sb = new StringBuilder();
            while (num > 0)
            {
                for (int i = 0; i < valueSymbols.Length; i++)
                {
                    var item = valueSymbols[i];
                    if (num >= item.Item1)
                    {
                        sb.Append(item.Item2);
                        num -= item.Item1;
                        break;
                    }
                }
            }
            return sb.ToString();
        }
    }
}
