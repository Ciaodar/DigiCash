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

        private async Task<ProcessHistory?> checkHistory(string walletId)
        {
             try
             {
                 //return await _mongoDbServices.getValue("History", walletId);
                 return new ProcessHistory();
             }
             catch (Exception)
             {
                 return null;
             }
            return null;
        }


        public async void addHistory(string walletId,Process process)
        {
            _mongoDbServices.addValue( new ProcessHistory(walletId,process));
        }


        public ProcessHistory getHistory(String walletId)
        {
            Wallet wallet = (Wallet)_mongoDbServices.getValue("wallet", walletId);
            return new ProcessHistory(wallet);
        }
    } 
}
