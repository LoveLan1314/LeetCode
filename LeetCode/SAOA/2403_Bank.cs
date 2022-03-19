namespace LeetCode.SAOA
{
    internal sealed class Bank
    {
        private readonly long[] _accounts;

        public Bank(long[] balance)
        {
            _accounts = balance;
        }

        public bool Transfer(int account1, int account2, long money)
        {
            if (_accounts.Length >= account1 && _accounts.Length >= account2)
            {
                if (_accounts[account1 - 1] >= money)
                {
                    _accounts[account1 - 1] -= money;
                    _accounts[account2 - 1] += money;
                    return true;
                }
            }
            return false;
        }

        public bool Deposit(int account, long money)
        {
            if (_accounts.Length >= account)
            {
                _accounts[account - 1] += money;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Withdraw(int account, long money)
        {
            if (_accounts.Length >= account && _accounts[account - 1] >= money)
            {
                _accounts[account - 1] -= money;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
