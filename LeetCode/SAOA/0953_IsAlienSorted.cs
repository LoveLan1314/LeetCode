using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class IsAlienSortedSolution
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            for (int i = 0; i < words.Length - 1; i++)
            {
                var item1 = words[i];
                var item2 = words[i + 1];
                for (int j = 0; j < item1.Length; j++)
                {
                    if (j >= item2.Length)
                    {
                        return false;
                    }
                    var index1 = FindIndex(order, item1[j]);
                    var index2 = FindIndex(order, item2[j]);
                    if (index1 < index2)
                    {
                        break;
                    }
                    else if (index1 > index2)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private int FindIndex(string order, char c)
        {
            for (int i = 0; i < order.Length; i++)
            {
                if(order[i] == c)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
