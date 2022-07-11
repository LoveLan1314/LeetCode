﻿namespace LeetCode.SAOA
{
    internal sealed class MagicDictionary
    {
        private string[] words;
        public MagicDictionary()
        {

        }

        public void BuildDict(string[] dictionary)
        {
            words = dictionary;
        }

        public bool Search(string searchWord)
        {
            foreach (string word in words)
            {
                if (word.Length != searchWord.Length)
                {
                    continue;
                }

                int diff = 0;
                for (int i = 0; i < word.Length; ++i)
                {
                    if (word[i] != searchWord[i])
                    {
                        ++diff;
                        if (diff > 1)
                        {
                            break;
                        }
                    }
                }
                if (diff == 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
