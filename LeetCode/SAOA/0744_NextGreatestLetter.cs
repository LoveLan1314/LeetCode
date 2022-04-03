namespace LeetCode.SAOA
{
    internal sealed class NextGreatestLetterSolution
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            foreach (var item in letters)
            {
                if (item > target)
                {
                    return item;
                }
            }
            return letters[0];
        }
    }
}
