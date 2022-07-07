﻿using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class ReplaceWordsSolution
    {
        public string ReplaceWords(IList<string> dictionary, string sentence)
        {
            ISet<string> dictionarySet = new HashSet<string>();
            foreach (string root in dictionary)
            {
                dictionarySet.Add(root);
            }
            string[] words = sentence.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                for (int j = 0; j < word.Length; j++)
                {
                    if (dictionarySet.Contains(word.Substring(0, 1 + j)))
                    {
                        words[i] = word.Substring(0, 1 + j);
                        break;
                    }
                }
            }
            return string.Join(" ", words);
        }
    }
}
