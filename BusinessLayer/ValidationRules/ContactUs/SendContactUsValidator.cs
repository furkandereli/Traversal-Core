﻿using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.ContactUs
{
    public class SendContactUsValidator:AbstractValidator<SendMessageDto>
    {
        public SendContactUsValidator() 
        {
            RuleFor(x=>x.email).NotEmpty().WithMessage("Mail alanı boş geçilemez!");
            RuleFor(x => x.subject).NotEmpty().WithMessage("Konu alanı boş geçilemez!");
            RuleFor(x => x.name).NotEmpty().WithMessage("İsim alanı boş geçilemez!");
            RuleFor(x => x.messageBody ).NotEmpty().WithMessage("Mesaj alanı boş geçilemez!");

            RuleFor(x => x.subject).MinimumLength(5).WithMessage("Konu alanına en az 5 karakter veri girişi yapmalısınız!");
            RuleFor(x => x.subject).MaximumLength(100).WithMessage("Konu alanına en fazla 100 karakter veri girişi yapabilirsiniz!");
            
            RuleFor(x => x.email).MinimumLength(5).WithMessage("Mail alanına en az 5 karakter veri girişi yapmalısınız!");
            RuleFor(x => x.email).MaximumLength(100).WithMessage("Mail alanına en fazla 100 karakter veri girişi yapabilirsiniz!");
        }
    }
}
