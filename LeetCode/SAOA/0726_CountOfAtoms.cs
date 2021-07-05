using System.Collections.Generic;
using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class CountOfAtomsSolution
    {
        private int _i;
        private int _n;
        private string _formula;

        public string CountOfAtoms(string formula)
        {
            _i = 0;
            _n = formula.Length;
            _formula = formula;
            Stack<Dictionary<string, int>> stack = new Stack<Dictionary<string, int>>();
            stack.Push(new Dictionary<string, int>());
            while (_i < _n)
            {
                char ch = formula[_i];
                if (ch == '(')
                {
                    _i++;
                    stack.Push(new Dictionary<string, int>());
                }
                else if (ch == ')')
                {
                    _i++;
                    int num = ParseNum();
                    var popDict = stack.Pop();
                    var topDict = stack.Peek();
                    foreach (var item in popDict)
                    {
                        string atom = item.Key;
                        int v = item.Value;
                        if (topDict.ContainsKey(atom))
                        {
                            topDict[atom] += v * num;
                        }
                        else
                        {
                            topDict.Add(atom, v * num);
                        }
                    }
                }
                else
                {
                    string atom = ParseAtom();
                    int num = ParseNum();
                    var topDict = stack.Peek();
                    if (topDict.ContainsKey(atom))
                    {
                        topDict[atom] += num;
                    }
                    else
                    {
                        topDict.Add(atom, num);
                    }
                }
            }

            var dictionary = stack.Pop();
            var pairs = new List<KeyValuePair<string, int>>(dictionary);
            pairs.Sort((p1, p2) => p1.Key.CompareTo(p2.Key));

            var sb = new StringBuilder();
            foreach (var item in pairs)
            {
                string atom = item.Key;
                int count = item.Value;
                sb.Append(atom);
                if(count > 1)
                {
                    sb.Append(count);
                }
            }
            return sb.ToString();
        }

        private string ParseAtom()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(_formula[_i++]); // 扫描首字母
            while (_i < _n && char.IsLower(_formula[_i]))
            {
                sb.Append(_formula[_i++]); // 扫描首字母后的小写字母
            }
            return sb.ToString();
        }

        private int ParseNum()
        {
            if (_i == _n || !char.IsNumber(_formula[_i]))
            {
                return 1; // 不是数字，视作 1
            }
            int num = 0;
            while (_i < _n && char.IsNumber(_formula[_i]))
            {
                num = num * 10 + _formula[_i++] - '0'; // 扫描数字
            }
            return num;
        }
    }
}
