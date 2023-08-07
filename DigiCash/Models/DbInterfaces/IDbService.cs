using System;
namespace DigiCash.Models
{
    public interface IDbService
    {
        void addValue();
        void getValue();
        void updateValue();
        void deleteValue();
    }
}

