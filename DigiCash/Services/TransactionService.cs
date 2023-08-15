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
       /* private readonly MongoDbServices _mongoDbServices;
        private Wallet _wallet;

        public TransactionService(MongoDbServices mongoDbServices)
        {
            _mongoDbServices = mongoDbServices;
        }

        private async Task<ProcessHistory?> checkHistory(string walletId)
        {
            /* try
             {
                 //return await _mongoDbServices.getValue("History", walletId);
                 return new ProcessHistory(");
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





            
                                        /*getWallet(processHistory.WalletId);
                                        if(_wallet.isAtDatabase){ //burada kullanıcının databasede'de var olup olmadığını kontrol etmemiz gerekiyor
                                            _mongoDbServices.addValue(processHistory);
                                            _wallet.isAtDatabase = true;
                                        }else{
                                            _mongoDbServices.updateValue(_wallet.Id , processHistory.histories[(processHistory.histories.Length) - 1]);
                                        }
        }


        public ProcessHistory getHistory(String walletId)
        {
            Wallet wallet = (Wallet)_mongoDbServices.getValue("wallet", walletId);
            return new ProcessHistory(wallet);
        }*/
    } 
}
