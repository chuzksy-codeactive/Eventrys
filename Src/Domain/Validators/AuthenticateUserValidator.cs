using Eventrys.Src.Model;
using FluentValidation;

namespace Eventrys.Src.Domain.Validators
{
    public class AuthenticateUserValidator : AbstractValidator<AuthenticateUser>
    {
        public AuthenticateUserValidator () 
        {
            RuleFor (x => x.Username).NotEmpty ();
            RuleFor (x => x.Password).NotEmpty ();
        }
    }
}