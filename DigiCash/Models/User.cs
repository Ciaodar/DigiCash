using System;
using System.ComponentModel.DataAnnotations;
namespace DigiCash.Models
{
    public class User 
    {
        Wallet wallet;
        private string? _tc;
        [Required(ErrorMessage = "Id'nizi girmek zorunludur.")]

        public string? password { get; set; }
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter içermelidir.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z]).+$", ErrorMessage = "Şifrenizde en az bir büyük ve bir küçük karakter kullanmanız gerekmektedir.")]


        public string id { get; set; }
        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public string fullName => $"{firstName} {lastName?.ToUpper()}";

        public User()
        {

        }
    }
}
