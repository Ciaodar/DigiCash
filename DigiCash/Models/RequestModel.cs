namespace DigiCash.Models
{
    
    public class RequestModel
    {
        public string? userId { get; set; }
        public string? walletId { get; set; }
        public string? targetWalletId { get; set; }
        public double? amount { get; set; }
    }
}
