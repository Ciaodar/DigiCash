using DigiCash.Models;
using System;
using System.Threading.Tasks;

namespace DigiCash.Services.WalletServices
{
    public class WithdrawServices
    {
        /*private readonly AmountServices _amountServices;
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
                
                    Wallet wallet = await (Wallet)_postgreSqlServices.getValue("wallet", walletId);
                    if (wallet != null)
                    {
                        wallet.Balance -= amount;
                        bool updateResult = await _postgreSqlServices.UpdateValue(wallet);
                        _transactionService.addHistory(walletId, new Process("Withdraw", wallet.Balance + amount, wallet.Balance, null));
                        return updateResult;
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
        }*/
    }
}
