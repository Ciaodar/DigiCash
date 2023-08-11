using DigiCash.Models;
using System;
using System.Threading.Tasks;

namespace DigiCash.Services.WalletServices
{
    public class WithdrawServices
    {
        private readonly AmountServices _amountServices;
        private readonly PostgreSqlServices _postgreSqlServices;

        public WithdrawServices(AmountServices amountServices, PostgreSqlServices postgreSqlServices)
        {
            _amountServices = amountServices;
            _postgreSqlServices = postgreSqlServices;
        }

        public async Task<bool> withdraw(string walletId, double amount)
        {
            if (await _amountServices.CheckWithdrawAmount(walletId, amount))
            {
                try { 
                
                    Wallet wallet = await _postgreSqlServices.getValue<Wallet>("wallet", walletId);
                    if (wallet != null)
                    {
                        wallet.Balance -= amount;
                        bool updateResult = await _postgreSqlServices.UpdateValue(wallet);
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
        }
    }
}
