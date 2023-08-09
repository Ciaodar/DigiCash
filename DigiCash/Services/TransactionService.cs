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
        private readonly MongoDbServices _mongoDbService;
        private Wallet _wallet;
        private void getWallet(String id)
        {
            _wallet = new Wallet(id);
        }

        public TransactionService(String walletId , MongoDbServices mongoDbServices)
        {
            getWallet(walletId);
            _mongoDbService = mongoDbServices;

        }

        public async void addHistory(ProcessHistory processHistory)
        {
            if(_wallet.isAtDatabase){ //burada kullanıcının databasede'de var olup olmadığını kontrol etmemiz gerekiyor
                _mongoDbService.addValue(processHistory);
                _wallet.isAtDatabase = true;
            }else{
                _mongoDbService.updateValue(_wallet.Id , processHistory.histories[(processHistory.histories.Length) - 1]);
            }
        }

        public async void showHistory(Wallet walletId)
        {
            _mongoDbService.getValue(_wallet.Id);
        }
    } 
}
