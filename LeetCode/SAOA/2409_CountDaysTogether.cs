using System;

namespace LeetCode.SAOA
{
    internal sealed class _2409_CountDaysTogetherSolution
    {
        private readonly int[] _sets = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public int CountDaysTogether(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob)
        {
            int arriveAliceDays = CalcDays(arriveAlice);
            int leaveAliceDays = CalcDays(leaveAlice);
            int arriveBobDays = CalcDays(arriveBob);
            int leaveBobDays = CalcDays(leaveBob);
            if (arriveAliceDays < arriveBobDays)
            {
                if (leaveAliceDays < arriveBobDays)
                {
                    return 0;
                }
                return Math.Min(leaveAliceDays, leaveBobDays) - Math.Max(arriveAliceDays, arriveBobDays) + 1;
            }
            else
            {
                if (leaveBobDays < arriveAliceDays)
                {
                    return 0;
                }
                return Math.Min(leaveBobDays, leaveAliceDays) - Math.Max(arriveBobDays, arriveAliceDays) + 1;
            }
        }

        private int CalcDays(string time)
        {
            var arr = time.Split('-');
            int days = 0;
            int month = int.Parse(arr[0]);
            for (int i = 0; i < month - 1; i++)
            {
                days += _sets[i];
            }
            days += int.Parse(arr[1]);
            return days;
        }
    }
}
