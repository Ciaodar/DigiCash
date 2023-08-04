using System;
namespace DigiCash.Models
{
    public class User 
    {
        Wallet wallet;
        public string? id { get; set; } = string.Empty;
        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public string fullName => $"{firstName} {lastName.ToUpper()}";

        public User()
        {

        }
    }
}