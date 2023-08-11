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
        public async Task<double> getBalanceAsync(string walletId) {
            return 1;
        }
        public bool updateBalance(object walletId, object value)
        {
            throw new NotImplementedException();
        }
    }
}

