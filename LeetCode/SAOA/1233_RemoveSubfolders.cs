using System;
using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class _1233_RemoveSubfoldersSolution
    {
        public IList<string> RemoveSubfolders(string[] folder)
        {
            Array.Sort(folder);
            var result = new List<string>() { folder[0] };
            int n = folder.Length;
            for (int i = 1; i < n; i++)
            {
                string prevValue = result[^1];
                int pre = prevValue.Length;
                if (!(pre < folder[i].Length && prevValue.Equals(folder[i][..pre]) && folder[i][pre] == '/'))
                {
                    result.Add(folder[i]);
                }
            }
            return result;
        }
    }
}
