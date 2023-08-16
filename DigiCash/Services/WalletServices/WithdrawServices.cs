﻿using DigiCash.Models;
using System;
using System.Data;
using System.Threading.Tasks;

namespace DigiCash.Services.WalletServices
{
    public class WithdrawServices
    {
        private readonly AmountServices _amountServices;
        private readonly PostgreSqlServices _postgreSqlServices;
        private readonly TransactionService _transactionService;    
        public WithdrawServices(AmountServices amountServices, PostgreSqlServices postgreSqlServices, TransactionService transactionService)
        {
            _amountServices = amountServices;
            _postgreSqlServices = postgreSqlServices;
            _transactionService = transactionService;
        }

        public async Task<bool> withdraw(string walletId, double amount)
        {
            if (await _amountServices.CheckWithdrawAmount(walletId, amount))
            {
                try { 
                
                    DataTable dataTable = await _postgreSqlServices.getValue("wallet", walletId);
                    DataRow wallet = dataTable.Rows[0];
                    double _balance = (double)wallet["Balance"];
                    if (wallet != null)
                    {
                        _balance -= amount;
                        wallet["Balance"] = _balance;
                        _postgreSqlServices.updateValue(wallet);
                        _transactionService.addHistory(walletId, new Process("Withdraw", _balance + amount, _balance, null));
                        return true;
                    }
                    else
                    {
                        return false; // Cüzdan bulunamadı
                    }
                }
                catch (Exception)
                {
                    return false; // Hata durumunda false döndür
                }
            }
            return false; // Çekim miktarı uygun değil
        }
    }
}
