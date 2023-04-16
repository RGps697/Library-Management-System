using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceLibrary.Logic.Validators
{
    internal class LibraryRoleValidator : AbstractValidator<LibraryRole>
    {
        public LibraryRoleValidator()
        {
            RuleFor(r => r.Name)
                .NotEmpty()
                .WithMessage("Nazwa roli nie może być pusta.");
        }
    }
}
