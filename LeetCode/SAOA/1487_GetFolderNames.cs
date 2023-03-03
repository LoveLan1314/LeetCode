using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class _1487_GetFolderNamesSolution
    {
        public string[] GetFolderNames(string[] names)
        {
            var pairs = new Dictionary<string, int>();
            int n = names.Length;
            string[] res = new string[n];
            for (int i = 0; i < n; i++)
            {
                string name = names[i];
                if (!pairs.ContainsKey(name))
                {
                    res[i] = name;
                    pairs.Add(name, 1);
                }
                else
                {
                    int k = pairs[name];
                    while (pairs.ContainsKey(AddSuffix(name, k)))
                    {
                        k++;
                    }
                    res[i] = AddSuffix(name, k);
                    pairs[name] = k + 1;
                    pairs.Add(AddSuffix(name, k), 1);
                }
            }
            return res;
        }

        private string AddSuffix(string name, int k)
        {
            return name + "(" + k + ")";
        }
    }
}
