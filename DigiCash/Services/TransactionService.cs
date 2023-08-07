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
        private readonly IMongoCollection<Transaction> _transactions;

        public TransactionService(String connectionString)
        {
            
        }

        public void DatabaseConnection()
        {

        }

        public async void addHistory(ProcessHistory processHistory)
        {
            
        }

        public async void showHistory(Wallet walletId)
        {

        }
    } 
}
