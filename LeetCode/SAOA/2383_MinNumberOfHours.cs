namespace LeetCode.SAOA
{
    internal sealed class _2383_MinNumberOfHoursSolution
    {
        public int MinNumberOfHours(int initialEnergy, int initialExperience, int[] energy, int[] experience)
        {
            int sum = 0;
            foreach (int i in energy)
            {
                sum += i;
            }
            int trainingHours = initialEnergy > sum ? 0 : sum + 1 - initialEnergy;
            foreach (int i in experience)
            {
                if (initialExperience <= i)
                {
                    trainingHours += 1 + (i - initialExperience);
                    initialExperience = 2 * i + 1;
                }
                else
                {
                    initialExperience += i;
                }
            }
            return trainingHours;
        }
    }
}
