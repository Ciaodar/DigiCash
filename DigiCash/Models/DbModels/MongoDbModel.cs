using System;
namespace DigiCash.Models.DbModels
{
    public abstract class MongoDbModel : IDbService
    {
        public virtual void addValue() { }
        public virtual void addValue(ProcessHistory processHistory) { }
        public virtual void deleteValue() { }
        public virtual void getValue() { }
        public virtual void getValue(string WalletId) { }
        public virtual void updateValue() { }
        public virtual void updateValue(string WalletId, History historyValue) { }
    }
}

