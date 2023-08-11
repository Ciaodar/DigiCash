using System;
namespace DigiCash.Models
{
    public class Process
    {
        public string processName { get; set; }
        public double oldBalance { get; set; }
        public double newBalance { get; set; }
        public string? targetWalletId { get; set; }
        public DateTime DateTime { get; set; }
        public Process(string processName, double oldBalance, double newBalance, string? targetWalletId)
        {
            this.processName = processName;
            this.oldBalance = oldBalance;
            this.newBalance = newBalance;
            this.targetWalletId = targetWalletId;
            DateTime = DateTime.Now;
        }
    }
}

