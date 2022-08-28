namespace LeetCode.SAOA
{
    internal sealed class GarbageCollectionSolution
    {
        public int GarbageCollection(string[] garbage, int[] travel)
        {
            return GarbageCollection(garbage, travel, 'M') + GarbageCollection(garbage, travel, 'P') + GarbageCollection(garbage, travel, 'G');
        }

        private int GarbageCollection(string[] garbage, int[] travle, char key)
        {
            var time = 0;
            var currentIndex = 0;
            for (int i = 0; i < garbage.Length; i++)
            {
                var item = garbage[i];
                var count = 0;
                foreach (var c in item)
                {
                    if (c == key)
                    {
                        count++;
                    }
                }
                if (count > 0)
                {
                    while (currentIndex != i)
                    {
                        time += travle[currentIndex];
                        currentIndex++;
                    }
                    time += count;
                }
            }
            return time;
        }
    }
}
