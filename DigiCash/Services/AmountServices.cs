using System;
namespace DigiCash.Services
{
    public class AmountServices
    {
        BalanceServices _balanceServices;
        public AmountServices(BalanceServices balanceServices)
        {
            _balanceServices = balanceServices;
        }
    }
}

