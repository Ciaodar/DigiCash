using System;
using System.ComponentModel.DataAnnotations;
namespace DigiCash.Models
{
    public class User 
    {
        public string? tc { get; set; }
        [Required(ErrorMessage = "TC'nizi girmek zorunludur.")]
        public string firstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Lütfen bir isim giriniz.")]
        public string lastName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Lütfen soyadınızı giriniz.")]
        public string? password { get; set; }
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter içermelidir.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z]).+$", ErrorMessage = "Şifrenizde en az bir büyük ve bir küçük karakter kullanmanız gerekmektedir.")]
        public string WalletId { get; set; }

    }
}
