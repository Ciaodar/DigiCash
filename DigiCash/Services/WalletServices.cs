using DigiCash.Models;
using Microsoft.AspNetCore.Mvc;
namespace DigiCash.Services
{
    public class WalletServices
    {
        PostgreSqlServices _postgreSqlService;
        BalanceServices _balanceService;
        AmountServices _amountServices;

        public WalletServices(AmountServices amountServices, PostgreSqlServices postgreSqlServices,BalanceServices balanceServices ) {
            _amountServices = amountServices;
            _postgreSqlService = postgreSqlServices;
            _balanceService = balanceServices;
            Console.WriteLine("heloo walletttttt");
        }
        //public async void Withdraw(string walletId, double amount)
        //{
        //    Wallet wallet = postgreSqlService.getValue(walletId);
        //    bool aresponse= await amountService.CheckAmountLimit(wallet/*.walletId*/,amount);
        //    if (aresponse)
        //    {
        //        BalanceServices balanceService = new BalanceServices();
        //        bool bresponse = await balanceService.CheckBalance(wallet/*.walletId*/, amount);
        //        if (bresponse)
        //        {
        //            PostgreSqlServices postgreSqlService = new PostgreSqlServices();
        //            wallet.Balance -= amount;
        //            postgreSqlService.updateValue(wallet);
        //        }
        //    }
        //}
        //public async void deposit(string walletId, double amount)
        //{
        //    PostgreSqlServices postgreSqlService = new PostgreSqlServices();
        //    Wallet wallet = postgreSqlService.getValue(walletId);
        //    wallet.Balance += amount;
        //    postgreSqlService.updateValue(wallet);
        //}
        //public async void transfer(string walletId, double amount, string targetwalletId)
        //{
        //    PostgreSqlServices postgreSqlService = new PostgreSqlServices();
        //    Wallet wallet = postgreSqlService.getValue(walletId);
        //    Wallet targetWallet = postgreSqlService.getValue(targetwalletId);
        //    AmountServices amountService = new AmountServices();
        //    bool aresponse = await amountService.CheckAmountLimit(wallet/*.walletId*/, amount);
        //    if (aresponse)
        //    {
        //        BalanceServices balanceService = new BalanceServices();
        //        bool bresponse = await balanceService.CheckBalance(wallet/*.walletId*/, amount);
        //        if (bresponse)
        //        {
        //            wallet.Balance -= amount;
        //            targetWallet.Balance += amount;
        //            postgreSqlService.updateValue(wallet);
        //            postgreSqlService.updateValue(targetWallet);   
        //        }
        //    }
        //}
        //public async Task<double> showBalance(string walletId)
        //{
        //    PostgreSqlServices postgreSqlService = new PostgreSqlServices();
        //    Wallet wallet = postgreSqlService.getValue(walletId);
        //    return wallet.Balance;
        //}
    }
}

