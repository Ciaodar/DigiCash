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
            DataTable dataTable = await _postgreSqlServices.getValue("wallets", walletId);//metot adları büyük olur
            //DataRow wallet = dataTable.Rows[0];
            //double _balance = (double)wallet["Balance"];
            double _balance = 1.0;
            _balance += amount;
            try
            {
                _postgreSqlServices.updateValue(_balance);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

