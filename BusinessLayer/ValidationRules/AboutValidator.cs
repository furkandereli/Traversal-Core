using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class AboutValidator:AbstractValidator<About>
	{
        public AboutValidator()
        {
            RuleFor(x=>x.description).NotEmpty().WithMessage("Açıklama boş geçilemez !");
            RuleFor(x => x.image1).NotEmpty().WithMessage("Lütfen görsel seçiniz !");
            RuleFor(x => x.description).MinimumLength(50).WithMessage("Lütfen en az 50 karakterlik açıklama ekleyiniz !");
			RuleFor(x => x.description).MaximumLength(1500).WithMessage("Lütfen en fazla 1500 karakterlik açıklama ekleyiniz !");
		}
    }
}
