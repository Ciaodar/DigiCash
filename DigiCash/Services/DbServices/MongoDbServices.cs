using System;
using DigiCash.Models;
using DigiCash.Models.DbModels;
using MongoDB.Bson;
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
            _collection = database.GetCollection<ProcessHistory>("hareketler");
        }
        public async override void addValue(ProcessHistory processHistory)
        {
            await _collection.UpdateOneAsync(Builders<ProcessHistory>.Filter.Eq( _ => _.WalletId, processHistory.WalletId),
                Builders<ProcessHistory>.Update.SetOnInsert( _ => _.WalletId, processHistory.WalletId).
                    Push("hareketler", processHistory.histories[0]),
                new UpdateOptions() { IsUpsert = true });
            return;
        }

       public async override Task<Object> getValue(string id)
        {
            var filter = Builders<ProcessHistory>.Filter
                .Eq(r => r.WalletId, id);
            return await _collection.Find(filter).FirstOrDefaultAsync();
        }
    }
}

