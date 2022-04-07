namespace LeetCode.SAOA
{
    internal sealed class RotateStringSolution
    {
        public bool RotateString(string s, string goal)
        {
            int m = s.Length;
            int n = goal.Length;
            if (m != n)
            {
                return false;
            }

            for (int i = 0; i < n; i++)
            {
                bool flag = true;
                for (int j = 0; j < n; j++)
                {
                    if (s[(i + j) % n] != goal[j])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    return true;
                }
            }
            return false;
        }

        public bool RotateString1(string s, string goal)
        {
            return s.Length == goal.Length && (s + s).Contains(goal);
        }
    }
}
