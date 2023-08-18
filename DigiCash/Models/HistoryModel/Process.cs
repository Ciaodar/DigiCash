using System;
namespace DigiCash.Models
{
    public class Process
    {
        public string ProcessName { get; set; }
        public double OldBalance { get; set; }
        public double NewBalance { get; set; }
        public string? TargetWalletId { get; set; }
        public DateTimeOffset DateTime { get; set; }
        public Process(string processName, double oldBalance, double newBalance, string? targetWalletId)
        {
            this.ProcessName = processName;
            this.OldBalance = oldBalance;
            this.NewBalance = newBalance;
            this.TargetWalletId = targetWalletId;
            DateTime = DateTimeOffset.UtcNow;
        }
    }
}

