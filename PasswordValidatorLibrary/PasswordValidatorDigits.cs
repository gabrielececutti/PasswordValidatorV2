using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaswordValidatorConsoleApp
{
    public class PasswordValidatorDigits : PasswordDecoratorValidator
    {
        private readonly string _password;
        private readonly IPasswordValidator _passwordValidator;
        public PasswordValidatorDigits(string password, IPasswordValidator passwordValidator)
        {
            _password = password;
            _passwordValidator = passwordValidator;
        }

        public override string GetErrors()
        {
            if (IsValidThis()) return _passwordValidator.GetErrors();
            return $"{_passwordValidator.GetErrors()}the password must contains at least two digists{Environment.NewLine}";
        }

        public override bool IsValid() => _passwordValidator.IsValid() && IsValidThis();

        private bool IsValidThis()
        {
            int count = 0;
            foreach (char c in _password)
            {
                if (int.TryParse(c.ToString(), out int n)) count++; 
            }
            return count >= 2;
        }
    }
}

