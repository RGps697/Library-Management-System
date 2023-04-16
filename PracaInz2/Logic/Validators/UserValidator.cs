using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    internal class UserValidator : AbstractValidator<User>
    {
        internal UserValidator()
        {
            RuleFor(p => p.FirstName)
                .NotEmpty()
                .WithMessage("Imię nie może być puste.");
            RuleFor(p => p.Surname)
                .NotEmpty()
                .WithMessage("Nazwisko nie może być puste.");
            RuleFor(p => p.Email)
                .NotEmpty()
                .WithMessage("Adres email nie może być pusty.")
                .EmailAddress()
                .WithMessage("Podany adres email jest nieprawidłowy.");
            RuleFor(p => p.PhoneNumber)
                .Custom((number, context) =>
                {
                    if ((!(int.TryParse(number, out int value)) || value < 0) && !string.IsNullOrEmpty(number))
                    {
                        context.AddFailure($"Numer telefonu jest nieprawidłowy");
                    }
                });
            RuleFor(p => p.Password)
                .MinimumLength(6)
                .WithMessage("Hasło musi zawierać conajmniej 6 znaków.");
            RuleFor(p => p.Role)
                .NotEmpty()
                .WithMessage("Rola nie może być pusta.");
        }
    }
}
