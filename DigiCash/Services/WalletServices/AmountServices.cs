using DigiCash.Models;
using ZstdSharp.Unsafe;

namespace DigiCash.Services
{
    public class AmountServices
    {
        public readonly ConfigServices _configServices;
        public readonly BalanceServices _balanceServices;
        public AmountServices(ConfigServices configServices, BalanceServices balanceServices)
        {
            _configServices = configServices;
            _balanceServices = balanceServices;
        }
        public async Task<bool> CheckWithdrawAmount(string walletId, double amount) 
        {
            if (amount < _configServices.getMaxWithdraw() && amount < /*await*/ _balanceServices.GetBalance(walletId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> CheckTransferAmount(string walletId, double amount)
        {
            if (amount < _configServices.getMaxTransfer() && amount < /*await*/ _balanceServices.GetBalance(walletId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
        // Para Transferi
        public bool TransferMoney(string senderWalletId, string receiverWalletId, double amount)
        {
            // TODO: Para transferi işlemleri burada gerçekleştirilecek
            // - Gönderen hesaptan para düşülmesi
            // - Alıcı hesaba para eklenmesi
            // - İşlem geçmişi kaydedilmesi
            // - Hata durumlarının yönetimi
            // - ...

            return true; // Transfer başarılıysa true, aksi takdirde false döndürülebilir.
        }

        // Para Çekme
        public bool WithdrawMoney(string walletId, double amount)
        {
            // TODO: Para çekme işlemleri burada gerçekleştirilecek
            // - Para çekme işlemi
            // - İşlem geçmişi kaydedilmesi
            // - Hata durumlarının yönetimi
            // - ...eklencek birşey varsa buraya

            return true; // Para çekme başarılıysa true, aksi takdirde false döndürülebilir.
        }

        internal void DepositMoney(object walletId, object amount)
        {
            throw new NotImplementedException();
        }
        */
    }
}
