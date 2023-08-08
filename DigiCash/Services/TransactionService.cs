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

        public TransactionService(MongoDbServices mongoDbServices , String walletId)
        {
            getWallet(walletId);
            _mongoDbService = mongoDbServices;

        }

        public async void addHistory(ProcessHistory processHistory)
        {
            if(processHistory == null){
                _mongoDbService.addValue(processHistory);
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
