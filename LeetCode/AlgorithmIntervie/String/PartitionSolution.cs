using System.Collections.Generic;

namespace LeetCode.AlgorithmIntervie.String
{
    internal sealed class PartitionSolution
    {
        public IList<IList<string>> Partition(string s)
        {
            var result = new List<IList<string>>();
            var temp = new List<string>();
            Dfs(s, result, temp, 0);
            return result;
        }

        private void Dfs(string s, List<IList<string>> res, List<string> temp, int start)
        {
            if (start == s.Length)
            {
                res.Add(new List<string>(temp));
                return;
            }
            for (int i = start; i < s.Length; i++)
            {
                if (IsPartition(s, start, i))
                {
                    temp.Add(s[start..(i + 1)]);
                    Dfs(s, res, temp, i + 1);
                    temp.RemoveAt(temp.Count - 1);
                }
            }
        }

        private bool IsPartition(string s, int start, int i)
        {
            while (start < i)
            {
                if (s[start] != s[i])
                {
                    return false;
                }
                start++;
                i--;
            }
            return true;
        }

    }
}
