using System;
namespace DigiCash.Services
{
    public interface IDbService
    {
        void addValue();
        void getValue();
        void updateValue();
        void deleteValue();
    }
}

