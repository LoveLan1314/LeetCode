using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class SubdomainVisitsSolution
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            var pairs = new Dictionary<string, int>();
            foreach (var item in cpdomains)
            {
                var arr = item.Split(" ");
                var count = int.Parse(arr[0]);
                var address = arr[1];
                var finish = false;
                do
                {
                    if (pairs.TryGetValue(address, out var c))
                    {
                        pairs[address] = count + c;
                    }
                    else
                    {
                        pairs.Add(address, count);
                    }
                    var index = address.IndexOf('.');
                    if (index == -1)
                    {
                        finish = true;
                    }
                    else
                    {
                        address = address[(index + 1)..];
                    }
                } while (!finish);
            }
            return pairs.Select(i => $"{i.Value.ToString()} {i.Key}").ToList();
        }
    }
}
