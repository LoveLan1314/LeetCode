using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class OpenLockSolution
    {
        public int OpenLock(string[] deadends, string target)
        {
            if (target == "0000")
            {
                return 0;
            }

            HashSet<string> deadSet = new HashSet<string>();
            for (int i = 0; i < deadends.Length; i++)
            {
                var deadend = deadends[i];
                if (deadend == "0000")
                {
                    return -1;
                }
                deadSet.Add(deadend);
            }
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("0000");
            HashSet<string> nums = new HashSet<string>
            {
                "0000"
            };
            int step = 0;
            while (queue.Count > 0)
            {
                step++;
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var status = queue.Dequeue();
                    var nextValues = Get(status);
                    for (int j = 0; j < nextValues.Count; j++)
                    {
                        var nextValue = nextValues[j];
                        if (nextValue == target)
                        {
                            return step;
                        }
                        if (deadSet.Contains(nextValue) || nums.Contains(nextValue))
                        {
                            continue;
                        }
                        queue.Enqueue(nextValue);
                        nums.Add(nextValue);
                    }
                }
            }
            return -1;
        }

        private char GetPrevNum(char c)
        {
            return c == '0' ? '9' : (char)(c - 1);
        }

        private char GetNextNum(char c)
        {
            return c == '9' ? '0' : (char)(c + 1);
        }

        private List<string> Get(string status)
        {
            var chars = status.ToCharArray();
            List<string> result = new List<string>();
            for (int i = 0; i < chars.Length; i++)
            {
                var c = chars[i];
                chars[i] = GetPrevNum(c);
                result.Add(new string(chars));
                chars[i] = GetNextNum(c);
                result.Add(new string(chars));
                chars[i] = c;
            }
            return result;
        }
    }
}
