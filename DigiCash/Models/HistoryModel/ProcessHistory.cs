using System;
namespace DigiCash.Models
{
    public class ProcessHistory
    {
        public string WalletId { get; set; } 
        public History[] histories { get; set; }

    }
}

