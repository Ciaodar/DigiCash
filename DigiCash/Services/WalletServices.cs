using DigiCash.Models;
using Microsoft.AspNetCore.Mvc;
namespace DigiCash.Services
{
    public class WalletServices
    {
        public async void Withdraw(string walletId, double amount)
        {
            PostgreSqlServices pservice = new PostgreSqlServices();
            Wallet wallet = pservice.getValue(walletId);
            AmountServices aservice = new AmountServices();
            bool aresponse= await aservice.CheckAmountLimit(wallet/*.walletId*/,amount);
            if (aresponse)
            {
                BalanceServices bservice = new BalanceServices();
                bool bresponse = await bservice.CheckBalance(wallet/*.walletId*/, amount);
                if (bresponse)
                {
                    PostgreSqlServices pservice = new PostgreSqlServices();
                    wallet.Balance -= amount;
                    pservice.updateValue(wallet);
                }
            }
        }
        public async void deposit(string walletId, double amount)
        {
            PostgreSqlServices pservice = new PostgreSqlServices();
            Wallet wallet = pservice.getValue(walletId);
            wallet.Balance += amount;
            pservice.updateValue(wallet);
        }
        public async void transfer(string walletId, double amount, string targetwalletId)
        {
            PostgreSqlServices pservice = new PostgreSqlServices();
            Wallet wallet = pservice.getValue(walletId);
            Wallet targetWallet = pservice.getValue(targetwalletId);
            AmountServices aservice = new AmountServices();
            bool aresponse = await aservice.CheckAmountLimit(wallet/*.walletId*/, amount);
            if (aresponse)
            {
                BalanceServices bservice = new BalanceServices();
                bool bresponse = await bservice.CheckBalance(wallet/*.walletId*/, amount);
                if (bresponse)
                {
                    wallet.Balance -= amount;
                    targetWallet.Balance += amount;
                    pservice.updateValue(wallet);
                    pservice.updateValue(targetWallet);   
                }
            }
        }
        public async Task<double> showBalance(string walletId)
        {
            PostgreSqlServices pservice = new PostgreSqlServices();
            Wallet wallet = pservice.getValue(walletId);
            return wallet.Balance;
        }
    }
}

