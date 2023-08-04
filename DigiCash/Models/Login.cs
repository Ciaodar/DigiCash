using System.ComponentModel.DataAnnotations;

namespace DigiCash.Models
{
    public class Login
    {
        private string? _id;
        [Required(ErrorMessage = "Id'nizi girmek zorunludur.")]

        public string? password { get; set; }
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter içermelidir.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z]).+$", ErrorMessage = "Şifrenizde en az bir büyük ve bir küçük karakter kullanmanız gerekmektedir.")]

        public string ReturnUrl
        {
            get{
                if(_id is null)
                    return "/";
                else
                    return _id;
            }
            set{
                _id = value;
            }
        }
    }
}
