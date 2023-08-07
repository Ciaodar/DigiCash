using System;
namespace DigiCash.Models.DbModels
{
    public abstract class MongoDbModel : IDbService
    {
        public virtual void addValue() { }
        public virtual void addValue(int i) { }
        public abstract void deleteValue();
        public abstract void getValue();
        public abstract void updateValue();
    }
}

