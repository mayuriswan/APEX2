using FluentValidation;
using TelerikBlazorDemos.Models.Form;

namespace APEX2.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(user => user.Email)
                .NotEmpty().WithMessage("You must specify email.")
                .EmailAddress().WithMessage("You must specify a valid email address.");

            RuleFor(user => user.Password)
                .NotEmpty().WithMessage("Your password should be at least 8 characters.")
                .MinimumLength(8).WithMessage("Your password should be at least 8 characters.");
        }
    }
}
