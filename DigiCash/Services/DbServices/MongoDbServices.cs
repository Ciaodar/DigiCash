﻿using System;
using DigiCash.Models;
using DigiCash.Models.DbModels;

namespace DigiCash.Services
{
    public class MongoDbServices : DBModel
    {
        public override void addValue(ProcessHistory processHistory)
        {
            //wallet ilk yapılan işlemi tarihe ekler
        }

        public override void getValue(string WalletId)
        {
            Wallet wallet = new Wallet(WalletId);
            for(int a = 1; a <= wallet.walletHistory.histories.Length; a++)
            {
                
            }
            //walletid ile kullanıcının geçmiş işlemlerini getireceğiz
        }

        public override void updateValue(string WalletId, History historyValue)
        {
            //yapılan işlemi var olan geçmiş dizisine ekler
        }
    }
}

