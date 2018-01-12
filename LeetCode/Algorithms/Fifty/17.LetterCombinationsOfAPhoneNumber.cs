using System.Collections.Generic;

namespace ConsoleApplication.Algorithms.Fifty
{
    class LetterCombinationsOfAPhoneNumber
    {
        private string[] table = new string[] { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
        public IList<string> LetterCombination(string digits)
        {
            List<string> list = new List<string>();
            if(!string.IsNullOrEmpty(digits))
            {
                LetterCombinations(list, digits, "", 0);
            }
            return list;
        }

        private void LetterCombinations(List<string> list, string digtis, string curr, int index)
        {
            if (index == digtis.Length)
            {
                if (curr.Length != 0)
                {
                    list.Add(curr);
                    return;
                }
            }
            //string temp = table[int.Parse(digtis.Substring(index,1))];
            string temp = table[digtis[index] - '0'];
            for (int i = 0; i < temp.Length; i++)
            {
                string next = curr + temp[i];
                LetterCombinations(list, digtis, next, index + 1);
            }
        }
    }
}