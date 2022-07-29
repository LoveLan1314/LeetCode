namespace LeetCode.SAOA
{
    internal sealed class ValidSquareSolution
    {
        public bool ValidSquare(int[] p1, int[] p2, int[] p3, int[] p4)
        {
            if (p1[0] == p2[0] && p1[1] == p2[1])
            {
                return false;
            }
            if (Help(p1, p2, p3, p4))
            {
                return true;
            }
            if (p1[0] == p3[0] && p1[1] == p3[1])
            {
                return false;
            }
            if (Help(p1, p3, p2, p4))
            {
                return true;
            }
            if (p1[0] == p4[0] && p1[1] == p4[1])
            {
                return false;
            }
            if (Help(p1, p4, p2, p3))
            {
                return true;
            }
            return false;
        }

        private bool Help(int[] p1, int[] p2, int[] p3, int[] p4)
        {
            int[] v1 = { p1[0] - p2[0], p1[1] - p2[1] };
            int[] v2 = { p3[0] - p4[0], p3[1] - p4[1] };
            if (CheckMidPoint(p1, p2, p3, p4) && CheckLength(v1, v2) && CalCos(v1, v2))
            {
                return true;
            }
            return false;
        }

        private bool CheckLength(int[] v1, int[] v2)
        {
            return (v1[0] * v1[0] + v1[1] * v1[1]) == (v2[0] * v2[0] + v2[1] * v2[1]);
        }

        private bool CheckMidPoint(int[] p1, int[] p2, int[] p3, int[] p4)
        {
            return (p1[0] + p2[0]) == (p3[0] + p4[0]) && (p1[1] + p2[1]) == (p3[1] + p4[1]);
        }

        private bool CalCos(int[] v1, int[] v2)
        {
            return (v1[0] * v2[0] + v1[1] * v2[1]) == 0;
        }
    }
}
