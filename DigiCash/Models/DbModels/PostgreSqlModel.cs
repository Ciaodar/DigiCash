using System;
using DigiCash.Models;

namespace DigiCash.Models.DbModels
{
    public abstract class PostgreSqlModel : IDbService
    {
        public abstract void addValue();
        public abstract void deleteValue();
        public abstract void getValue();
        public abstract void updateValue();
    }
}

