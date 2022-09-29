namespace LeetCode.SAOA
{
    internal sealed class IsFlipedStringSolution
    {
        public bool IsFlipedString(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }
            var s = s2 + s2;
            return s.Contains(s1);
        }
    }
}
