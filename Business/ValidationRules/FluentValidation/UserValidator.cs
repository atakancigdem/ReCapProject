using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.FirstName).MinimumLength(2);
            RuleFor(u => u.Password).NotEmpty();
            RuleFor(u => u.Password).Must(IsPasswordValid).WithMessage("Şifrenizde en az bir büyük, küçük harf ve rakam bulunmak zorundadır. ");
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.LastName).MinimumLength(2);
        }
        
        private bool IsPasswordValid(string arg)
        {
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");
            return regex.IsMatch(arg);
        }
    }
}
