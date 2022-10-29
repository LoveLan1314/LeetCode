using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class CountMatchesSolution
    {
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            var index = ruleKey switch
            {
                "type" => 0,
                "color" => 1,
                "name" => 2,
                _ => -1,
            };
            var count = 0;
            foreach (var item in items)
            {
                if (item[index] == ruleValue)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
