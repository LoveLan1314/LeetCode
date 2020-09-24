namespace LeetCode.AlgorithmIntervie.String
{
    internal sealed class IsPalindromeSolution
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return true;
            }
            var charList = s.ToCharArray();
            int i = 0;
            int j = charList.Length - 1;
            while (i < j)
            {
                int charI = charList[i];
                if ((charI >= 97 && charI <= 122) || (charI >= 48 && charI <= 57))
                {

                }
                else if (charI >= 65 && charI <= 90)
                {
                    charI += 32;
                }
                else
                {
                    i++;
                    continue;
                }

                int charJ = charList[j];
                if ((charJ >= 97 && charJ <= 122) || (charJ >= 48 && charJ <= 57))
                {

                }
                else if (charJ >= 65 && charJ <= 90)
                {
                    charJ += 32;
                }
                else
                {
                    j--;
                    continue;
                }

                if (charI != charJ)
                {
                    return false;
                }
                else
                {
                    i++;
                    j--;
                }
            }
            return true;
        }
    }
}
