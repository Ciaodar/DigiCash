using System;
namespace DigiCash.Models
{
    public class History
    {
        public string processName { get; set; }
        public double oldBalance { get; set; }
        public double newBalance { get; set; }
        public string? targetWalletId { get; set; }
        public DateTime DateTime { get; set; }
    }
}

