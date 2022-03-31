using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class SelfDividingNumbersSolution
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            var list = new List<int>();
            for (int i = left; i <= right; i++)
            {
                if (IsSelfDividingNumber(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }

        private bool IsSelfDividingNumber(int number)
        {
            foreach (var item in number.ToString())
            {
                var value = int.Parse(item.ToString());
                if (value == 0 || number % value != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
