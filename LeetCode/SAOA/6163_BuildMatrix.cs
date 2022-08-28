using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class BuildMatrixSolution
    {
        public int[][] BuildMatrix(int k, int[][] rowConditions, int[][] colConditions)
        {
            var rowLinkList = new LinkedList<int>();
            var rowPairs = new Dictionary<int, LinkedListNode<int>>();
            foreach (var item in rowConditions)
            {
                if (rowPairs.TryGetValue(item[0], out var node1))
                {
                    if (rowPairs.TryGetValue(item[1], out var node2))
                    {
                        var isMatch = false;
                        while (node1.Next != null)
                        {
                            if (node1.Next == node2)
                            {
                                isMatch = true;
                                break;
                            }
                            else
                            {
                                node1 = node1.Next;
                            }
                        }
                        if (!isMatch)
                        {
                            return System.Array.Empty<int[]>();
                        }
                    }
                    else
                    {
                        var newNode = rowLinkList.AddAfter(node1, item[1]);
                        rowPairs.Add(item[1], newNode);
                    }
                }
                else
                {
                    if (rowPairs.TryGetValue(item[1], out var node2))
                    {
                        var newNode = rowLinkList.AddBefore(node2, item[0]);
                        rowPairs.Add(item[0], newNode);
                    }
                    else
                    {
                        var newNode1 = rowLinkList.AddLast(item[0]);
                        rowPairs.Add(item[0], newNode1);
                        var newNode2 = rowLinkList.AddLast(item[1]);
                        rowPairs.Add(item[1], newNode2);
                    }
                }
            }
            var rowDict = new Dictionary<int, int>();
            var rowI = 0;
            foreach (var item in rowLinkList)
            {
                rowDict.Add(item, rowI);
                rowI++;
            }
            for (int i = 1; i <= k; i++)
            {
                if (!rowDict.ContainsKey(i))
                {
                    rowDict.Add(i, rowI);
                    rowI++;
                }
            }

            var colLinkList = new LinkedList<int>();
            var colPairs = new Dictionary<int, LinkedListNode<int>>();
            foreach (var item in colConditions)
            {
                if (colPairs.TryGetValue(item[0], out var node1))
                {
                    if (colPairs.TryGetValue(item[1], out var node2))
                    {
                        var isMatch = false;
                        while (node1.Next != null)
                        {
                            if (node1.Next == node2)
                            {
                                isMatch = true;
                                break;
                            }
                            else
                            {
                                node1 = node1.Next;
                            }
                        }
                        if (!isMatch)
                        {
                            return System.Array.Empty<int[]>();
                        }
                    }
                    else
                    {
                        var newNode = colLinkList.AddAfter(node1, item[1]);
                        colPairs.Add(item[1], newNode);
                    }
                }
                else
                {
                    if (colPairs.TryGetValue(item[1], out var node2))
                    {
                        var newNode = colLinkList.AddBefore(node2, item[0]);
                        colPairs.Add(item[0], newNode);
                    }
                    else
                    {
                        var newNode1 = colLinkList.AddLast(item[0]);
                        colPairs.Add(item[0], newNode1);
                        var newNode2 = colLinkList.AddLast(item[1]);
                        colPairs.Add(item[1], newNode2);
                    }
                }
            }

            var colDict = new Dictionary<int, int>();
            var colI = 0;
            foreach (var item in colLinkList)
            {
                colDict.Add(item, colI);
                colI++;
            }
            for (int i = 1; i <= k; i++)
            {
                if (!colDict.ContainsKey(i))
                {
                    colDict.Add(i, colI);
                    colI++;
                }
            }

            var result = new int[k][];
            var j = 0;
            foreach (var item in rowDict.OrderBy(i => i.Value))
            {
                var list = new int[k];
                if (colDict.TryGetValue(item.Key, out var index))
                {
                    list[index] = item.Key;
                }
                result[j] = list;
                j++;
            }
            return result;
        }
    }
}
