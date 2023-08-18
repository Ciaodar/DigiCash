﻿using System;
using System.Data;
using DigiCash.Models;

namespace DigiCash.Services.WalletServices
{
    public class DepositServices
    {
        PostgreSqlServices _postgreSqlServices;

        public DepositServices(PostgreSqlServices postgreSqlServices)
        {
            _postgreSqlServices = postgreSqlServices;
        }

        public async Task<bool> deposit(string walletId, double amount)
        {
            Wallet wallet = await _postgreSqlServices.GetWallet(walletId);//metot adları büyük olur
            double _balance = (double)wallet.Balance;
            _balance += amount;
            try
            {
                _postgreSqlServices.SetBalance(_balance, walletId);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

