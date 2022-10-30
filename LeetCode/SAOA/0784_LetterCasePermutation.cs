﻿using System.Collections.Generic;
using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class LetterCasePermutationSolution
    {
        public IList<string> LetterCasePermutation(string s)
        {
            IList<string> ans = new List<string>();
            Queue<StringBuilder> queue = new Queue<StringBuilder>();
            queue.Enqueue(new StringBuilder());
            while (queue.Count > 0)
            {
                StringBuilder curr = queue.Peek();
                if (curr.Length == s.Length)
                {
                    ans.Add(curr.ToString());
                    queue.Dequeue();
                }
                else
                {
                    int pos = curr.Length;
                    if (char.IsLetter(s[pos]))
                    {
                        StringBuilder next = new StringBuilder(curr.ToString());
                        next.Append((char)(s[pos] ^ 32));
                        queue.Enqueue(next);
                    }
                    curr.Append(s[pos]);
                }
            }
            return ans;
        }
    }
}
