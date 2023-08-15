using System;
using System.Data;
using DigiCash.Models;

namespace DigiCash.Models.DbModels
{
    public abstract class DBModel : IDbService
    {
        public async virtual void addValue() { }
        public async virtual void addValue(User user) { }
        public async virtual void addValue(string userId, Wallet wallet) { }
        public async virtual void addValue(ProcessHistory processHistory) { }
        public async virtual void deleteValue() { }
        public async virtual void deleteValue(string walletId) { }
        public async virtual Task<Object> getValue() { return false; }
        public async virtual Task<Object> getValue(string id) { return false; }
        public async virtual Task<DataTable> getValue(string obj,string id) { return null; }
        public async virtual void updateValue() { }
        public async virtual void updateValue(DataRow wallet) { }
        public async virtual void updateValue(string WalletId, Process historyValue) { }
    }
}