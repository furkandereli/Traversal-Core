using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDto>
    {
        public AnnouncementValidator() 
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Başlık boş geçilemez !");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Duyuru boş geçilemez !");

            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Başlık en az 5 karakter olmalı !");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("İçerik en az 20 karakter olmalı !");

            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Başlık en fazla 50 karakter olmalı !");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("İçerik en fazla 500 karakter olmalı !");
        }
    }
}
