using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class DisplayTableSolution
    {
        public IList<IList<string>> DisplayTable(IList<IList<string>> orders)
        {
            HashSet<string> foods = new HashSet<string>();
            Dictionary<int, Dictionary<string, int>> pairs = new Dictionary<int, Dictionary<string, int>>();
            foreach (var order in orders)
            {
                var table = int.Parse(order[1]);
                var food = order[2];
                if (!foods.Contains(food))
                {
                    foods.Add(food);
                }
                if (pairs.TryGetValue(table, out var orderPairs))
                {
                    if (orderPairs.ContainsKey(food))
                    {
                        orderPairs[food]++;
                    }
                    else
                    {
                        orderPairs.Add(food, 1);
                    }
                }
                else
                {
                    pairs.Add(table, new Dictionary<string, int>() { { food, 1 } });
                }
            }

            IList<IList<string>> result = new List<IList<string>>();
            var tableLine = new List<string>()
            {
                "Table"
            };
            var foodList = foods.ToList();
            foodList.Sort((a, b) => string.CompareOrdinal(a, b));
            foreach (var item in foodList)
            {
                tableLine.Add(item);
            }
            result.Add(tableLine);
            foreach (var item in pairs.OrderBy(i => i.Key))
            {
                var line = new List<string>
                {
                    item.Key.ToString()
                };
                foreach (var food in foodList)
                {
                    if (item.Value.TryGetValue(food, out var count))
                    {
                        line.Add(count.ToString());
                    }
                    else
                    {
                        line.Add("0");
                    }
                }
                result.Add(line);
            }
            return result;
        }
    }
}
