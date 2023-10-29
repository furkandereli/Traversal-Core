using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTOs>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.name).NotEmpty().WithMessage("Ad boş geçilemez !");
            RuleFor(x => x.surname).NotEmpty().WithMessage("Soyad boş geçilemez !");
            RuleFor(x => x.email).NotEmpty().WithMessage("Email boş geçilemez !");
            RuleFor(x => x.username).NotEmpty().WithMessage("Kullanıcı Adı boş geçilemez !");
            RuleFor(x => x.password).NotEmpty().WithMessage("Şifre boş geçilemez !");
            RuleFor(x => x.confirmPassword).NotEmpty().WithMessage("Şifre Tekrar boş geçilemez !");

            RuleFor(x => x.username).MinimumLength(5).WithMessage("Kullanıcı Adı en az 5 karakter olmalıdır !");
            RuleFor(x => x.username).MaximumLength(20).WithMessage("Kullanıcı Adı en çok 20 karakter olmalıdır !");

            RuleFor(x => x.password).Equal(y => y.confirmPassword).WithMessage("Şifreler aynı olmalı !");
        }
    }
}
