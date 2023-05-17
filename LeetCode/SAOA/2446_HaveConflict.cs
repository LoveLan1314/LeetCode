namespace LeetCode.SAOA
{
    internal sealed class _2446_HaveConflictSolution
    {
        public bool HaveConflict(string[] event1, string[] event2)
        {
            int event1Start = CalcMins(event1[0]);
            int event1End = CalcMins(event1[1]);
            int event2Start = CalcMins(event2[0]);
            int event2End = CalcMins(event2[1]);
            if (event1Start < event2Start)
            {
                return event1End > event2Start;
            }
            else
            {
                return event2End > event1Start;
            }
        }

        private int CalcMins(string time)
        {
            return int.Parse(time[..2]) * 60 + int.Parse(time.Substring(3, 2));
        }
    }
}
