using DigiCash.Models;
using System;
namespace DigiCash.Services
{
    public class BalanceServices
    {
        Wallet _wallet;
        public void getWallet(String walletId)
        {
            _wallet = new Wallet(walletId);
        }
        public double getBalance() {
            return _wallet.Balance;
        }
    }
}

