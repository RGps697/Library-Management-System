using FluentValidation;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(b => b.Title)
                .NotEmpty()
                .WithMessage("Tytuł nie może być pusty.");
            RuleForEach(b => b.Authors)
                .NotEmpty()
                .WithMessage("Pole autorów nie może być puste.");
            RuleFor(b => b.Field)
                .NotEmpty()
                .WithMessage("Pole dziedziny nie może być puste.");
            RuleFor(b => b.Publisher)
                .NotEmpty()
                .WithMessage("Pole wydawnictwa nie może być puste.");
            RuleFor(b => b.InventoryNumber)
                .NotEmpty()
                .WithMessage("Numer inwentarza nie może być puste.");
            RuleFor(b => b.PublicationYear)
                .Must(BeInRange)
                .WithMessage("Wprowadzony rok nie jest poprawny");
            RuleFor(b => b.NumberOfPages)
                .Must(BeInRange)
                .WithMessage("Wprowadzona ilość stron nie jest poprawna");
        }

        protected bool BeAValidFile(string filePath)
        {
            return System.IO.File.Exists(filePath);
        }

        protected bool BeInRange(int value)
        {
            if (value < 0) 
                return false;
            else 
                return true;
        }
    }
}
