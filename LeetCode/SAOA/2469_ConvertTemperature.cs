namespace LeetCode.SAOA
{
    internal sealed class _2469_ConvertTemperatureSolution
    {
        public double[] ConvertTemperature(double celsius)
        {
            return new double[] { celsius + 273.15, celsius * 1.80 + 32 };
        }
    }
}
