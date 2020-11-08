namespace LeetCode.AlgorithmIntervie.String
{
    internal sealed class IsAnagramSolution
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            int[] sList = new int[26];
            int[] tList = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                sList[s[i] - 97]++;
                tList[t[i] - 97]++;
            }

            for (int i = 0; i < 26; i++)
            {
                if (sList[i] != tList[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
