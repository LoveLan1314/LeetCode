using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.String
{
    class ReverseSolution
    {
        public int Reverse(int x)
        {
            char[] vs = x.ToString().ToCharArray();
            int index = 0;
            int length = vs.Length;
            if (vs[0] == '-')
            {
                index++;
                length--;
            }
            for (int i = index; i < length / 2 + index; i++)
            {
                char swap = vs[i];
                vs[i] = vs[vs.Length - 1 + index - i];
                vs[vs.Length - 1 + index - i] = swap;
            }
            int.TryParse(new string(vs), out int result);
            return result;
        }

        public int Reverse1(int x)
        {
            char[] vs = x.ToString().ToCharArray();
            int index = 0;
            if (vs[0] == '-')
            {
                index++;
            }
            for (int i = index; i < vs.Length / 2 + index; i++)
            {
                char swap = vs[i];
                vs[i] = vs[vs.Length - 1 + index - i];
                vs[vs.Length - 1 + index - i] = swap;
            }
            int.TryParse(new string(vs), out int result);
            return result;
        }
    }
}
