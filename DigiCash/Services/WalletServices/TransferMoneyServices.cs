using DigiCash.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using MongoDB.Bson;
using System;
namespace DigiCash.Services.WalletServices
{
    public class TransferMoneyServices
    {
        /*PostgreSqlServices _postgreSqlServices;
        AmountServices _amountServices;

        public TransferMoneyServices(PostgreSqlServices postgreSqlServices , AmountServices amountServices)
        {
            _amountServices = amountServices;
            _postgreSqlServices = postgreSqlServices;
        }

        public async Task<bool> transferMoney(string walletId , string targetWalletId , double amount)
        {
            if(await _amountServices.CheckTransferAmount(walletId,amount))
            {
                Wallet wallet = (Wallet)_postgreSqlServices.getValue("wallet", walletId);
                wallet.Balance -= amount;
                Wallet targetWallet = (Wallet)_postgreSqlServices.getValue("target", targetWalletId);
                targetWallet.Balance += amount;
                try
                {
                    _postgreSqlServices.updateValue(wallet);
                    _postgreSqlServices.updateValue(targetWallet);
                    return true;
                }catch (Exception ex)
                {
                    return false;
                }
            }
            return false;
        }*/
    }
}

