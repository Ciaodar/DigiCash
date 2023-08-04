using System.ComponentModel.DataAnnotations;

namespace DigiCash.Models
{
    public class Login
    {
        private string? _id;
        [Required(ErrorMessage = "Id is required.")]

        public string? password { get; set; }

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
