namespace LeetCode.SAOA
{
    internal sealed class _2806_AccountBalanceAfterPurchaseSolution
    {
        public int AccountBalanceAfterPurchase(int purchaseAmount)
        {
            if (purchaseAmount % 10 == 0)
            {
                return 100 - purchaseAmount;
            }
            else
            {
                return 100 - (purchaseAmount / 10 + 1) * 10;
            }
        }
    }
}