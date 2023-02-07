using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class _1604_AlertNamesSolution
    {
        public IList<string> AlertNames(string[] keyName, string[] keyTime)
        {
            var pairs = new Dictionary<string, List<int>>();
            int n = keyName.Length;
            for (int i = 0; i < n; i++)
            {
                string name = keyName[i];
                string time = keyTime[i];
                int hour = (time[0] - '0') * 10 + (time[1] - '0');
                int minute = (time[3] - '0') * 10 + (time[4] - '0');
                int minutes = hour * 60 + minute;
                if (pairs.TryGetValue(name, out var times))
                {
                    times.Add(minutes);
                }
                else
                {
                    pairs.Add(name, new List<int>() { minutes });
                }
            }
            var result = new List<string>();
            foreach (KeyValuePair<string, List<int>> pair in pairs)
            {
                string name = pair.Key;
                List<int> times = pair.Value;
                times.Sort();
                int size = times.Count;
                for (int i = 2; i < size; i++)
                {
                    if (times[i] - times[i - 2] <= 60)
                    {
                        result.Add(name);
                        break;
                    }
                }
            }
            result.Sort();
            return result;
        }
    }
}
