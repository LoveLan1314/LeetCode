using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class FindTheWinnerSolution
    {
        public int FindTheWinner1(int n, int k)
        {
            var queue = new Queue<int>();
            for (int i = 1; i <= n; i++)
            {
                queue.Enqueue(i);
            }
            while (queue.Count > 1)
            {
                for (int i = 1; i < k; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                queue.Dequeue();
            }
            return queue.Peek();
        }

        public int FindTheWinner(int n, int k)
        {
            if (n == 1)
            {
                return 1;
            }
            return (k + FindTheWinner(n - 1, k) - 1) % n + 1;
        }
    }
}
