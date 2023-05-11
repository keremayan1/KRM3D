using FluentValidation;
namespace Gender.Application.Features.Genders.Commands.UpdateGender
{
    public partial class UpdateGenderCommand
    {
        public class UpdateGenderCommandValidator : AbstractValidator<UpdateGenderCommand>
        {
            public UpdateGenderCommandValidator()
            {
                RuleFor(c => c.GenderName).NotEmpty().WithMessage("Gender Name musn't empty");
                RuleFor(c => c.GenderName).MinimumLength(2).WithMessage("Gender Name less than minimum length 2");
                RuleFor(c => c.GenderName).MaximumLength(64);
            }
        }
    }
}
