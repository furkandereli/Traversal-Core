using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TraversalCore.Models
{
    public class ResetPasswordViewModel
    {
        [Required]
        public string Password { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Confirm password zorunludur !")]
        [Compare("Password",ErrorMessage = "Parolalar eşleşmedi, lütfen tekrar deneyiniz !")]
        public string ConfirmPassword { get; set; }
    }
}
