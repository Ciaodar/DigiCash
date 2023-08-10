using DigiCash.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using MongoDB.Driver;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace DigiCash.Services
{
    public class TransactionService
    {
        private readonly MongoDbServices _mongoDbServices;
        private Wallet _wallet;

        public TransactionService(MongoDbServices mongoDbServices)
        {
            _mongoDbServices = mongoDbServices;
        }

        private void getWallet(String id)
        {
            _wallet = (Wallet)_mongoDbServices.getValue("wallet", id);
        }


        public async void addHistory(ProcessHistory processHistory)
        {
            getWallet(processHistory.WalletId);
            if(_wallet.isAtDatabase){ //burada kullanıcının databasede'de var olup olmadığını kontrol etmemiz gerekiyor
                _mongoDbServices.addValue(processHistory);
                _wallet.isAtDatabase = true;
            }else{
                _mongoDbServices.updateValue(_wallet.Id , processHistory.histories[(processHistory.histories.Length) - 1]);
            }
        }

        public async void showHistory(Wallet walletId)
        {
            _mongoDbServices.getValue("wallet" , _wallet.Id);
        }
    } 
}
