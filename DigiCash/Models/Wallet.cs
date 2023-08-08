using System;
namespace DigiCash.Models
{
    public class Wallet
    {
        public string Id { get; set; }
        public double Balance { get; set; }
        public string Currency { get; set; }
        public DateTime timeAt { get; set; }    
        public Wallet(String WalletId)
        {
            timeAt = DateTime.Now;
            this.Id = WalletId;
        }
    }
}

