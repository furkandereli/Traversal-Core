using Microsoft.AspNetCore.Identity;

namespace TraversalCore.Models
{
	public class CustomIdentityValidator : IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError(){
				Code = "PasswordTooShort",
				Description = $"Parola Minimum {length} karakter olmalıdır."
			};
		}

		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiredUpper",
				Description = "Parola en az 1 büyük karakter içermelidir."
			};
		}

		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiredLower",
				Description = "Parola en az 1 küçük karakter içermelidir."
			};
		}

		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresNonAlphanumeric",
				Description = "Parola en az 1 sembol içermelidir."
			};
		}
	}
}
