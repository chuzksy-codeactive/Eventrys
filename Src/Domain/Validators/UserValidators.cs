using Eventrys.Src.Domain.Entities;
using FluentValidation;

namespace Eventrys.Src.Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator ()
        {
            RuleFor (x => x.Username)
                .NotEmpty()
                .Matches("^[a-zA-Z0-9]*$");
            RuleFor (x => x.Firstname)
                .NotEmpty ()
                .Matches ("^[a-zA-Z]*$");
            RuleFor (x => x.Lastname)
                .NotEmpty ()
                .Matches ("^[a-zA-Z]*$");
            RuleFor (x => x.Password)
                .NotEmpty ()
                .GreaterThan ("6");
            RuleFor (x => x.Email).EmailAddress ();
        }
    }
}