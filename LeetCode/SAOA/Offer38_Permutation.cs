using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class PermutationSolution
    {
        private readonly IList<string> _rec = new List<string>();
        private bool[] _vis;

        public string[] Permutation(string s)
        {
            int n = s.Length;
            _vis = new bool[n];
            char[] arr = s.ToCharArray();
            Array.Sort(arr);
            StringBuilder perm = new StringBuilder();
            Backtrack(arr, 0, n, perm);
            return _rec.ToArray();
        }

        private void Backtrack(char[] arr, int i, int n, StringBuilder perm)
        {
            if (i == n)
            {
                _rec.Add(perm.ToString());
                return;
            }
            for (int j = 0; j < n; j++)
            {
                //如果同样的字符在本次回溯中不被使用，则说明相应的字符组合已经生成过，跳过该字符
                if (_vis[j] || (j > 0 && !_vis[j - 1] && arr[j - 1] == arr[j]))
                {
                    continue;
                }
                _vis[j] = true;
                perm.Append(arr[j]);
                Backtrack(arr, i + 1, n, perm);
                perm.Length--;
                _vis[j] = false;
            }
        }
    }
}
