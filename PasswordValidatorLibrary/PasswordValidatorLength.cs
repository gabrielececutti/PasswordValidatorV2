using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaswordValidatorConsoleApp
{
    public class PasswordValidatorLength : PasswordDecoratorValidator
    {
        private readonly string _password;
        private readonly IPasswordValidator _passwordValidator;

        public PasswordValidatorLength(string password, IPasswordValidator passwordValidator) 
        {
            _password = password;
            _passwordValidator = passwordValidator;
        }
        public override string GetErrors()
        {
            if (IsValidThis) return _passwordValidator.GetErrors();
            return $"{_passwordValidator.GetErrors()}the password must be at least 8 characters long{Environment.NewLine}";
        }

        public override bool IsValid() => _passwordValidator.IsValid() && IsValidThis;

        private bool IsValidThis => _password.Length >= 8;
    }
}
