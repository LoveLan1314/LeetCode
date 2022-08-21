namespace LeetCode.SAOA
{
    internal sealed class MinNumberOfHoursSolution
    {
        public int MinNumberOfHours(int initialEnergy, int initialExperience, int[] energy, int[] experience)
        {
            var needEnergy = 0;
            var needExperience = 0;
            var n = energy.Length;
            for (int i = 0; i < n; i++)
            {
                var energyValue = energy[i];
                var experienceValue = experience[i];
                if (initialEnergy <= energyValue)
                {
                    var increaseEnergy = energyValue - initialEnergy + 1;
                    needEnergy += increaseEnergy;
                    initialEnergy += increaseEnergy;
                }
                if (initialExperience <= experienceValue)
                {
                    var increaseExperience = experienceValue - initialExperience + 1;
                    needExperience += increaseExperience;
                    initialExperience += increaseExperience;
                }
                initialEnergy -= energyValue;
                initialExperience += experienceValue;
            }
            return needEnergy + needExperience;
        }
    }
}
