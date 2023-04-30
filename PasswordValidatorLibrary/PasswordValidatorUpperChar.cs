using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaswordValidatorConsoleApp
{
    public class PasswordValidatorUpperChar : PasswordDecoratorValidator
    {
        private readonly string _password;
        private readonly IPasswordValidator _passwordValidator;
        public PasswordValidatorUpperChar(string password, IPasswordValidator passwordValidator)
        {
            _password = password;
            _passwordValidator = passwordValidator;
        }

        public override string GetErrors()
        {
            if (IsValidThis()) return _passwordValidator.GetErrors();
            return $"{_passwordValidator.GetErrors()}the password must contain at least one uppercase character {Environment.NewLine}";
        }

        public override bool IsValid() => _passwordValidator.IsValid() && IsValidThis();

        private bool IsValidThis() => _password.Any(c => char.IsUpper(c));
    }
}
