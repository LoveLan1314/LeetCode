using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class FindRestaurantSolution
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            Dictionary<string, int> pairs2 = new Dictionary<string, int>();
            for (int i = 0; i < list2.Length; i++)
            {
                pairs2.Add(list2[i], i);
            }
            List<string> result = new List<string>();
            var indexSum = int.MaxValue;
            for (int i = 0; i < list1.Length; i++)
            {
                if (i > indexSum)
                {
                    break;
                }
                if (pairs2.TryGetValue(list1[i], out var j))
                {
                    var index = i + j;
                    if (index < indexSum)
                    {
                        result = new List<string>()
                        {
                            list1[i]
                        };
                        indexSum = index;
                    }
                    else if (index == indexSum)
                    {
                        result.Add(list1[i]);
                    }
                }
            }
            return result.ToArray();
        }
    }
}
