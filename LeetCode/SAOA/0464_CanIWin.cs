using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SAOA
{
    internal sealed class CanIWinSolution
    {
        readonly Dictionary<int, bool> memo = new Dictionary<int, bool>();

        public bool CanIWin(int maxChoosableInteger, int desiredTotal)
        {
            if ((1 + maxChoosableInteger) * (maxChoosableInteger) / 2 < desiredTotal)
            {
                return false;
            }
            return DFS(maxChoosableInteger, 0, desiredTotal, 0);
        }

        private bool DFS(int maxChoosableInteger, int usedNumbers, int desiredTotal, int currentTotal)
        {
            if (!memo.ContainsKey(usedNumbers))
            {
                bool res = false;
                for (int i = 0; i < maxChoosableInteger; i++)
                {
                    if (((usedNumbers >> i) & 1) == 0)
                    {
                        if (i + 1 + currentTotal >= desiredTotal)
                        {
                            res = true;
                            break;
                        }
                        if (!DFS(maxChoosableInteger, usedNumbers | (1 << i), desiredTotal, currentTotal + i + 1))
                        {
                            res = true;
                            break;
                        }
                    }
                }
                memo.Add(usedNumbers, res);
            }
            return memo[usedNumbers];
        }
    }
}
