using System;
namespace DigiCash.Models
{
    public interface IDbService
    {
        void addValue();
        Object getValue();
        void updateValue();
        void deleteValue();
    }
}

