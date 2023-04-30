using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaswordValidatorConsoleApp
{
    public class PasswordValidatorBase : IPasswordValidator
    {
        private readonly string _password;
        public PasswordValidatorBase(string password) 
        {
            _password = password;
        }

        public string GetErrors()
        {
            if (IsValid()) return "";
            return $"the password must contain at least one character{Environment.NewLine}";
        }

        public bool IsValid() => !string.IsNullOrEmpty(_password);
    }
}
