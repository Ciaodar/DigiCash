using System;
namespace DigiCash.Models
{
    public class Wallet
    {
        public string? Id { get; set; }
        public double Balance { get; set; }
        public string Currency { get; set; }
        public Boolean isAtDatabase = false;
        public ProcessHistory walletHistory;
        public Wallet(String WalletId)
        {
            this.Id = WalletId;
        }
    }
}

