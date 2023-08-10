using DigiCash.Models;
/*namespace DigiCash.Services
{
    public class WalletServices
    {
        PostgreSqlServices _postgreSqlServices;
        AmountServices _amountServices;
        BalanceServices _balanceServices;

        public WalletServices(AmountServices amountServices, PostgreSqlServices postgreSqlServices,BalanceServices balanceServices ) {
            _amountServices = amountServices;
            _postgreSqlServices = postgreSqlServices;
            _balanceServices = balanceServices;
        }
        public async Task<bool> withdraw(string walletId, double amount)
        {
            return _amountServices.WithdrawMoney(walletId, amount);
            
        }
        public async Task<bool> deposit(string walletId, double amount)
        {
            Wallet wallet = (Wallet)_postgreSqlServices.getValue("wallet", walletId);
            wallet.Balance += amount;
            try
            {
                _postgreSqlServices.updateValue(wallet);
                return true;
            }
            catch (Exception)
            {
                return false;
            }        
        }
        public async Task<bool> transfer(string walletId, double amount, string targetWalletId)
        {
            return _amountServices.TransferMoney(walletId,targetWalletId, amount);
            
        }
        public async Task<double> showBalance(string walletId)
        {
            return _balanceServices.getBalance();
        }
    }
}*/

