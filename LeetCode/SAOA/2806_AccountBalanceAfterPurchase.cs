namespace LeetCode.SAOA
{
    internal sealed class _2806_AccountBalanceAfterPurchaseSolution
    {
        public int AccountBalanceAfterPurchase(int purchaseAmount)
        {
            int r = purchaseAmount % 10;
            if (r < 5)
            {
                purchaseAmount -= r;
            }
            else
            {
                purchaseAmount += 10 - r;
            }
            return 100 - purchaseAmount;
        }
    }
}