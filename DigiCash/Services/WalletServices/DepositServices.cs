using System;
using System.Data;
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
            DataTable dataTable = await _postgreSqlServices.getValue("wallets", walletId);
            DataRow wallet = dataTable.Rows[0];
            double _balance = (double)wallet["Balance"];
            _balance += amount;
            try
            {
                wallet["Balance"] = _balance;
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

