using System;
using DigiCash.Models;

namespace DigiCash.Services.WalletServices
{
    public class DepositServices
    {
        PostgreSqlServices _postgreSqlServices;

        public DepositServices(PostgreSqlServices postgreSqlServices)
        {
            _postgreSqlServices = postgreSqlServices;
        }

        public async Task<bool> deposit(string walletId, double amount)
        {
            Wallet wallet = (Wallet)_postgreSqlServices.getValue("wallet", walletId);
            wallet.Balance += amount;
            try
            {
                _postgreSqlServices.updateValue(wallet);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

