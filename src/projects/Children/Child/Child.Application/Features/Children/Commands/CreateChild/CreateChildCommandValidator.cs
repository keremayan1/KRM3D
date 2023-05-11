using FluentValidation;
namespace Child.Application.Features.Children.Commands.CreateChild
{
    public class CreateChildCommandValidator : AbstractValidator<CreateChildCommand>
    {
        public CreateChildCommandValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty();
        }
    }

}
