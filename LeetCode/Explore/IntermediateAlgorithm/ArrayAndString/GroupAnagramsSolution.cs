using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Explore.IntermediateAlgorithm.ArrayAndString
{
    class GroupAnagramsSolution
    {
        /// <summary>
        /// 此方法超时
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            List<IList<string>> result = new List<IList<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                string str = strs[i];
                bool isAdded = false;
                foreach (var item in result)
                {
                    if (CheckEctopicWord(item[0], str))
                    {
                        item.Add(str);
                        isAdded = true;
                        break;
                    }
                }
                if (!isAdded)
                {
                    result.Add(new List<string>
                    {
                        str
                    });
                }
            }
            return result;
        }

        private bool CheckEctopicWord(string s1, string s2)
        {
            for (int i = 0; i < s2.Length; i++)
            {
                if (!s1.Contains(s2[i].ToString()))
                {
                    return false;
                }
            }
            return true;
        }

        public IList<IList<string>> GroupAnagrams1(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return new List<IList<string>>();
            }
            Dictionary<string, List<string>> pairs = new Dictionary<string, List<string>>();
            foreach (var s in strs)
            {
                var arr = s.ToList();
                arr.Sort();
                string key = new string(arr.ToArray());
                if (!pairs.ContainsKey(key))
                {
                    pairs[key] = new List<string>();
                }
                pairs[key].Add(s);
            }
            return new List<IList<string>>(pairs.Values);
        }
    }
}
