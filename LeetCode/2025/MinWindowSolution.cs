using System.Collections.Generic;

namespace LeetCode._2025
{
    internal sealed class MinWindowSolution
    {
        private readonly Dictionary<char, int> _ori = new Dictionary<char, int>();
        private readonly Dictionary<char, int> _cnt = new Dictionary<char, int>();
        public string MinWindow(string s, string t)
        {
            int tLen = t.Length;
            for (int i = 0; i < tLen; i++)
            {
                var c = t[i];
                if (_ori.TryGetValue(c, out var count))
                {
                    _ori[c] = count + 1;
                }
                else
                {
                    _ori.Add(c, 1);
                }
            }

            int l = 0;
            int r = -1;
            int len = int.MaxValue, ansL = -1, ansR = -1;
            int sLen = s.Length;
            while (r < sLen)
            {
                ++r;
                if (r < sLen && _ori.ContainsKey(s[r]))
                {
                    var c = s[r];
                    if (_cnt.TryGetValue(c, out var count))
                    {
                        _cnt[c] = count + 1;
                    }
                    else
                    {
                        _cnt.Add(c, 1);
                    }
                }
                while (Check() && l <= r)
                {
                    if (r - l + 1 < len)
                    {
                        len = r - l + 1;
                        ansL = l;
                        ansR = l + len;
                    }
                    var c = s[l];
                    if (_ori.ContainsKey(c))
                    {
                        _cnt[c]--;
                    }
                    ++l;
                }
            }
            return ansL == -1 ? "" : s[ansL..ansR];
        }

        private bool Check()
        {
            foreach (var c in _ori)
            {
                if (_cnt.TryGetValue(c.Key, out var count))
                {
                    if (count < c.Value)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}