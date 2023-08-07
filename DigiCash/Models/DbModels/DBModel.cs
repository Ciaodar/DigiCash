using System;
using DigiCash.Models;

namespace DigiCash.Models.DbModels
{
    public abstract class DBModel : IDbService
    {
        public virtual void addValue() { }
        public virtual void addValue(User user) { }
        public virtual void addValue(string userId, Wallet wallet) { }
        public virtual void addValue(ProcessHistory processHistory) { }
        public virtual void deleteValue() { }
        public virtual void deleteValue(string walletId) { }
        public virtual void getValue() { }
        public virtual void getValue(string id) { }
        public virtual void getValue(Wallet wallet) { }
        public virtual void updateValue() { }
        public virtual void updateValue(Wallet wallet) { }
        public virtual void updateValue(string WalletId, History historyValue) { }
    }
}