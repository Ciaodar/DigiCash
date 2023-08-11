using System;
using DigiCash.Models;
using DigiCash.Models.DbModels;

namespace DigiCash.Services
{
    public class PostgreSqlServices : DBModel
    {
        public override void addValue(User user)
        {

        }

        public override void addValue(string userId, Wallet wallet)
        {
            //kullanıcıya yeni bir cüzdan oluşturur
        }

        public override void deleteValue(string walletId)
        {
            //kullanıcının istediği wallet ı silmesini sağlar
        }

        public override Task<object> getValue(string obj, string id)
        {
            return base.getValue(obj, id);
        }

        public override void updateValue(Wallet wallet)
        {
            //kullanıcının yeni cüzdan değerlerini günceller
        }
    }
}

