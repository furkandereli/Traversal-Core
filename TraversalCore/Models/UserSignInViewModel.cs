using System.ComponentModel.DataAnnotations;

namespace TraversalCore.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz !")]
        public string? username { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi doğru giriniz !")]
        public string? password { get; set; }
    }
}
