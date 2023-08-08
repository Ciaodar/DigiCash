using DigiCash.Models;
using Microsoft.AspNetCore.Mvc;
namespace DigiCash.Services
{
    public class WalletServices
    {
        PostgreSqlServices _postgreSqlServices;
        AmountServices _amountServices;
        BalanceServices _balanceServices;

        public WalletServices(AmountServices amountServices, PostgreSqlServices postgreSqlServices,BalanceServices balanceServices ) {
            _amountServices = amountServices;
            _postgreSqlServices = postgreSqlServices;
            _balanceServices = balanceServices;
        }
        public async Task<bool> withdraw(string walletId, double amount)
        {
            bool response =  _amountServices.WithdrawMoney(walletId, amount);
            if (response) { return true; } else { return false; }
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
        public async Task<bool> transfer(string walletId, double amount, string targetwalletId)
        {
            bool response = _amountServices.TransferMoney(walletId,targetwalletId, amount);
            if (response) { return true; } else { return false; }

        }
        public async Task<double> showBalance(string walletId)
        {
            return _balanceServices.getBalance();
        }
    }
}

