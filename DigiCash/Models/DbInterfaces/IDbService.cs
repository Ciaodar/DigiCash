using System;
namespace DigiCash.Models
{
    public interface IDbService
    {
        void addValue();
        Task<Object> getValue();
        void updateValue();
        void deleteValue();
    }
}

