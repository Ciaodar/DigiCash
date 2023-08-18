using System;
namespace DigiCash.Models
{
    public class ProcessHistory
    {
        public string WalletId { get; set; }
        public List<Process> histories { get; set; } = new List<Process>();
        public ProcessHistory(string walletID,Process process)
        {
            histories.Add(process);
            WalletId = walletID;
        }
    }
}

