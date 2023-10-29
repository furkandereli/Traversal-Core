using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator() 
        {
            RuleFor(x=> x.name).NotEmpty().WithMessage("Rehber adı zorunlu alandır");
            RuleFor(x => x.description).NotEmpty().WithMessage("Rehber açıklaması zorunlu alandır");
            RuleFor(x => x.image).NotEmpty().WithMessage("Rehber fotoğrafı zorunlu alandır");
            RuleFor(x => x.name).MaximumLength(30).WithMessage("Ad Soyad 30 karakteri aşmamalıdır");
            RuleFor(x => x.name).MinimumLength(8).WithMessage("Ad Soyad en az 8 karakter olmalıdır");
        }
    }
}
