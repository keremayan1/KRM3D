using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gender.Application.Features.Genders.Commands.CreateGender
{
    public class CreateGenderCommandValidator : AbstractValidator<CreateGenderCommand>
    {
        public CreateGenderCommandValidator()
        {
            RuleFor(c => c.GenderName).NotEmpty().WithMessage("Gender Name musn't empty");
            RuleFor(c => c.GenderName).MinimumLength(2).WithMessage("Gender Name less than minimum length 2");
            RuleFor(c => c.GenderName).MaximumLength(64);
        }
    }
}
