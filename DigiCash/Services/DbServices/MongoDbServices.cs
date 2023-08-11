using System;
using DigiCash.Models;
using DigiCash.Models.DbModels;
using MongoDB.Driver;

namespace DigiCash.Services
{
    public class MongoDbServices : DBModel
    {

        private readonly IMongoCollection<ProcessHistory> _collection;

        public MongoDbServices(string connectionString , string dbName)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(dbName);
            _collection = database.GetCollection<ProcessHistory>("ProcessHistories");
        }
        public async override void addValue(ProcessHistory processHistory)
        {
            _collection.InsertOne(processHistory);
            //wallet ilk yapılan işlemi tarihe ekler
        }

       public async override Task<Object> getValue(string obj , string id)
        {
            //Wallet wallet = new Wallet(id);
            //for(int a = 1; a <= wallet.walletHistory.histories.Length; a++)
            //{
            //    return (Object)wallet.walletHistory.histories[(wallet.walletHistory.histories.Length) - a];
            //}
            return false;
            //walletid ile kullanıcının geçmiş işlemlerini getireceğiz
        }

        public async override void updateValue(string WalletId, History historyValue)
        {
            var filter = Builders<ProcessHistory>.Filter.Eq("WalletId", WalletId);
            var update = Builders<ProcessHistory>.Update.Set("History", historyValue);

            _collection.UpdateOne(filter, update);
            //yapılan işlemi var olan geçmiş dizisine ekler
        }
    }
}

