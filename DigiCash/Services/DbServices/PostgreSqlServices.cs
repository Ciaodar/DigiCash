using System;
using DigiCash.Models;
using DigiCash.Models.DbModels;

namespace DigiCash.Services
{
    public class PostgreSqlServices : DBModel
    {
        public override void addValue(User user)
        {
            //yeni bir kullanıcı oluşturur
        }

        public override void addValue(string userId, Wallet wallet)
        {
            //kullanıcıya yeni bir cüzdan oluşturur
        }

        public override void deleteValue(string walletId)
        {
            //kullanıcının istediği wallet ı silmesini sağlar
        }

        public override void getValue(string id)
        {
            //kullanıcıyı getirir
        }

        public override void getValue(Wallet wallet)
        {
            //kullanıcının istediği cüzdanı getirir
        }

        public override void updateValue(Wallet wallet)
        {
            //kullanıcının yeni cüzdan değerlerini günceller
        }
    }
}

