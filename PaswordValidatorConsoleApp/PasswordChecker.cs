using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaswordValidatorConsoleApp
{
    public static class PasswordChecker
    {
        public static (bool, string) GetResponse(string password)
        {
            IPasswordValidator checker = Init(password);
            return (checker.IsValid(), checker.GetErrors());
        }

        private static IPasswordValidator Init(string password)
        {
            IPasswordValidator passwordValidator = new PasswordValidatorBase(password);
            passwordValidator = new PasswordValidatorLength(password, passwordValidator);
            passwordValidator = new PasswordValidatorDigits(password, passwordValidator);
            passwordValidator = new PasswordValidatorUpperChar(password, passwordValidator);
            passwordValidator = new PasswordValidatorSpecialChar(password, passwordValidator);
            return passwordValidator;
        }
    }
}
