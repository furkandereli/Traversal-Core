using System.ComponentModel.DataAnnotations;

namespace TraversalCore.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage ="Lütfen adınızı giriniz !")]
		public string name { get; set; }

		[Required(ErrorMessage = "Lütfen soyadınızı giriniz !")]
		public string surname { get; set; }

		[Required(ErrorMessage = "Lütfen username giriniz !")]
		public string username { get; set; }

		[Required(ErrorMessage = "Lütfen email giriniz !")]
		public string email { get; set; }

		[Required(ErrorMessage = "Lütfen şifre giriniz !")]
		public string password { get; set; }

		[Required(ErrorMessage = "Lütfen şifre giriniz !")]
		[Compare("password",ErrorMessage ="Şifreler aynı değil, lütfen kontrol ediniz !")]
		public string confirmPassword { get; set; }
	}
}
