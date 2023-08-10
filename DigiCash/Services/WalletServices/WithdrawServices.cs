using System;
namespace DigiCash.Services.WalletServices
{
    public class WithdrawServices
    {
        AmountServices _amountServices;
        PostgreSqlServices _postgreSqlServices;
        public WithdrawServices(AmountServices amountServices, PostgreSqlServices postgreSqlServices)
        {
            _amountServices = amountServices;
            _postgreSqlServices = postgreSqlServices;
        }
        public async Task<bool> withdraw(string walletId, double amount)
        {
            if (await _amountServices.CheckWithdrawAmount(walletId, amount))
            {
                return true;
            }
            return false;
        }
    }
}

